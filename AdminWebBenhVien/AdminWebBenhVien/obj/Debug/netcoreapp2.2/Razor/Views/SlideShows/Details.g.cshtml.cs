#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87dbedd8b67692a87fe71c4e1f9ca2f281742701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SlideShows_Details), @"mvc.1.0.view", @"/Views/SlideShows/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SlideShows/Details.cshtml", typeof(AspNetCore.Views_SlideShows_Details))]
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
#line 1 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\_ViewImports.cshtml"
using AdminWebBenhVien;

#line default
#line hidden
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dbedd8b67692a87fe71c4e1f9ca2f281742701", @"/Views/SlideShows/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00b3f6a877d1c1a7c47539d8be0adabbf5e0ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_SlideShows_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminWebBenhVien.EfModels.SlideShow>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(73, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(102, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87dbedd8b67692a87fe71c4e1f9ca2f2817427014496", async() => {
                BeginContext(108, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 1443, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87dbedd8b67692a87fe71c4e1f9ca2f2817427015774", async() => {
                BeginContext(212, 105, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>SlideShow</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(318, 42, false);
#line 21 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
                EndContext();
                BeginContext(360, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(404, 38, false);
#line 24 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
                EndContext();
                BeginContext(442, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(486, 43, false);
#line 27 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
                EndContext();
                BeginContext(529, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(573, 39, false);
#line 30 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
                EndContext();
                BeginContext(612, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(656, 39, false);
#line 33 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stt));

#line default
#line hidden
                EndContext();
                BeginContext(695, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(739, 35, false);
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stt));

#line default
#line hidden
                EndContext();
                BeginContext(774, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(818, 44, false);
#line 39 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsNewtab));

#line default
#line hidden
                EndContext();
                BeginContext(862, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(906, 40, false);
#line 42 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsNewtab));

#line default
#line hidden
                EndContext();
                BeginContext(946, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(990, 45, false);
#line 45 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LinkEvent));

#line default
#line hidden
                EndContext();
                BeginContext(1035, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1079, 41, false);
#line 48 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.LinkEvent));

#line default
#line hidden
                EndContext();
                BeginContext(1120, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1164, 42, false);
#line 51 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsLink));

#line default
#line hidden
                EndContext();
                BeginContext(1206, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1250, 38, false);
#line 54 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsLink));

#line default
#line hidden
                EndContext();
                BeginContext(1288, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1332, 55, false);
#line 57 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkNgonNguNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1387, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1431, 54, false);
#line 60 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkNgonNguNavigation.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1485, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1532, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87dbedd8b67692a87fe71c4e1f9ca2f28174270112545", async() => {
                    BeginContext(1578, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 65 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1586, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(1594, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87dbedd8b67692a87fe71c4e1f9ca2f28174270115012", async() => {
                    BeginContext(1616, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1632, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1649, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminWebBenhVien.EfModels.SlideShow> Html { get; private set; }
    }
}
#pragma warning restore 1591