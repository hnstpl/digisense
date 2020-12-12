using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPortal.Mvc.Models;
using AdminPortal.Mvc.Models.Enquiry;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Globalization;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Configuration;




namespace AdminPortal.Mvc.Controllers
{
    //[RoutePrefix("Enquiry")]
    public class EnquiryController : Controller
    {

        private readonly IEnquiry _Enquiry;
        private readonly IGlobalService _global;
        const string STR_NUMBER_FORMAT = "0";
        const string STR_TIME_FORMAT = "hh:mm:ss";
        DateTime fromDate;
        DateTime toDate;


        public EnquiryController(IEnquiry Enquiry, IGlobalService Global)
        {
            _Enquiry = Enquiry;
            _global = Global;
        }


       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Enquiry ()
        {
            try
            {

              

                ViewBag.LangListItem = _Enquiry.GetLanguagedata().ToList();

                int langid = 1;
                    List<Enquiry> result = new List<Enquiry>();
         
                    fromDate = DateTime.Now.AddMonths(-3);
                    toDate = DateTime.Now;
            
                    ViewBag.Enquirylist = _Enquiry.GetEnquirydata(langid);
                    HttpContext.Session.SetString("Dlangid", "");
                    HttpContext.Session.SetString("Enqtype", "");
                    HttpContext.Session.SetString("prodtype", "");
                    HttpContext.Session.SetString("validity", "");
                    return View();

           }
           catch (Exception ex)
           {
                return View();
           }


        }

        [HttpPost]
        public IActionResult Enquiry(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _Enquiry.GetLanguagedata().ToList();

            int langid = 1;
            int enqtype = 0;
            int prodtype = 0;
            
           
            if (formCollection.ContainsKey("cmblang"))
            {
                langid = Convert.ToInt32(formCollection["cmblang"]);
            }

            if (formCollection.ContainsKey("Validity"))
            {
                var Dates = formCollection["Validity"].ToString().Split('-');
                DateTime.TryParseExact(Dates[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate);
                DateTime.TryParseExact(Dates[1].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate);
            }

           
            try
            {
               

                if (Convert.ToInt32(formCollection["cmbEnqtype"]) > 0)
                {
                    enqtype = Convert.ToInt32(formCollection["cmbEnqtype"]);
                }

                if (Convert.ToInt32(formCollection["cmbprodtype"]) > 0)
                {
                    prodtype = Convert.ToInt32(formCollection["cmbprodtype"]);
                }


               
                ViewBag.Enquirylist = _Enquiry.GetEnquirydatabySearch(langid, fromDate, toDate, enqtype, prodtype);
                HttpContext.Session.SetString("Dlangid", langid.ToString());
                HttpContext.Session.SetString("Enqtype", enqtype.ToString());
                HttpContext.Session.SetString("prodtype", prodtype.ToString());
                HttpContext.Session.SetString("validity", formCollection["Validity"]);

                return View();

            }
            catch (Exception ex)
            {
                return View();
            }


        }

        [HttpPost]
        public ContentResult Updateenquiry(IFormCollection formCollection)
        {
            string message = "sucess";
            try
            {

                int enquiryid = Convert.ToInt32(formCollection["enquiryid"]);
                string active = formCollection["active"];
                string updateduser = HttpContext.Session.GetString("User");

                var UpdateStatus = _Enquiry.Updateenquiry(enquiryid, active, updateduser);
                if (UpdateStatus==false)
                {
                    message = "error";
                }

                return Content(message);
            }
            catch (Exception e)
            {
                message = "error";
                return Content(message);
            }


        }

        public FileStreamResult DownloadEnquiryHistory(bool isEmpty = true)
        {
            var memStream = DownloadTemplate(isEmpty);
            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Enquiry History_" + GetLocalDateTime() + ".xlsx");
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
                xlPack.Workbook.Properties.Title = "Admin  - User / Referral Enquiry";

                //Worksheet
                xlPack.Workbook.Worksheets.Add("Enquiry History");

                ExcelWorksheet xlSheet = xlPack.Workbook.Worksheets["Enquiry History"];
                xlSheet.Name = "Enquiry History";

                //Set Title 
                var cell = xlSheet.Cells[1, 1, 1, 11];
                xlSheet.Row(1).Height = 28;
                cell.Value = "Admin  - User / Referral Enquiry";
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
                //HeaderRow(xlSheet, 3, 01, 4, 01, "Sl.No", true);
                HeaderRow(xlSheet, 3, 01, 4, 01, "Dealer", true);
                HeaderRow(xlSheet, 3, 02, 4, 02, "Branch", true);
                HeaderRow(xlSheet, 3, 03, 4, 03, "Customer", true);
                HeaderRow(xlSheet, 3, 04, 4, 04, "Enquiry Type", true);
                HeaderRow(xlSheet, 3, 05, 4, 05, "Product Type", true);
                HeaderRow(xlSheet, 3, 06, 4, 06, "Model", true);
                HeaderRow(xlSheet, 3, 07, 4, 07, "Enquired By", true);
                HeaderRow(xlSheet, 3, 08, 4, 08, "Enquired Date", true);
                HeaderRow(xlSheet, 3, 09, 4, 09, "MemberShip No", true);
                HeaderRow(xlSheet, 3, 10, 4, 10, "MemberShip Date", true);
                HeaderRow(xlSheet, 3, 11, 4, 11, "Remarks", true);
                
                if (isEmpty)
                {
                    int ColIndex = 1;
                    int Rowindex = 5;

                    var value = GetEnquirydata();
                    int dno = 0;
                    foreach (Enquiry od in value)
                    {
                        dno++;
                       // CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(dno), false);
                        //ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.DealerName), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.DealerBranchName_VC), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.CustName_VC), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.EnqTypeName), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ProductNImplement == 1 ? "Tractors" : "Implements"), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.TPDH_MODELNAME_VC), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.CustName_VC), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToDateTime(od.CREATEDDT_D).ToString("dd-MMM-yyyy"), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.MemberShipNp), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToDateTime(od.MemberShipDate).ToString("dd-MMM-yyyy"), false);
                        ColIndex++;
                        CreateExcelData(xlSheet, Rowindex, ColIndex, Convert.ToString(od.ENQ_REMARKS), false);
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

  
        public List<Enquiry> GetEnquirydata()
        {
            int langid = 1;
            int Enqtype = 0;
            int prodtype = 0;

            if (HttpContext.Session.GetString("Dlangid") != "")
            {
                langid = Convert.ToInt32(HttpContext.Session.GetString("Dlangid"));
            }

            if (HttpContext.Session.GetString("Enqtype") != "")
            {
                Enqtype = Convert.ToInt32(HttpContext.Session.GetString("Enqtype"));
            }

            if (HttpContext.Session.GetString("prodtype") != "")
            {
                prodtype = Convert.ToInt32(HttpContext.Session.GetString("prodtype"));
            }

            if (HttpContext.Session.GetString("validity") != "")
            {
                var Dates = HttpContext.Session.GetString("validity").Split('-');
                DateTime.TryParseExact(Dates[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate);
                DateTime.TryParseExact(Dates[1].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate);
            }
            else
            {
                fromDate = DateTime.Now.AddMonths(-3);
                toDate = DateTime.Now;

            }

            List<Enquiry> result = new List<Enquiry>();
            try
            {

                result = _Enquiry.GetEnquirydatabySearch(langid, fromDate, toDate, Enqtype, prodtype).ToList();
                return result;
            }
            catch (Exception ex)
            {

                return result;
            }
        }


    }
}