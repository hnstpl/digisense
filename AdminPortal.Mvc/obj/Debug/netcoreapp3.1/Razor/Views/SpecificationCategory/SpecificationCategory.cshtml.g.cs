#pragma checksum "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a423a817c25face94d44673de9b7c1d702853b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpecificationCategory_SpecificationCategory), @"mvc.1.0.view", @"/Views/SpecificationCategory/SpecificationCategory.cshtml")]
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
#line 1 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
using AdminPortal.Mvc.Models.GeoLocation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
using AdminPortal.Mvc.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a423a817c25face94d44673de9b7c1d702853b", @"/Views/SpecificationCategory/SpecificationCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c825b3414be803a2303b491dc571f58f3b4227e", @"/Views/_ViewImports.cshtml")]
    public class Views_SpecificationCategory_SpecificationCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
  
    ViewBag.Title = "SpecificationCategory";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
  

    List<AdminPortal.Mvc.Models.SpecificationCategory.SpecificationCategory> SModeldata = ViewBag.SpecCatlist == null ? null : ViewBag.SpecCatlist;
    List<AdminPortal.Mvc.Models.Global.Language> LanguageModeldata = ViewBag.LangListItem == null ? null : ViewBag.LangListItem;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<ol class=""breadcrumb page-breadcrumb"">
    <li class=""breadcrumb-item""><a href=""../CustomerApplication/Home""><i class=""fal fa-home mr-1 fs-md""></i>Home</a></li>
    <li class=""breadcrumb-item""><i class=""fal fa-desktop-alt mr-1 fs-sm""></i>Master</li>
    <li class=""breadcrumb-item""><i class=""subheader-icon fal fa-tractor""></i>Specification Category</li>
    <li class=""position-absolute pos-top pos-right d-none d-sm-block""><span class=""js-get-date""></span></li>
</ol>


");
#nullable restore
#line 25 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
 using (Html.BeginForm("SpecificationCategory", "SpecificationCategory", FormMethod.Post, new { @id = "frmspec" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""subheader"">
        <div class=""card col-12"">
            <div class=""row mt-2"">
                <div class=""col-sm-12 col-md-12 col-lg-9 col-xl-9"">
                    <h1 class=""subheader-title mt-2 mb-2 pt-1"">
                        <i class=""subheader-icon fal fa-tractor""></i>
                        Specification Category
                    </h1>
                </div>
                <div class=""form-group col-sm-12 col-md-12 col-lg-3 col-xl-2 mt-2 mb-2"">
                    <select id=""cmbimglang"" name=""cmbimglang"" class=""custom-select"">
");
#nullable restore
#line 38 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                         foreach (AdminPortal.Mvc.Models.Global.Language item in LanguageModeldata)
                        {
                            if (item.Languageid == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a423a817c25face94d44673de9b7c1d702853b6794", async() => {
                WriteLiteral(" ");
#nullable restore
#line 42 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                                    Write(item.Languagename);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                  WriteLiteral(item.Languageid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a423a817c25face94d44673de9b7c1d702853b9450", async() => {
                WriteLiteral(" ");
#nullable restore
#line 46 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                           Write(item.Languagename);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                  WriteLiteral(item.Languageid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group col-sm-12 col-md-12 col-lg-3 col-xl-1 mt-2 mb-2"">
                    <button type=""submit"" value=""Submit"" class=""btn btn-primary"" id=""SPSearch"" name=""SPSearch"">Apply</button>
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
                        <div class=""panel-hdr"">
                            <h2>Specification Category</h2>
                  ");
            WriteLiteral("          <div class=\"panel-toolbar float-right mr-2\">\r\n\r\n                            </div>\r\n");
            WriteLiteral(@"                        </div>
                        <div class=""panel-container show"">
                            <div class=""panel-content"">
                                <div class=""tab-content p-3"">
                                    <div class=""tab-pane fade show active"" role=""tabpanel"">
                                        <table id=""dt-spec"" class=""table table-bordered table-hover table-striped w-100"" role=""grid"" aria-describedby=""dt-basic_info"">
                                            <thead>
                                                <tr>
                                                    <td class=""fw-500 text-center"">S.No</td>
                                                    <td class=""fw-500 text-center"">Code</td>
                                                    <td class=""fw-500 text-center"">Category</td>
                                                    <td class=""fw-500 text-center"">Status</td>

                                                </tr>
     ");
            WriteLiteral("                                       </thead>\r\n                                            <tbody>\r\n\r\n");
#nullable restore
#line 95 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                  
                                                    int tpno = 0;
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                 foreach (AdminPortal.Mvc.Models.SpecificationCategory.SpecificationCategory item in SModeldata)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">  ");
#nullable restore
#line 101 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                                                     tpno++; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 101 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                                                          Write(tpno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">\r\n                                                            ");
#nullable restore
#line 103 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                       Write(item.MSpecCategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 106 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                       Write(item.MSpecCategoyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td align=\"center\">\r\n");
#nullable restore
#line 109 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                             if (item.MACTIVEFLAG_C == "Active")
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-success badge-pill\">Active</span>");
#nullable restore
#line 110 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                                                                                       }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger badge-pill\">Inactive</span>");
#nullable restore
#line 112 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 115 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
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
            WriteLiteral("    <script>\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\"#cmbimglang\").val(");
#nullable restore
#line 135 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
                        Write(HttpContextAccessor.HttpContext.Session.GetString("Dlangid"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@");

        //$(""#cmbimglang"").on(""change"", function () {
        //    $(""#frmspec"").first().submit();

        //});

         $('#dt-spec').dataTable(
            {
                responsive: true
            });


        $('#Specification_Category').parent().parent().addClass('active open');
        $('#Specification_Category').addClass('active');


        //For Filters
        $('#cmbimglang').multiselect({
            buttonWidth: '100%',
            enableClickableOptGroups: true,
            includeSelectAllOption: true,
            float: 'left',
            //enableFiltering: true
            buttonText: function (options, select) {
                if (options.length === 0) {
                    return 'No Languages selected';
                }
                else if (options.length > 3) {
                    return 'More than 3 Languages selected!';
                }
                else {
                    var labels = [];
                    options.each(fun");
            WriteLiteral(@"ction () {
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
            $(this).addClass('custom-select');
        });

        $('#dt-spec_paginate').on('click.page-link', function () {

         $('#dt-spec').DataTable()
        .columns.adjust()
        .responsive.recalc();
        });

    });
    </script>
");
#nullable restore
#line 194 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\SpecificationCategory\SpecificationCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
