using DIYMaster.WebAPI.DataProvider;
using DIYMaster.WebAPI.Models.DIY;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace DIYMaster.WebAPI.Services
{
    public class DIYService:IDIYService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;
        public static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        string moduleName = "";
        public DIYService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("DIYMastes:DIY");
        }

        public MastersModel GetDIY(string LanguageCode, string customerCode)
        {

            MastersModel masterModel = new MastersModel();


            //Get Languages
            List<MstLanguage> languages = _global.GetFallBackLanguage(LanguageCode, customerCode); //Global.GetLanguageList(input.languagecode, customerCode);

            List<DIYList> diyVideos = new List<DIYList>();

            var DIYVideoIDList = new List<int>();


            foreach (var Language in languages)
            {
                //Get list of videos
                List<DIY> diyVideo = (from p in _context.MstDiyVideoLang
                                      join o in _context.MstDiyVideo on p.DiyId equals o.DiyId
                                      where p.MstLangId == Language.Id
                                      && p.ActiveflagC == "A"
                                      && o.ActiveflagC == "A"
                                      && !DIYVideoIDList.Contains(o.DiyId)
                                      select new DIY
                                      {
                                          videoid = o.DiyId,
                                          videoname = p.DiyName,
                                          videodescription = p.DiyDescription,
                                          videocategoryid = o.DiyCategory,
                                          videourl = p.VideoPath,
                                          //createddate = o.CREATEDDT_D.HasValue ? DbFunctions.DiffSeconds(o.CREATEDDT_D.Value, Global.epoch).Value : 0,
                                          //modifieddate = o.MODIFIEDDT_D.HasValue ? DbFunctions.DiffSeconds(o.MODIFIEDDT_D.Value, Global.epoch).Value : 0,
                                          //createddate = o.CreateddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.CreateddtD.Value, epoch).Value : 0,
                                          //modifieddate = o.ModifieddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ModifieddtD.Value, epoch).Value : 0,
                                      }).Distinct().ToList();


                ////Get list of videos
                //List<DIY> diyVideo = (from p in entities.mst_diy_video
                //                      where p.ACTIVEFLAG_C == "A"
                //                      select new DIY
                //                      {
                //                          videoid = p.DIY_ID,
                //                          videoname = 
                //                          videocategoryid = p.DIY_Category,
                //                          videourl = o.DIY_VIDEO_URL,
                //                          createddate = p.CREATEDDT_D.HasValue ? DbFunctions.DiffSeconds(p.CREATEDDT_D.Value, Global.epoch).Value : 0,
                //                          modifieddate = p.MODIFIEDDT_D.HasValue ? DbFunctions.DiffSeconds(p.MODIFIEDDT_D.Value, Global.epoch).Value : 0,
                //                      }).Distinct().ToList();

                diyVideo.ForEach(x =>
                {
                    DIYVideoIDList.Add(x.videoid);

                    x.videocategoryvalue = (from p in _context.MstDiyVideoCategoryLang
                                            join o in _context.MstDiyVideoCategory on p.DiyId equals o.Id
                                            where p.MstLangId == Language.Id
                                            && p.ActiveflagC == "A"
                                            && o.ActiveflagC == "A"
                                            select p.CategoryName).FirstOrDefault();

                    x.tractors = (from p in _context.TblDiyVideoModelmapping
                                  where p.ActiveflagC == "A"
                                  //&& customerModels.Contains(p.MODELCODE_VC)
                                  && p.DiyId == x.videoid
                                  select new DIY_Tractors
                                  {
                                      modelcode = p.ModelcodeVc
                                  }).Distinct().ToList();
                });

                DIYList DIYList = new DIYList
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    diyvideos = diyVideo,
                    totalrecords = diyVideo.Count
                };

                diyVideos.Add(DIYList);
            }



            masterModel.masters = diyVideos;

            return masterModel;

        }
    }
}
