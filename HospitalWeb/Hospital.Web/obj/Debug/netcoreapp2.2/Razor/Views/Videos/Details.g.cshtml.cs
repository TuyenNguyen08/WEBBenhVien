#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8183afdc214277572da08aec0d8144969370d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Details), @"mvc.1.0.view", @"/Views/Videos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Videos/Details.cshtml", typeof(AspNetCore.Views_Videos_Details))]
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
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
using Hospital.Web.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8183afdc214277572da08aec0d8144969370d0", @"/Views/Videos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eea10d43a8cda2d592e6e7b5a8ffeea504dcab6", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Web.EfModels.Video>
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
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
  
    ViewBag.Title = "Chi tiết video";

#line default
#line hidden
            BeginContext(115, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(189, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(197, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a8183afdc214277572da08aec0d8144969370d05843", async() => {
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
                BeginContext(245, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(251, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a8183afdc214277572da08aec0d8144969370d07175", async() => {
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
                BeginContext(325, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(331, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a8183afdc214277572da08aec0d8144969370d08507", async() => {
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
                BeginContext(388, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(395, 153, true);
            WriteLiteral("\r\n<div class=\"breadvroumb_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row text-center\">\r\n            <div class=\"col\">\r\n                <h1>");
            EndContext();
            BeginContext(549, 12, false);
#line 24 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
               Write(Model.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(561, 328, true);
            WriteLiteral(@"</h1>               
            </div>
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
            BeginContext(890, 12, false);
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
                       Write(Model.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(902, 91, true);
            WriteLiteral("</h4>\r\n                        <div class=\"blog_meta\">\r\n                            <h3><b>");
            EndContext();
            BeginContext(994, 45, false);
#line 38 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
                              Write(Model.NgayTao.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 18, true);
            WriteLiteral(" | Ngày cập nhật: ");
            EndContext();
            BeginContext(1058, 13, false);
#line 38 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
                                                                                              Write(Model.NgaySua);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 13, true);
            WriteLiteral(" | Lượt xem: ");
            EndContext();
            BeginContext(1085, 13, false);
#line 38 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
                                                                                                                         Write(Model.LuotXem);

#line default
#line hidden
            EndContext();
            BeginContext(1098, 155, true);
            WriteLiteral("</b></h3>\r\n                            \r\n                        </div>\r\n                        \r\n                        <iframe width=\"500\" height=\"350\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1253, "\"", 1308, 2);
            WriteAttributeValue("", 1259, "https://www.youtube.com/embed/", 1259, 30, true);
#line 42 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Videos\Details.cshtml"
WriteAttributeValue("", 1289, Model.DuongDanFile, 1289, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1309, 308, true);
            WriteLiteral(@" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                                          
                    </div>
                    
                </div>
            </div>

        </div>
    </div>
</div>




");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1635, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1642, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Web.EfModels.Video> Html { get; private set; }
    }
}
#pragma warning restore 1591