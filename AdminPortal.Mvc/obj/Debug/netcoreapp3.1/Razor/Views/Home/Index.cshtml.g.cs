#pragma checksum "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac8701d1380dfd323e0d6748eb40068fb4db2bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac8701d1380dfd323e0d6748eb40068fb4db2bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c825b3414be803a2303b491dc571f58f3b4227e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Dashboard_Chart_Data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "F:\Repos\2020-2021\Mahindra\2511_DigisenseMicroServices\AdminPortal.Mvc\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ol class=""breadcrumb page-breadcrumb"">
    <li class=""breadcrumb-item""><a href=""../CustomerApplication/Home""><i class=""fal fa-home mr-1 fs-md""></i>Home</a></li>
    <li class=""breadcrumb-item""><i class=""fal fa-chart-area mr-1 fs-md""></i>Dashboard</li>
    <li class=""position-absolute pos-top pos-right d-none d-sm-block""><span class=""js-get-date""></span></li>
</ol>
<div class=""subheader"">
    <h1 class=""subheader-title mb-4"">
        <i class=""subheader-icon fal fa-chart-area""></i>
        Dashboard
    </h1>
    <div class=""subheader-block d-lg-flex align-items-center"">
        <div class=""d-flex mr-4"">
            <div class=""mr-2"">
                <span class=""peity-donut"" data-peity=""{ &quot;fill&quot;: [&quot;#967bbd&quot;, &quot;#ccbfdf&quot;],  &quot;innerRadius&quot;: 14, &quot;radius&quot;: 20 }"">7/10</span>
            </div>
            <div>
                <label class=""fs-sm mb-0 mt-2 mt-md-0"">Active Enquiries</label>
                <h4 class=""font-weight-bold mb-0"">70.60%</h");
            WriteLiteral(@"4>
            </div>
        </div>
        <div class=""d-flex mr-0"">
            <div class=""mr-2"">
                <span class=""peity-donut"" data-peity=""{ &quot;fill&quot;: [&quot;#2196F3&quot;, &quot;#9acffa&quot;],  &quot;innerRadius&quot;: 14, &quot;radius&quot;: 20 }"">3/10</span>
            </div>
            <div>
                <label class=""fs-sm mb-0 mt-2 mt-md-0"">Active OLD Tractor Eval.</label>
                <h4 class=""font-weight-bold mb-0"">14,134</h4>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-6 col-xl-3"">
        <div class=""p-3 bg-primary-300 rounded overflow-hidden position-relative text-white mb-g"">
            <div");
            BeginWriteAttribute("class", " class=\"", 1807, "\"", 1815, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3 class=""display-4 d-block l-h-n m-0 fw-500"">
                    21.5k
                    <small class=""m-0 l-h-n"">Total Enquiries</small>
                </h3>
            </div>
            <i class=""fal fa-comment-alt position-absolute pos-right pos-bottom opacity-15 mb-n1 mr-n1"" style=""font-size:6rem""></i>
        </div>
    </div>
    <div class=""col-sm-6 col-xl-3"">
        <div class=""p-3 bg-warning-400 rounded overflow-hidden position-relative text-white mb-g"">
            <div");
            BeginWriteAttribute("class", " class=\"", 2338, "\"", 2346, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3 class=""display-4 d-block l-h-n m-0 fw-500"">
                    19,201
                    <small class=""m-0 l-h-n"">Active Banners</small>
                </h3>
            </div>
            <i class=""fal fa-file-alt position-absolute pos-right pos-bottom opacity-15  mb-n1 mr-n4"" style=""font-size: 6rem;""></i>
        </div>
    </div>
    <div class=""col-sm-6 col-xl-3"">
        <div class=""p-3 bg-success-200 rounded overflow-hidden position-relative text-white mb-g"">
            <div");
            BeginWriteAttribute("class", " class=\"", 2869, "\"", 2877, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3 class=""display-4 d-block l-h-n m-0 fw-500"">
                    7,897
                    <small class=""m-0 l-h-n"">Total OLD Tractor Evaluation Request</small>
                </h3>
            </div>
            <i class=""fal fa-tractor position-absolute pos-right pos-bottom opacity-15 mb-n5 mr-n6"" style=""font-size: 8rem;""></i>
        </div>
    </div>
    <div class=""col-sm-6 col-xl-3"">
        <div class=""p-3 bg-info-200 rounded overflow-hidden position-relative text-white mb-g"">
            <div");
            BeginWriteAttribute("class", " class=\"", 3416, "\"", 3424, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h3 class=""display-4 d-block l-h-n m-0 fw-500"">
                    +40%
                    <small class=""m-0 l-h-n"">Sample</small>
                </h3>
            </div>
            <i class=""fal fa-globe position-absolute pos-right pos-bottom opacity-15 mb-n1 mr-n4"" style=""font-size: 6rem;""></i>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""panel-1"" class=""panel"">
            <div class=""panel-hdr"">
                <h2>
                    Enquiries
                </h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content bg-subtlelight-fade"">
                    <div id=""js-checkbox-toggles"" class=""d-flex mb-3"">
                        <div class=""custom-control custom-switch mr-2"">
                            <input type=""checkbox"" class=""custom-control-input"" name=""gra-0"" id=""gra-0"" checked=""checked"">
                            <label class=""custom-control");
            WriteLiteral(@"-label"" for=""gra-0"">User Enquiry</label>
                        </div>
                        <div class=""custom-control custom-switch mr-2"">
                            <input type=""checkbox"" class=""custom-control-input"" name=""gra-1"" id=""gra-1"" checked=""checked"">
                            <label class=""custom-control-label"" for=""gra-1"">Referral Enquiry</label>
                        </div>
");
            WriteLiteral(@"                    </div>
                    <div id=""flot-toggles"" class=""w-100 mt-4"" style=""height: 300px""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div id=""panel-2"" class=""panel panel-locked"" data-panel-sortable data-panel-collapsed data-panel-close>
            <div class=""panel-hdr"">
                <h2>
                    Active Banners
                </h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-content poisition-relative"">
                    <div class=""p-1 position-absolute pos-right pos-top mt-3 mr-3 z-index-cloud d-flex align-items-center justify-content-center"">
                        <div class=""border-faded border-top-0 border-left-0 border-bottom-0 py-2 pr-4 mr-3 hidden-sm-down"">
                            <div class=""text-right fw-500 l-h-n d-flex flex-column"">
                                <div class=""h3 m-0 d-flex align-items-center justi");
            WriteLiteral(@"fy-content-end"">
                                    <div class='icon-stack mr-2'>
                                        <i class=""base base-7 icon-stack-3x opacity-100 color-success-600""></i>
                                        <i class=""base base-7 icon-stack-2x opacity-100 color-success-500""></i>
                                        <i class=""fal fa-arrow-up icon-stack-1x opacity-100 color-white""></i>
                                    </div>
                                    1,784
                                </div>
                                <span class=""m-0 fs-xs text-muted"">Highest count of the month</span>
                            </div>
                        </div>
                        <div class=""js-easy-pie-chart color-info-400 position-relative d-inline-flex align-items-center justify-content-center"" data-percent=""35"" data-piesize=""95"" data-linewidth=""10"" data-scalelength=""5"">
                            <div class=""js-easy-pie-chart color-success-400 positi");
            WriteLiteral(@"on-relative position-absolute pos-left pos-right pos-top pos-bottom d-flex align-items-center justify-content-center"" data-percent=""65"" data-piesize=""60"" data-linewidth=""5"" data-scalelength=""1"" data-scalecolor=""#fff"">
                                <div class=""position-absolute pos-top pos-left pos-right pos-bottom d-flex align-items-center justify-content-center fw-500 fs-xl text-dark"">78%</div>
                            </div>
                        </div>
                    </div>
                    <div id=""flot-area"" style=""width:100%; height:300px;""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div id=""panel-3"" class=""panel panel-locked"" data-panel-sortable data-panel-collapsed data-panel-close>
            <div class=""panel-hdr"">
                <h2>
                    OLD Tractor Evaluation
                </h2>
            </div>
            <div class=""panel-container show"">
                <div class=""panel-co");
            WriteLiteral(@"ntent poisition-relative"">
                    <div class=""pb-5 pt-3"">
                        <div class=""row"">
                            <div class=""col-6 col-xl-3 d-sm-flex align-items-center"">
                                <div class=""p-2 mr-3 bg-info-200 rounded"">
                                    <span class=""peity-bar"" data-peity=""{&quot;fill&quot;: [&quot;#fff&quot;], &quot;width&quot;: 27, &quot;height&quot;: 27 }"">3,4,5,8,2</span>
                                </div>
                                <div>
                                    <label class=""fs-sm mb-0"">Request Rate</label>
                                    <h4 class=""font-weight-bold mb-0"">37.56%</h4>
                                </div>
                            </div>
                            <div class=""col-6 col-xl-3 d-sm-flex align-items-center"">
                                <div class=""p-2 mr-3 bg-info-300 rounded"">
                                    <span class=""peity-bar"" data-peity=""{&quot;fil");
            WriteLiteral(@"l&quot;: [&quot;#fff&quot;], &quot;width&quot;: 27, &quot;height&quot;: 27 }"">5,3,1,7,9</span>
                                </div>
                                <div>
                                    <label class=""fs-sm mb-0"">Highest count</label>
                                    <h4 class=""font-weight-bold mb-0"">759</h4>
                                </div>
                            </div>
                            <div class=""col-6 col-xl-3 d-sm-flex align-items-center"">
                                <div class=""p-2 mr-3 bg-success-300 rounded"">
                                    <span class=""peity-bar"" data-peity=""{&quot;fill&quot;: [&quot;#fff&quot;], &quot;width&quot;: 27, &quot;height&quot;: 27 }"">3,4,3,5,5</span>
                                </div>
                                <div>
                                    <label class=""fs-sm mb-0"">New Requests</label>
                                    <h4 class=""font-weight-bold mb-0"">12.17%</h4>
                  ");
            WriteLiteral("              </div>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div id=\"flotVisit\" style=\"width:100%; height:208px;\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac8701d1380dfd323e0d6748eb40068fb4db2bc15049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(\'#dashboard\').addClass(\'active\');\r\n</script>");
        }
        #pragma warning restore 1998
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