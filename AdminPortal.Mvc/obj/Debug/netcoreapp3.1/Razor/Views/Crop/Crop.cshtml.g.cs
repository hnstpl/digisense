#pragma checksum "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48394a6c4bc293b782dd8690162f79793c376586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crop_Crop), @"mvc.1.0.view", @"/Views/Crop/Crop.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\_ViewImports.cshtml"
using AdminPortal.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\_ViewImports.cshtml"
using AdminPortal.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
using AdminPortal.Mvc.Models.Crop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
using AdminPortal.Mvc.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48394a6c4bc293b782dd8690162f79793c376586", @"/Views/Crop/Crop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c825b3414be803a2303b491dc571f58f3b4227e", @"/Views/_ViewImports.cshtml")]
    public class Views_Crop_Crop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminPortal.Mvc.Models.Crop.Crop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Multiple-Select-Plugin-For-Bootstrap-Bootstrap-Multiselect/bootstrap-multiselect.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Custom/CustomStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Multiple-Select-Plugin-For-Bootstrap-Bootstrap-Multiselect/bootstrap-multiselect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon_excel.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
  
    ViewBag.Title = "";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
  

    List<AdminPortal.Mvc.Models.Global.Language> LanguageModeldata = ViewBag.LangListItem == null ? null : ViewBag.LangListItem;
    List<AdminPortal.Mvc.Models.Crop.CropData> CropModeldata = ViewBag.CropList == null ? null : ViewBag.CropList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48394a6c4bc293b782dd8690162f79793c3765866520", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48394a6c4bc293b782dd8690162f79793c3765867634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48394a6c4bc293b782dd8690162f79793c3765868748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .multiselect {
        text-align: left;
    }

    .badge-pill {
        min-width: 55px;
    }
</style>
<ol class=""breadcrumb page-breadcrumb"">
    <li class=""breadcrumb-item""><a href=""../CustomerApplication/Home""><i class=""fal fa-home mr-1 fs-md""></i>Home</a></li>
    <li class=""breadcrumb-item""><i class=""fal fa-desktop-alt mr-1 fs-sm""></i>Mandi</li>
    <li class=""breadcrumb-item""><i class=""subheader-icon fal fa-carrot mr-1 fs-sm""></i>Crop</li>
    <li class=""position-absolute pos-top pos-right d-none d-sm-block""><span class=""js-get-date""></span></li>
</ol>
<style>
    .select2-selection__arrow b {
        display: none !important;
    }
