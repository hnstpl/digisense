#pragma checksum "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aab3124aed85d3614e38253d4ac08743d2f9c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Language_Language), @"mvc.1.0.view", @"/Views/Language/Language.cshtml")]
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
#line 1 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
using AdminPortal.Mvc.Models.GeoLocation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
using AdminPortal.Mvc.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aab3124aed85d3614e38253d4ac08743d2f9c12", @"/Views/Language/Language.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c825b3414be803a2303b491dc571f58f3b4227e", @"/Views/_ViewImports.cshtml")]
    public class Views_Language_Language : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
  
    ViewBag.Title = "Language";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
  

    List<AdminPortal.Mvc.Models.Language.LanguageInfo> LModeldata = ViewBag.Languagelist == null ? null : ViewBag.Languagelist;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ol class=""breadcrumb page-breadcrumb"">
    <li class=""breadcrumb-item""><a href=""../CustomerApplication/Home""><i class=""fal fa-home mr-1 fs-md""></i>Home</a></li>
    <li class=""breadcrumb-item""><i class=""fal fa-desktop-alt mr-1 fs-sm""></i>Master</li>
    <li class=""breadcrumb-item""><i class=""subheader-icon fal fa-language""></i>Language</li>
    <li class=""position-absolute pos-top pos-right d-none d-sm-block""><span class=""js-get-date""></span></li>
</ol>


");
#nullable restore
#line 25 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
 using (Html.BeginForm("Language", "Language", FormMethod.Post, new { @id = "frmlang" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""subheader"">
        <div class=""card col-12"">
            <div class=""row mt-2"">
                <div class=""col-sm-12 col-md-12 col-lg-9 col-xl-10"">
                    <h1 class=""subheader-title mt-2 mb-2 pt-1"">
                        <i class=""subheader-icon fal fa-language""></i>
                        Language
                    </h1>
                </div>

            </div>
            <div>
                <div class=""col-xl-12 row"">

                    <div class=""alert alert-info"" position:absolute; id=""sucessmessage"" style=""display:none;width:500px;margin:0 auto;"">
                    </div>

                    <div class=""alert alert-danger"" position:absolute; id=""errormessage"" style=""display:none;width:500px;"">

                    </div>

                </div>
            </div>
            <div id=""grid"" class=""row mt-2"">
                <div class=""col-12"">
                    <div class=""panel bg-subtlelight-fade"">
                        <div c");
            WriteLiteral("lass=\"panel-hdr\">\r\n                            <h2>Language</h2>\r\n                            <div class=\"panel-toolbar float-right mr-2\">\r\n\r\n                            </div>\r\n");
            WriteLiteral(@"                        </div>
                        <div class=""panel-container show"">
                            <div class=""panel-content"">
                                <div class=""tab-content p-3"">
                                    <div class=""tab-pane fade show active"" role=""tabpanel"">
                                        <table id=""dt-lang"" class=""table table-bordered table-hover table-striped w-100"" role=""grid"" aria-describedby=""dt-basic_info"">
                                            <thead>
                                                <tr>
                                                    <td class=""fw-500 text-center"">S.No</td>
                                                    <td class=""fw-500 text-center"">Language ID</td>
                                                    <td class=""fw-500 text-center"">Language Name</td>
                                                    <td class=""fw-500 text-center"">Translated Name</td>
                                         ");
            WriteLiteral("           <td class=\"fw-500 text-center\">Status</td>\r\n\r\n                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 78 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                  
                                                    int tpno = 0;
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                 foreach (AdminPortal.Mvc.Models.Language.LanguageInfo item in LModeldata)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">  ");
#nullable restore
#line 84 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                                                     tpno++; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 84 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                                                          Write(tpno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">\r\n                                                            ");
#nullable restore
#line 86 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                       Write(item.MLanguageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style:color=\"green\">\r\n                                                            ");
#nullable restore
#line 89 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                       Write(item.MLanguage_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style:color=\"green\">\r\n                                                            ");
#nullable restore
#line 92 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                       Write(item.MTranslate_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td align=\"center\">\r\n");
#nullable restore
#line 95 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                             if (item.MACTIVEFLAG_C == "Active")
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-success badge-pill\">Active</span>");
#nullable restore
#line 96 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                                                                                       }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger badge-pill\">Inactive</span>");
#nullable restore
#line 98 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 101 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
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
");
            WriteLiteral(@"    <script>

        $(document).ready(function () {

            $('#dt-lang').dataTable(
                {
                    responsive: true
                });


            $('#Language').parent().parent().addClass('active open');
            $('#Language').addClass('active');

        });
    </script>
");
#nullable restore
#line 131 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Language\Language.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591