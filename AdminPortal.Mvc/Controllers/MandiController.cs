using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.Models.Mandi;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using AdminPortal.Mvc.Extensions;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AdminPortal.Mvc.Controllers
{
    public class MandiController : Controller
    {
        const string STR_NUMBER_FORMAT = "0";
        const string STR_TIME_FORMAT = "hh:mm:ss";
        List<string> MandiState = new List<string>();
        List<string> MandiDistrict = new List<string>();


        private readonly IMandiService _mandi;

        private readonly IGlobalService _global;

        public MandiController(IMandiService Mandi, IGlobalService Global)
        {
            _mandi = Mandi;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Mandi()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            var languages = _global.GetLanguagedata();

            var statesList = _global.GetStatesBylanguageID(1);
            var districtList = _global.GetDistrictsBylanguageID(1);

            MandiModel MandiDataModel = new MandiModel
            {
                languageModel = new LanguageModel
                {
                    LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                    selectedLanguage = 1
                },
                Mapping = new MandiMapping
                {
                    StateList = new SelectList(statesList, "StateCodeI", "StateNameVc"),
                    DistrictList = new SelectList(districtList, "DistrictCodeVc", "DistrictNameVc")
                },
                searchFilters = new SearchFilters
                {
                    SelectedLanguage = 1
                }
            };

            //Later will replace the hardcoded parameter
            List<Mandi> MandiData = _mandi.GetMandiDataByLanguageID(1).ToList();


            ViewBag.MandiList = MandiData;
            HttpContext.Session.SetString("Dlangid", "");
            HttpContext.Session.SetString("Statelist", "");
            HttpContext.Session.SetString("Districtlist", "");
            return View(MandiDataModel);

        }

        //POST
        [HttpPost]
        public IActionResult Mandi(MandiModel MandiModelData)
        {
            try
            {
                var languages = _global.GetLanguagedata();

                int languageID = MandiModelData.searchFilters.SelectedLanguage;

                var statesList = _global.GetStatesBylanguageID(1);
                var districtList = _global.GetDistrictsBylanguageID(1);

                MandiModel MandiDataModel = new MandiModel
                {
                    languageModel = new LanguageModel
                    {
                        LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                        selectedLanguage = 1
                    },
                    Mapping = new MandiMapping
                    {
                        StateList = new SelectList(statesList, "StateCodeI", "StateNameVc"),
                        DistrictList = new SelectList(districtList, "DistrictCodeVc", "DistrictNameVc")
                    },
                    searchFilters = new SearchFilters
                    {
                        SelectedLanguage = languageID
                    }
                };

                List<Mandi> MandiData = _mandi.GetMandiDataByLanguageID(languageID).ToList();
                    
                    
                    //(from p in entities.mst_mandi_list
                    //                     join o in entities.mst_mandi_list_lang on p.Mandi_ID equals o.Mandi_ID
                    //                     join d in entities.mst_district_lang on o.DistrictName_VC equals d.DistrictName_VC
                    //                     join s in entities.mst_state_lang on o.StateName_VC equals s.StateName_VC

                    //                     where o.MST_LANG_ID == languageID
                    //                     select new Mandi
                    //                     {
                    //                         Mandi_ID = p.Mandi_ID,
                    //                         Mandi_Name = o.Mandi_Name,
                    //                         StateName_VC = o.StateName_VC,
                    //                         DistrictName_VC = o.DistrictName_VC,
                    //                         ACTIVEFLAG_C = p.ACTIVEFLAG_C,
                    //                         StateCode_I = p.StateCode_I,
                    //                         DistrictCode_VC = p.DistrictCode_VC

                    //                     }).OrderBy(x => x.Mandi_ID).Distinct().ToList();


                if (MandiModelData.Mapping != null)
                {
                    if (MandiModelData.Mapping.SelectedStates != null)
                    {
                        ViewData["Statelist"] = MandiModelData.Mapping.SelectedStates;
                        HttpContext.Session.SetObject("Statelist", MandiModelData.Mapping.SelectedStates);
                        MandiData = MandiData.Where((x => MandiModelData.Mapping.SelectedStates.Contains(x.StateCode_I))).ToList();
                        HttpContext.Session.SetObject("State", MandiModelData.Mapping.SelectedStates);
                        MandiState = MandiModelData.Mapping.SelectedStates;

                    }
                    if (MandiModelData.Mapping.SelectedDistricts != null)
                    {
                        ViewData["Districtlist"] = MandiModelData.Mapping.SelectedDistricts;
                        HttpContext.Session.SetObject("Districtlist", MandiModelData.Mapping.SelectedDistricts);
                        MandiData = MandiData.Where((x => MandiModelData.Mapping.SelectedDistricts.Contains(x.DistrictCode_VC))).ToList();
                        HttpContext.Session.SetObject("District", MandiModelData.Mapping.SelectedDistricts);
                        MandiDistrict = MandiModelData.Mapping.SelectedDistricts;
                    }
                }

                ViewBag.MandiList = MandiData;
                HttpContext.Session.SetString("Dlangid", languageID.ToString());
                return View(MandiDataModel);

            }
            catch (Exception e)
            {
                return View();
            }

        }


        public FileStreamResult DownloadMandiHistory(bool isEmpty = true)
        {
            var memStream = DownloadTemplate(isEmpty);
            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Mandi History_" + GetLocalDateTime() + ".xlsx");
        }

        public static DateTime GetLocalDateTime()
        {
            DateTime Result = DateTime.UtcNow;

            //string TimeZoneID = ConfigurationManager.AppSettings["Timezone"].ToString();
            string TimeZoneID = "Asia/Kolkata";
            TimeZoneInfo TimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneID);
            DateTime CurrentUTC = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            Result = TimeZoneInfo.ConvertTimeFromUtc(CurrentUTC, TimeZone);
            return Result;
        }

        public MemoryStream DownloadTemplate(bool isEmpty)
        {
            MemoryStream memStream;
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            using (ExcelPackage xlPack = new ExcelPackage())
            {
                xlPack.Workbook.Properties.Title = "Admin  - Mandi List";

                //Worksheet
                xlPack.Workbook.Worksheets.Add("Mandi List");

                ExcelWorksheet xlSheet = xlPack.Workbook.Worksheets["Mandi List"];
                xlSheet.Name = "Mandi List";

                //Set Title 
                var cell = xlSheet.Cells[1, 1, 1, 04];
                xlSheet.Row(1).Height = 28;
                cell.Value = "Admin  - Mandi List";
                cell.Merge = true;
                cell.Style.Font.Size = 15;
                cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cell.Style.Font.Bold = true;
                cell.Style.Font.Name = "Calibri";
                cell.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell.Style.Border.Right.Color.SetColor(System.Drawing.Color.White);
                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(98, 124, 160));

                HeaderRow(xlSheet, 2, 01, 2, 01, "Downloaded on", true);
                HeaderRow(xlSheet, 2, 02, 2, 19, string.Format("{0:MMM-dd-yyyy hh-mm-ss tt}", GetLocalDateTime()), true, "Left");

                //Set second row static headers
                HeaderRow(xlSheet, 3, 01, 4, 01, "Sl.No", true);
                //  HeaderRow(xlSheet, 3, 01, 4, 01, "Code", true);
                HeaderRow(xlSheet, 3, 02, 4, 02, "Mandi", true);
                HeaderRow(xlSheet, 3, 03, 4, 03, "State", true);
                HeaderRow(xlSheet, 3, 04, 4, 04, "District", true);


                if (isEmpty)
                {
                    int ColIndex = 1;
                    int Rowindex = 5;

                    var value = GetMandidata();
                    int dno = 0;
                    foreach (Mandi od in value)
                    {
                        dno++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(dno), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.Mandi_Name), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.StateName_VC), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.DistrictName_VC), false);
                        ColIndex++;
                        Rowindex++;
                        ColIndex = 1;
                    }
                }

                xlSheet.View.FreezePanes(5, 1);
                memStream = new MemoryStream(xlPack.GetAsByteArray());
            }
            return memStream;
        }

        public void HeaderRow(ExcelWorksheet WorkSheet, int RowStartIndex, int ColStartIndex, int RowEndIndex, int ColEndIndex, string Value, bool isMerged, string align = "Center")
        {
            ExcelRange range = WorkSheet.Cells[RowStartIndex, ColStartIndex, RowEndIndex, ColEndIndex];
            range.Value = Value;
            range.Style.Font.Name = "Calibri";
            range.Style.Font.Size = 12;
            range.Style.Font.Bold = true;
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            switch (align)
            {
                case "Center":
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    break;
                case "Left":
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    break;
                case "Right":
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    break;
                case "Justify":
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Justify;
                    break;
            }

            range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            //range.Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.White);


            range.Style.Border.Right.Style = ExcelBorderStyle.Hair;
            range.Style.Border.Right.Color.SetColor(System.Drawing.Color.Black);
            if (isMerged == true) range.Merge = true;
            else if (isMerged == false) range.Merge = false;
            switch (Value)
            {
                case "Sub Category":
                    WorkSheet.Column(ColStartIndex).Width = 28;
                    break;
                case "Category":
                    WorkSheet.Column(ColStartIndex).Width = 28;
                    break;
                default:
                    WorkSheet.Column(ColStartIndex).Width = 28;
                    break;
            }
        }

        //
        public void CreateExcelData(ExcelWorksheet xlSheet, int RowIndex, int ColIndex, string Value, bool IsFormatRequired, string FormatType = "")
        {
            var FormatedValue = string.Empty;
            var cell = xlSheet.Cells[RowIndex, ColIndex];
            cell.Style.Font.Size = 12;
            cell.Style.Font.Name = "Calibri";

            var fill = cell.Style.Fill;
            fill.PatternType = ExcelFillStyle.Solid;
            fill.BackgroundColor.SetColor(System.Drawing.Color.White);
            cell.Style.Border.Right.Style = ExcelBorderStyle.Hair;
            cell.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
            cell.Style.Border.Top.Style = ExcelBorderStyle.Hair;
            if (IsFormatRequired)
            {
                switch (FormatType)
                {
                    case "DATE":
                        if (Value != "")
                        {
                            FormatedValue = string.Format("{0:dd-MMM-yyyy}", Convert.ToDateTime(Value));
                            cell.Value = FormatedValue;
                        }
                        else cell.Value = Value;
                        break;
                    case "STATUS":
                        if (Value.ToLower() == "true")
                            FormatedValue = "Active";
                        else
                            FormatedValue = "Inactive";
                        cell.Value = FormatedValue;
                        break;
                    case "BOOLEAN":
                        if (Value.ToLower() == "true")
                            FormatedValue = "Yes";
                        else
                            FormatedValue = "No";
                        cell.Value = FormatedValue;
                        break;
                    case "NUMBER":
                        cell.Value = Convert.ToDecimal(Value);
                        cell.Style.Numberformat.Format = STR_NUMBER_FORMAT;
                        break;
                    case "TIME":
                        cell.Value = TimeSpan.Parse(Value);
                        cell.Style.Numberformat.Format = STR_TIME_FORMAT;
                        break;
                    case "":
                        cell.Value = Value;
                        break;
                    default:
                        cell.Value = Value;
                        break;
                }
            }
            else
                cell.Value = Value;
        }

        public List<Mandi> GetMandidata()
        {

            List<Mandi> result = new List<Mandi>();
            List<string> SelectedState = new List<string>();
            List<string> SelectedDistrict = new List<string>();


            int languageID = 1;

            if (HttpContext.Session.GetString("Dlangid").ToString() != "")
            {
                languageID = Convert.ToInt32(HttpContext.Session.GetString("Dlangid"));
            }

            try
            {

                MandiModel MandiDataModel = new MandiModel();

                List<Mandi> MandiData = _mandi.GetMandiDataByLanguageID(languageID).ToList();
                    
                    //(from p in entities.mst_mandi_list
                    //                     join o in entities.mst_mandi_list_lang on p.Mandi_ID equals o.Mandi_ID
                    //                     join d in entities.mst_district_lang on o.DistrictName_VC equals d.DistrictName_VC
                    //                     join s in entities.mst_state_lang on o.StateName_VC equals s.StateName_VC

                    //                     where o.MST_LANG_ID == languageID
                    //                     select new Mandi
                    //                     {
                    //                         Mandi_ID = p.Mandi_ID,
                    //                         Mandi_Name = o.Mandi_Name,
                    //                         StateName_VC = o.StateName_VC,
                    //                         DistrictName_VC = o.DistrictName_VC,
                    //                         ACTIVEFLAG_C = p.ACTIVEFLAG_C,
                    //                         StateCode_I = p.StateCode_I,
                    //                         DistrictCode_VC = p.DistrictCode_VC

                    //                     }).OrderBy(x => x.Mandi_ID).Distinct().ToList();



                if (HttpContext.Session.GetString("Statelist").ToString() != "")
                {
                    SelectedState = HttpContext.Session.GetObject<List<string>>("Statelist"); //(List<string>)Session["Statelist"];
                    MandiData = MandiData.Where((x => SelectedState.Contains(x.StateCode_I.ToString()))).ToList();
                }

                if (HttpContext.Session.GetString("Districtlist").ToString() != "")
                {
                    SelectedDistrict = HttpContext.Session.GetObject<List<string>>("Districtlist"); //(List<string>)Session["Districtlist"];
                    MandiData = MandiData.Where((x => SelectedDistrict.Contains(x.DistrictCode_VC.ToString()))).ToList();
                }


                result = MandiData;
                return result;

            }
            catch (Exception ex)
            {
                return result;
            }

        }
    }

    
}
