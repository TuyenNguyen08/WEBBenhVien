#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21bd3e3c8db7c0eb5fa39c23859147f3cf11fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoatDongs_Details), @"mvc.1.0.view", @"/Views/HoatDongs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoatDongs/Details.cshtml", typeof(AspNetCore.Views_HoatDongs_Details))]
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
#line 1 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\_ViewImports.cshtml"
using Hospital.Web;

#line default
#line hidden
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 4 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
using Hospital.Web.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21bd3e3c8db7c0eb5fa39c23859147f3cf11fd3", @"/Views/HoatDongs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eea10d43a8cda2d592e6e7b5a8ffeea504dcab6", @"/Views/_ViewImports.cshtml")]
    public class Views_HoatDongs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Web.EfModels.HoatDong>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/about.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/material-design-iconic-font.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Hoạt động chi tiết";

#line default
#line hidden
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(185, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(193, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f21bd3e3c8db7c0eb5fa39c23859147f3cf11fd35632", async() => {
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
                EndContext();
                BeginContext(241, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(247, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f21bd3e3c8db7c0eb5fa39c23859147f3cf11fd36964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(321, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(327, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f21bd3e3c8db7c0eb5fa39c23859147f3cf11fd38296", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(384, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(391, 161, true);
            WriteLiteral("<div class=\"breadvroumb_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row text-center\">\r\n            <div class=\"col tieude_DT\">\r\n                <h1>");
            EndContext();
            BeginContext(553, 12, false);
#line 19 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
               Write(Model.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(565, 121, true);
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\" about_page\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 27 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.GioiThieu))
        {

#line default
#line hidden
            BeginContext(756, 173, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"about_content\">\r\n                        <p style=\"font-weight:bold\">");
            EndContext();
            BeginContext(930, 25, false);
#line 32 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
                                               Write(Html.Raw(Model.GioiThieu));

#line default
#line hidden
            EndContext();
            BeginContext(955, 78, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1044, 29, true);
            WriteLiteral("\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1074, 23, false);
#line 39 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
       Write(Html.Raw(Model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 310, true);
            WriteLiteral(@"
            <br />
        </div>

    </div>
</div>

<div class=""blog_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""blog_detaisl_area"">
                    <div class=""blog_full_content"">
                        <h4>");
            EndContext();
            BeginContext(1408, 12, false);
#line 52 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
                       Write(Model.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 96, true);
            WriteLiteral("</h4>\r\n                        <div class=\"blog_meta\">\r\n                            <a href=\"#\">");
            EndContext();
            BeginContext(1517, 44, false);
#line 54 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
                                   Write(Model.NgayTao?.ToString("dd/MM/yy hh:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 119, true);
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"blog_quote\">\r\n                            <p>");
            EndContext();
            BeginContext(1681, 15, false);
#line 57 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
                          Write(Model.GioiThieu);

#line default
#line hidden
            EndContext();
            BeginContext(1696, 95, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(1792, 23, false);
#line 60 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\HoatDongs\Details.cshtml"
                       Write(Html.Raw(Model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 187, true);
            WriteLiteral(" <br>\r\n                            <br>\r\n                            <br>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2020, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Web.EfModels.HoatDong> Html { get; private set; }
    }
}
#pragma warning restore 1591
