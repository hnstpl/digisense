using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.Models.Crop;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using AdminPortal.Mvc.Extensions;
using OfficeOpenXml.Extends;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AdminPortal.Mvc.Controllers
{
    public class CropController : Controller
    {
        const string STR_NUMBER_FORMAT = "0";
        const string STR_TIME_FORMAT = "hh:mm:ss";


        private readonly ICropsService _crops;

        private readonly IGlobalService _global;

        public CropController(ICropsService Crops, IGlobalService Global)
        {
            _crops = Crops;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crop()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            var languages = _global.GetLanguagedata();

            var Mandilist = _crops.GetMandiByLanguageID(1);
            Crop CropModel = new Crop
            {
                languageModel = new LanguageModel
                {
                    LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                    selectedLanguage = 1
                },
                Mapping = new CropMapping
                {
                    MandiList = new SelectList(Mandilist, "Mandi_ID", "Mandi_Name")
                },
                searchFilters = new SearchFilters
                {
                    SelectedLanguage = 1
                }
            };

            List<CropData> CropData = _crops.GetCropDataByLanguageID(1).ToList();


            ViewBag.CropList = CropData;
            HttpContext.Session.SetString("Dlangid", "");
            HttpContext.Session.SetString("State", "");
            HttpContext.Session.SetString("District", "");
            HttpContext.Session.SetString("MandiList", "");
            return View(CropModel);

        }

        //POST
        [HttpPost]
        public ActionResult Crop(Crop CropModelData)
        {
            try
            {
                var languages = _global.GetLanguagedata();

                int languageID = CropModelData.searchFilters.SelectedLanguage;

                var Mandilist = _crops.GetMandiByLanguageID(1);

                Crop CropDataModel = new Crop
                {
                    languageModel = new LanguageModel
                    {
                        LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                        selectedLanguage = 1
                    },
                    Mapping = new CropMapping
                    {
                        MandiList = new SelectList(Mandilist, "Mandi_ID", "Mandi_Name")

                    },
                    searchFilters = new SearchFilters
                    {
                        SelectedLanguage = languageID
                    }
                };

                List<CropData> CropData = _crops.GetCropDataByLanguageID(languageID).ToList();

                if (CropModelData.Mapping != null)
                {
                    if (CropModelData.Mapping.SelectedMandi != null)
                    {
                        ViewData["MandiList"] = CropModelData.Mapping.SelectedMandi;
                        HttpContext.Session.SetObject("MandiList", CropModelData.Mapping.SelectedMandi);
                        CropData = CropData.Where((x => CropModelData.Mapping.SelectedMandi.Contains(x.MandiID.ToString()))).ToList();
                    }

                }

                ViewBag.CropList = CropData;
                HttpContext.Session.SetString("Dlangid", languageID.ToString());
                return View(CropDataModel);

            }
            catch (Exception e)
            {
                return View();
            }

        }


        public FileStreamResult DownloadCropHistory(bool isEmpty = true)
        {
            var memStream = DownloadTemplate(isEmpty);
            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Crop History_" + GetLocalDateTime() + ".xlsx");
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

            FileInfo newFile = new FileInfo("Crops.xlsx");
            if (newFile.Exists)
            {
                newFile.Delete();  // ensures we create a new workbook
                newFile = new FileInfo("Crops.xlsx");
            }

            using (ExcelPackage xlPack = new ExcelPackage(newFile))
            {
                xlPack.Workbook.Properties.Title = "Admin  - Crop List";

                //Worksheet
                xlPack.Workbook.Worksheets.Add("Crop List");

                ExcelWorksheet xlSheet = xlPack.Workbook.Worksheets["Crop List"];
                xlSheet.Name = "Crop List";

                //Set Title 
                var cell = xlSheet.Cells[1, 1, 1, 11];
                xlSheet.Row(1).Height = 28;
                cell.Value = "Admin  - Crop List";
                //cell.Merge = true;
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
                HeaderRow(xlSheet, 3, 02, 4, 02, "Crop", true);
                HeaderRow(xlSheet, 3, 03, 4, 03, "Mandi", true);
                HeaderRow(xlSheet, 3, 04, 4, 04, "Category", true);
                HeaderRow(xlSheet, 3, 05, 4, 05, "Arrival Date", true);
                HeaderRow(xlSheet, 3, 06, 4, 06, "Last Modified Date", true);
                HeaderRow(xlSheet, 3, 07, 4, 07, "Min Price", true);
                HeaderRow(xlSheet, 3, 08, 4, 08, "Max Price", true);
                HeaderRow(xlSheet, 3, 09, 4, 09, "Modal Price", true);
                HeaderRow(xlSheet, 3, 10, 4, 10, "Image URL", true);
                HeaderRow(xlSheet, 3, 11, 4, 11, "Status", true);


                if (isEmpty)
                {
                    int ColIndex = 1;
                    int Rowindex = 5;

                    var value = GetCropdata();
                    int dno = 0;
                    foreach (CropData od in value)
                    {
                        dno++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(dno), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.CropName), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.MandiName), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.CategoryName), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ArrivalDate), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.MODIFIEDDT_D), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.MinPrice), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.MaxPrice), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ModalPrice), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ImageURL), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ACTIVEFLAG_C), false);
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

        public List<CropData> GetCropdata()
        {

            List<CropData> result = new List<CropData>();
            int languageID = 1;
            List<string> SelectedMandi = new List<string>();
            if (HttpContext.Session.GetString("Dlangid").ToString() != "")
            {
                languageID = Convert.ToInt32((HttpContext.Session.GetString("Dlangid")));
            }

            try
            {
                List<CropData> CropData = _crops.GetCropDataByLanguageID(languageID).ToList();
                    
                    
                    //(from p in entities.mst_mandi_crop_list
                    //                       join o in entities.mst_mandi_crop_list_lang on p.CropID equals o.CropID
                    //                       join d in entities.mst_mandi_crop_mapping on p.CropID equals d.CropID
                    //                       join s in entities.mst_mandi_list_lang on d.Mandi_ID equals s.Mandi_ID
                    //                       join c in entities.mst_mandi_crop_category_lang on d.CategoryID equals c.CategoryID
                    //                       where o.MST_LANG_ID == languageID && s.MST_LANG_ID == languageID && c.MST_LANG_ID == languageID
                    //                       select new CropData
                    //                       {
                    //                           CropID = p.CropID,
                    //                           CropName = o.CropName,
                    //                           ImageURL = p.ImageURL,
                    //                           MandiName = s.Mandi_Name,
                    //                           CategoryName = c.Category_Name,
                    //                           ArrivalDate = DbFunctions.TruncateTime(d.Arrival_Date),
                    //                           MinPrice = d.Min_Price,
                    //                           MaxPrice = d.Max_Price,
                    //                           ModalPrice = d.Modal_Price,
                    //                           ACTIVEFLAG_C = (p.ACTIVEFLAG_C == "A" ? "Active" : "In Active"),
                    //                           MandiID = d.Mandi_ID,
                    //                           MODIFIEDDT_D = (d.MODIFIEDDT_D == null ? DbFunctions.TruncateTime(d.CREATEDDT_D) : DbFunctions.TruncateTime(d.MODIFIEDDT_D))

                    //                       }).OrderBy(x => x.CropID).Distinct().ToList();


                if (HttpContext.Session.GetString("MandiList").ToString() != "")
                {
                    SelectedMandi = HttpContext.Session.GetObject<List<string>>("MandiList"); //(List<string>)Session["MandiList"];
                    CropData = CropData.Where((x => SelectedMandi.Contains(x.MandiID.ToString()))).ToList();
                }


                result = CropData;
                return result;

            }
            catch (Exception ex)
            {
                return result;
            }

        }


    }
}
