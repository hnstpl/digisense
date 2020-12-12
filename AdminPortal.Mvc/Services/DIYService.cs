using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.DIY;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace AdminPortal.Mvc.Services
{
    public class DIYService : IDIYService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;

        private string VirtualPath4Video = "";
  
        private string ActualPath4Video = "";
        public IConfiguration _configuration { get; }
        public DIYService(dev_encrypted_generalcustomerappContext Context, IConfiguration configuration, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
            _configuration = configuration;

            VirtualPath4Video = _configuration.GetValue<string>("DIY:VirtualPath4TpdhVideo");
            ActualPath4Video = _configuration.GetValue<string>("DIY:ActualPath4TpdhVideo");


        }

        public IEnumerable<MstDiyVideo> GetAll()
        {
            return _context.MstDiyVideo.Where(x => x.ActiveflagC == "A").ToList();
        }

        public IEnumerable<MstDiyVideoCategoryLang> GetCategoryByLanguageID(int LanguageID)
        {
            return _context.MstDiyVideoCategoryLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == LanguageID).ToList();
        }

        public MstDiyVideo CreateMasterVideo(MstDiyVideo Record)
        {
            _context.MstDiyVideo.Add(Record);

            _context.SaveChanges();

            return Record;
        }

        public IEnumerable<VideoProperties> GetVideoProperties(int CategoryID, int LanguageID)
        {
            List<VideoProperties> videoProperties = new List<VideoProperties>();
            try
            {
                 return videoProperties = (from p in _context.MstDiyVideo
                                   join s in _context.MstDiyVideoLang on p.DiyId equals s.DiyId
                                   join l in _context.MstDiyVideoCategory on p.DiyCategory equals l.Id
                                   join c in _context.MstDiyVideoCategoryLang on l.Id equals c.DiyId
                                   where p.ActiveflagC == "A" && s.MstLangId == LanguageID && c.MstLangId == LanguageID
                                   && (CategoryID == 0 || l.Id == CategoryID)
                                   select new VideoProperties
                                   {
                                       DIY_ID = p.DiyId,
                                       DIY_NAME = s.DiyName,
                                       DIY_Description = s.DiyDescription,
                                       DIY_Category = c.CategoryName
                                   }
                          ).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DIY GetDIYVideos(int Search,SearchFilters searchFilters)
        {

            DIY diy = new DIY();

          try
            { 

                diy.searchFilters = new SearchFilters
                {
                    SelectedLanguage = 1
                };

          
                if (Search == 1)
                {
                    diy.searchFilters = new SearchFilters();
                    diy.videoProperties = GetVideoProperties(searchFilters.SelectedCategory, searchFilters.SelectedLanguage);
                    diy.searchFilters.SelectedLanguage = searchFilters.SelectedLanguage;
                    diy.searchFilters.SelectedCategory = searchFilters.SelectedCategory;

                }
                else
                {

                    diy.videos = _context.MstDiyVideo.Where(x => x.ActiveflagC == "A").ToList();
                    diy.videoProperties = GetVideoProperties(0, 1).ToList();

                }

                diy.videocategory = _context.MstDiyVideoCategoryLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == 1).ToList();
                diy.languages = _global.GetLanguagedata().ToList();

                

              
            }
            catch(Exception ex)
            {

            }
            return diy;
            }


        public AddNewDIY AddDIYVideos(int Id)
        {
            AddNewDIY addNewDIY = new AddNewDIY();
            try
            {
               
                    var Videocategory = _context.MstDiyVideoCategoryLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == 1 ).ToList();
                    var LanguageList = _global.GetLanguagedata().ToList();
                    var VideoTypeList = _context.MstDiyVideotypes.Where(x => x.ActiveflagC == "A").ToList();


                    addNewDIY.Videocategorylist = new SelectList(Videocategory, "DiyId", "CategoryName");
                    addNewDIY.VideoTypeList = new SelectList(VideoTypeList, "Id", "VideoType");
                    addNewDIY.LanguageList = new SelectList(LanguageList, "Languageid", "Languagename");

                    List<NewDIY> newDIYs = new List<NewDIY>();
                    newDIYs.Add(new NewDIY()
                    {
                        LanguageID = 0,
                        LanguageName = "",
                        VideoDescription = "",
                        VideoId = 0,
                        VideoName = "",
                        VideoTypeDescription = "",
                        VideoStatus = "A",
                        VideoType = 0,
                        VideoURI = "",
                        ID = 0
                    });

                    addNewDIY.newDIYTemplate = newDIYs;
                    
                    if (Id > 0)
                    {
                        addNewDIY.CategoryID = _context.MstDiyVideo.Where(x => x.DiyId == Id).SingleOrDefault().DiyCategory;
                        addNewDIY.VideoID = Id;
                    }
                    addNewDIY.newDIY = GetAddNewDIYsList(Id).ToList();
                




            }
            catch (Exception ex)
            {

            }
            return addNewDIY;
        }
        public IEnumerable<NewDIY> GetAddNewDIYsList(int Id)
        {
            List<NewDIY> addNewDIYList = new List<NewDIY>();

            try
            {

                
                addNewDIYList = (from p in _context.MstDiyVideo
                                 join s in _context.MstDiyVideoLang on p.DiyId equals s.DiyId
                                 join l in _context.MstLanguage on s.MstLangId equals l.Id
                                 join v in _context.MstDiyVideotypes on s.VideoTypeId equals v.Id
                                 where p.DiyId == Id
                                 select new NewDIY
                                 {
                                     LanguageID = s.MstLangId,
                                     LanguageName = l.LanguageName,
                                     VideoId = s.DiyId,
                                     VideoName = s.DiyName  ,
                                     VideoDescription = s.DiyDescription,
                                     VideoType = s.VideoTypeId,
                                     VideoTypeDescription = v.VideoType,
                                     VideoStatus = s.ActiveflagC,
                                     VideoURI = s.VideoPath,
                                     ID = s.Id
                                 }
                                ).ToList();
            }
            catch (Exception ex)
            {

            }
            return addNewDIYList;
        }

        public int Add(AddNewDIY input)
        {
            int VideoId = 0;
            try
            {
                                        

                    List<NewDIY> newDIYs = input.newDIY;
                    if (newDIYs == null)
                    {
                        newDIYs = new List<NewDIY>();
                    }

                    foreach (var item in newDIYs)
                    {
                        if (item.ID == 0)
                        {
                            MstDiyVideoLang diylang = new MstDiyVideoLang();
                            diylang.DiyId = item.VideoId;
                            diylang.MstLangId = item.LanguageID;
                            diylang.VideoPath = item.VideoURI;
                            diylang.DiyName = item.VideoName;
                            diylang.DiyDescription = item.VideoDescription;
                            diylang.VideoTypeId = item.VideoType;
                            diylang.ActiveflagC = item.VideoStatus;
                            diylang.CreateddtD = DateTime.Now;
                            _context.MstDiyVideoLang.Add(diylang);
                            _context.SaveChanges();
                        }
                        else
                        {
                        MstDiyVideoLang diylangupdate = _context.MstDiyVideoLang.Single(model => model.Id == item.ID);
                            diylangupdate.DiyName = item.VideoName;
                            diylangupdate.DiyDescription = item.VideoDescription;
                            diylangupdate.VideoTypeId = item.VideoType;
                            diylangupdate.VideoPath = item.VideoURI;
                            diylangupdate.ActiveflagC = item.VideoStatus;
                            diylangupdate.ModifieddtD = DateTime.Now;
                            _context.SaveChanges();
                        }
                    


                }
                VideoId = input.VideoID;
            }
            catch (Exception ex)
            {

            }
              return VideoId;
        }
        public MstDiyVideo GetVideoID(int CategoryID)
        {
            
                MstDiyVideo Record = new MstDiyVideo
                {
                    DiyCategory = CategoryID,
                    ActiveflagC = "A",
                    CreateddtD = DateTime.Now
                    //CreatedbyVc = Session["User"].ToString()
                };


                Record = CreateMasterVideo(Record);


            return Record;

        }

        public string GetVideoURL(int VideoId, int IsUpdate, int LanguageId, string Host, IFormFile DIYVideo, string FileName4Video)
        {
            string ActualVideoName = "";          
            string VideoURL = "";            
            try
            {                   

                    ActualVideoName = _global.UploadImage(DIYVideo, FileName4Video, VirtualPath4Video);
                    //ActualVideoName = UploadImage(DIYVideo, FileName4Video, VirtualPath4Video);

                    VideoURL = Host + ActualPath4Video + ActualVideoName; ;
            
            }
            catch (Exception ex)
            {
                
            }
            return VideoURL;
        }
    }
}
