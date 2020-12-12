using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.ImplementSuitability;
using AdminPortal.Mvc.GlobalProvider;

namespace AdminPortal.Mvc.Services
{
    public class ImplementSuitabilityService : IImplementSuitability
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public ImplementSuitabilityService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<TractorModel> GetTractordata()
        {

            {
                List<TractorModel> result = new List<TractorModel>();

                    try
                    {

                        List<TractorModel> data = (from tm in _context.MstTpdhModel
                                                   join tmlang in _context.MstTpdhModelLang on tm.ModelcodeVc equals tmlang.ModelcodeVc
                                                   where tmlang.MstLangId == 1 && tm.ActiveflagC == "A"
                                                   orderby tmlang.ModelcodeVc ascending
                                                   select new TractorModel
                                                   {
                                                       TRACTORCODE = tm.ModelcodeVc,
                                                       TRACTORNAME = tmlang.ModelnameVc
                                                   }).ToList();

                        result = data;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        return result;
                    }
             
            }
        }

        public IEnumerable<TractorModel> GetTractorDataByBrand(string Brandcode)
        {

            {
                List<TractorModel> result = new List<TractorModel>();

                    try
                    {
                            List<TractorModel> data = (from tm in _context.MstTpdhModel
                            join tmlang in _context.MstTpdhModelLang on tm.ModelcodeVc equals tmlang.ModelcodeVc
                            where tmlang.MstLangId == 1 && tm.ActiveflagC == "A" && tm.BrandcodeVc == Brandcode
                            orderby tmlang.ModelnameVc ascending
                            select new TractorModel
                            {
                            TRACTORCODE = tm.ModelcodeVc,
                            TRACTORNAME = tmlang.ModelnameVc
                            }).ToList();

                        result = data;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        return result;
                    }
               
            }
        }


        public IEnumerable<TractorModel> GetBrandList()
        {

            {
                List<TractorModel> result = new List<TractorModel>();

            
                    try
                    {

                        List<TractorModel> data = (from p in _context.MstTpdhBrand
                            join o in _context.MstTpdhBrandLang on p.BrandcodeVc equals o.BrandcodeVc
                            where p.ActiveflagC == "A"
                            && o.ActiveflagC == "A"
                            && o.MstLangId == 1
                            select new TractorModel
                            {
                                BRANDCODE_VC = o.BrandcodeVc,
                                BRANDNAME_VC = o.BrandnameVc
                            }).ToList();

                        result = data;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        return result;
                    }
             
            }
        }


        public IEnumerable<ImplementModel> GetImplementdata()
        {

            {
                List<ImplementModel> result = new List<ImplementModel>();

             
                    try
                    {

                        List<ImplementModel> data = (from im in _context.MstIpdhModel
                                                     join imlang in _context.MstIpdhModelLang on im.ModelcodeVc equals imlang.ModelcodeVc
                                                     where imlang.MstLangId == 1 && im.ActiveflagC == "A"
                                                     orderby imlang.ModelnameVc ascending
                                                     select new ImplementModel
                                                     {
                                                         IMPLEMENTCODE = im.ModelcodeVc,
                                                         IMPLEMENTNAME = imlang.ModelnameVc
                                                     }).ToList();

                        result = data;
                        return result;
                    }
                    catch (Exception ex)
                    {
                        return result;
                    }
               
            }
        }