</style>
");
#nullable restore
#line 43 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
 using (Html.BeginForm("Crop", "Crop", FormMethod.Post, new { @id = "form1", novalidate = "", @class = "needs-validation" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""subheader"">
        <div class=""card col-12"">
            <div class=""row mt-2"">
                <div class=""col-sm-12 col-md-12 col-lg-2 col-xl-6"">
                    <h1 class=""subheader-title mt-2 mb-2 pt-1"">
                        <i class=""subheader-icon  fal fa-carrot""></i>
                        Crop
                    </h1>
                </div>
                <div class=""form-group col-sm-12 col-md-12 col-lg-3 col-xl-1 mt-2 mb-2 text-right min-width-0"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2190, "\"", 2239, 1);
#nullable restore
#line 55 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
WriteAttributeValue("", 2197, Url.Action("DownloadCropHistory", "Crop"), 2197, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Export Mandi Data\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48394a6c4bc293b782dd8690162f79793c37658611807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"form-group col-sm-12 col-md-12 col-lg-3 col-xl-2 mt-2 mb-2\">\r\n                    ");
#nullable restore
#line 58 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
               Write(Html.DropDownListFor(x => x.Mapping.SelectedMandi, new MultiSelectList(Model.Mapping.MandiList.Items, "Mandi_ID", "Mandi_Name", Model.Mapping.MandiList), null, new { @class = "form-control mt-2 mb-2", id = "MandiList", name = "MandiList", multiple = "multiple" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-sm-12 col-md-12 col-lg-3 col-xl-2 mt-2 mb-2\">\r\n                    ");
#nullable restore
#line 61 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
               Write(Html.DropDownListFor(x => Model.searchFilters.SelectedLanguage, Model.languageModel.LanguageList, "Select Language", new { @class = "custom-select", id = "LanguageFilterList", name = "Languagelist" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""form-group col-sm-12 col-md-12 col-lg-3 col-xl-1 mt-2 mb-2"">
                    <button type=""submit"" value=""Submit"" class=""btn btn-primary"" id=""EnqSearch"" name=""EnqSearch"">Apply</button>
                </div>
            </div>
            <div id=""grid"" class=""row mt-2"">
                <div class=""col-12"">
                    <div class=""panel bg-subtlelight-fade mb-5"">
                        <div class=""panel-hdr"">
                            <h2>Crop</h2>
                            <div class=""panel-toolbar float-right mr-2"">
");
            WriteLiteral(@"                            </div>
                            <div class=""panel-toolbar float-right pr-2"">
                            </div>
                        </div>
                        <div class=""panel-container show"">
                            <div class=""panel-content"">
                                <div class=""tab-content p-3"">
                                    <div class=""tab-pane fade show active"" role=""tabpanel"">
                                        <table id=""dt-crop"" class=""table table-bordered table-hover table-striped w-100"" role=""grid"" aria-describedby=""dt-basic_info"">
                                            <thead>
                                                <tr>
                                                    <td class=""fw-500 text-center"">Sl. No</td>
");
            WriteLiteral(@"                                                    <td class=""fw-500 text-center"">Crop</td>
                                                    <td class=""fw-500 text-center"">Mandi</td>
                                                    <td class=""fw-500 text-center"">Category</td>
                                                    <td class=""fw-500 text-center"">Arrival Date</td>
                                                    <td class=""fw-500 text-center"">Last Modified Date</td>
                                                    <td class=""fw-500 text-center"">Min. Price</td>
                                                    <td class=""fw-500 text-center"">Max. Price</td>
                                                    <td class=""fw-500 text-center"">Modal. Price</td>
                                                    <td class=""fw-500 text-center"">Status</td>
                                                </tr>
                                            </thead>
                    ");
            WriteLiteral("                        <tbody>\r\n");
#nullable restore
#line 100 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                  
                                                    if (CropModeldata != null)
                                                    {
                                                        int slno = 0;
                                                        foreach (dynamic itm in CropModeldata)
                                                        {
                                                            slno++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td name=\"slno\" class=\"text-center\">");
#nullable restore
#line 108 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                               Write(slno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                                <td>");
#nullable restore
#line 110 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                               Write(itm.CropName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 111 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                               Write(itm.MandiName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 112 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                               Write(itm.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 113 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.ArrivalDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 114 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.MODIFIEDDT_D.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 115 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.MinPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 116 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.MaxPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 117 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.ModalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td class=\"text-center\">");
#nullable restore
#line 118 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                                                   Write(itm.ACTIVEFLAG_C);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 120 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {

            var MandiListLangArray = [];
            var MandiListIDArray = ");
#nullable restore
#line 138 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                              Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(@ViewData["MandiList"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ;\r\n            //Json.Encode(");
#nullable restore
#line 139 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
                     Write(ViewData["MandiList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")


        $.each(MandiListIDArray, function () {
            MandiListLangArray.push(this);
            });
            $(""#MandiList"").val(MandiListLangArray);


            var start = new Date();
            var end = new Date();

            $('#Validity, #datepicker-modal-2').daterangepicker(
                {
                    startDate: start,
                    endDate: end,
                }, function (start, end, label) {
                });

             $('#cmblang').multiselect({
                buttonWidth: '100%',
                enableClickableOptGroups: true,
                includeSelectAllOption: true,
                float: 'left',
                buttonText: function (options, select) {
                    if (options.length === 0) {
                        return 'No Languages selected';
                    }
                    else if (options.length > 3) {
                        return 'More than 3 Languages selected!';
                    }
      ");
            WriteLiteral(@"              else {
                        var labels = [];
                        options.each(function () {
                            if ($(this).attr('label') !== undefined) {
                                labels.push($(this).attr('label'));
                            }
                            else {
                                labels.push($(this).html().replace(""&gt;"", "">"").replace(""&lt;"", ""<"").replace(""&amp;"", ""&""));
                            }
                        });
                        return labels.join(', ') + '';
                    }
                }
            });
            //Mandi List
            $('#MandiList').multiselect({
                buttonWidth: '100%',
                enableClickableOptGroups: true,
                includeSelectAllOption: true,
                //enableFiltering: true
                buttonText: function (options, select) {
                    if (options.length === 0) {
                        return 'No Mandi selecte");
            WriteLiteral(@"d';
                    }
                    else if (options.length > 3) {
                        return 'More than 3 Mandi selected!';
                    }
                    else {
                        var labels = [];
                        options.each(function () {
                            if ($(this).attr('label') !== undefined) {
                                labels.push($(this).attr('label'));
                            }
                            else {
                                labels.push($(this).html().replace(""&gt;"", "">"").replace(""&lt;"", ""<"").replace(""&amp;"", ""&""));
                            }
                        });
                        return labels.join(', ') + '';
                    }
                }
            });

            $('#LanguageFilterList').multiselect({
                buttonWidth: '100%',
                enableClickableOptGroups: true,
                includeSelectAllOption: true,
                float: 'left',
       ");
            WriteLiteral(@"         //enableFiltering: true
                buttonText: function (options, select) {
                    if (options.length === 0) {
                        return 'No Languages selected';
                    }
                    else if (options.length > 3) {
                        return 'More than 3 Languages selected!';
                    }
                    else {
                        var labels = [];
                        options.each(function () {
                            if ($(this).attr('label') !== undefined) {
                                labels.push($(this).attr('label'));
                            }
                            else {
                                labels.push($(this).html());
                            }
                        });
                        return labels.join(', ') + '';
                    }
                }
            });


              $('button.multiselect').each(function () {
            $(this).addClass('cu");
            WriteLiteral(@"stom-select');
        });

            $('#Mandi_Crops').parent().parent().addClass('active open');
            $('#Mandi_Crops').addClass('active');
            var AngleElm = $('.open .fa-angle-down');
            AngleElm.removeClass('fa-angle-down');
            AngleElm.addClass('fa-angle-up');

             $('#dt-crop').DataTable()
            .columns.adjust()
            .responsive.recalc();
             //$('#dt-crop').dataTable(
             //       {
             //           responsive: true
             //       });
             //   $('.js-thead-colors a').on('click', function () {
             //       var theadColor = $(this).attr(""data-bg"");
             //       console.log(theadColor);
             //       $('#dt-mandi thead').removeClassPrefix('bg-').addClass(theadColor);
             //   });

             //   $('.js-tbody-colors a').on('click', function () {
             //       var theadColor = $(this).attr(""data-bg"");
             //       console.log(the");
            WriteLiteral("adColor);\r\n             //       $(\'#dt-crop\').removeClassPrefix(\'bg-\').addClass(theadColor);\r\n             //   });\r\n\r\n\r\n        })\r\n\r\n    </script>\r\n");
#nullable restore
#line 274 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Crop\Crop.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminPortal.Mvc.Models.Crop.Crop> Html { get; private set; }
    }
}
#pragma warning restore 1591