        public IEnumerable<ImplementModel> GetAvailableImplementdata(string Tractorcode)
        {

            {
                List<ImplementModel> result = new List<ImplementModel>();

              
                    try
                    {
                       

                        var assignedmodel = (from imassign in _context.ModelImplementSuitablityNew
                                             join imlang in _context.MstIpdhModelLang on imassign.IpdhModelcodeVc equals imlang.ModelcodeVc
                                             where imlang.MstLangId == 1 && imassign.ActiveflagC == "A" && imassign.TpdhModelcodeVc == Tractorcode
                                             orderby imlang.ModelnameVc ascending
                                             select new
                                             {
                                                 ASSIGNIMPLEMENTCODE = imassign.IpdhModelcodeVc
                                             }).ToList();
                        var assignedmodel1 = assignedmodel.Select(x => x.ASSIGNIMPLEMENTCODE);

                                                    List<ImplementModel> data = (from im in _context.MstIpdhModel
                                                     join imlang in _context.MstIpdhModelLang on im.ModelcodeVc equals imlang.ModelcodeVc
                                                     join imcategorylang in _context.MstIpdhModelgroupLang on im.IgcodeVc equals imcategorylang.IgcodeVc
                                                     where imlang.MstLangId == 1 && imcategorylang.MstLangId == 1
                                                     && im.ActiveflagC == "A"
                                                     && !assignedmodel1.Contains(im.ModelcodeVc)
                                                     orderby imlang.ModelnameVc ascending
                                                     select new ImplementModel
                                                     {
                                                         IMPLEMENTCODE = im.ModelcodeVc,
                                                         IMPLEMENTNAME = string.Concat(imlang.ModelnameVc, " - ", imcategorylang.IgnameVc),
                                                     }).ToList();


                           

                    result = data;
                        return result;
                    }

                    catch (Exception ex)
                    {
                        return result;
                    }
               
            }
        }



        public IEnumerable<AvailableAssignment> GetAssignedImplementdata(string Tractorcode)
        {

            {
                List<AvailableAssignment> result = new List<AvailableAssignment>();

              
                    try
                    {

                        List<AvailableAssignment> data = (from imassign in _context.ModelImplementSuitablityNew
                                                          join imlang in _context.MstIpdhModelLang on imassign.IpdhModelcodeVc equals imlang.ModelcodeVc
                                                          join im in _context.MstIpdhModel on imassign.IpdhModelcodeVc equals im.ModelcodeVc
                                                          join imcategorylang in _context.MstIpdhModelgroupLang on im.IgcodeVc equals imcategorylang.IgcodeVc
                                                          where imlang.MstLangId == 1 && imassign.ActiveflagC == "A" && imassign.TpdhModelcodeVc == Tractorcode
                                                          orderby imlang.ModelnameVc ascending
                                                          select new AvailableAssignment
                                                          {
                                                              ASSIGNIMPLEMENTCODE = imassign.IpdhModelcodeVc,
                                                              ASSIGNIMPLEMENTNAME = string.Concat(imlang.ModelnameVc, " - ", imcategorylang.IgnameVc),
                                                          }).ToList();


                        result = data;
                        return result;
                    }

                    catch (Exception ex)
                    {
                        return result;
                    }
                
            }
        }


        public Boolean UpdateInActive(string[] TractorcodeArr, string User)
        {
            
            for (int index = 0; index < TractorcodeArr.Length; index++)
            {
                string Traccode = TractorcodeArr[index];

                _context.ModelImplementSuitablityNew.Where(x => x.TpdhModelcodeVc == Traccode).ToList().ForEach(x =>
                    {
                        x.ActiveflagC = "I"; x.ModifiedbyVc = User; x.ModifieddtD = DateTime.UtcNow;
                    });
                _context.SaveChanges();
            }
            return true;
        }

        public Boolean AddNewImplementAssignment(string[] TractorcodeArr, string[] implemtassigncodeArr, string User)
        {

            for (int index = 0; index < TractorcodeArr.Length; index++)
            {
                string Traccode = TractorcodeArr[index];

                for (int index1 = 0; index1 < implemtassigncodeArr.Length; index1++)
                {
                    string Impcode = implemtassigncodeArr[index1];
                    var modelsuitability = new ModelImplementSuitablityNew();
                    modelsuitability.TpdhModelcodeVc = Traccode;
                    modelsuitability.IpdhModelcodeVc = Impcode;
                    modelsuitability.ActiveflagC = "A";
                    modelsuitability.SectoridI = 1;
                    modelsuitability.CreatedbyVc = User.ToString();
                    modelsuitability.CreateddtD = DateTime.UtcNow;
                    _context.ModelImplementSuitablityNew.Add(modelsuitability);
                }
            }
            _context.SaveChanges();

            return true;
        }



    }
}
