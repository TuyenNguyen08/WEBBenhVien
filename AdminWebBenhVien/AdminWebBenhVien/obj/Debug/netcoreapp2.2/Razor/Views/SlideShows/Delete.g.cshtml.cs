#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b14fb28dc85da5c691c85d1a61a58b5b6f0fa46e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SlideShows_Delete), @"mvc.1.0.view", @"/Views/SlideShows/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SlideShows/Delete.cshtml", typeof(AspNetCore.Views_SlideShows_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b14fb28dc85da5c691c85d1a61a58b5b6f0fa46e", @"/Views/SlideShows/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00b3f6a877d1c1a7c47539d8be0adabbf5e0ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_SlideShows_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminWebBenhVien.EfModels.SlideShow>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 427, true);
            WriteLiteral(@"
<div id=""wrapper"">
    <div id=""page-wrapper"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""page-header"">Bạn có chắc muốn xóa?<span style=""color:orange""></span></h1>
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-lg-12"">
                <dl class=""dl-horizontal"">
                    <dt>
                        ");
            EndContext();
            BeginContext(528, 42, false);
#line 19 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(570, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(650, 38, false);
#line 22 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(688, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(768, 43, false);
#line 25 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(811, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(891, 39, false);
#line 28 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(930, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1010, 39, false);
#line 31 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Stt));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1129, 35, false);
#line 34 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Stt));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1244, 44, false);
#line 37 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsNewtab));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1368, 40, false);
#line 40 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IsNewtab));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1488, 45, false);
#line 43 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.LinkEvent));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1613, 41, false);
#line 46 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.LinkEvent));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1734, 42, false);
#line 49 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsLink));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1856, 38, false);
#line 52 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IsLink));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1974, 55, false);
#line 55 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkNgonNguNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2109, 54, false);
#line 58 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkNgonNguNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 70, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            EndContext();
            BeginContext(2233, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b14fb28dc85da5c691c85d1a61a58b5b6f0fa46e11998", async() => {
                BeginContext(2259, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2281, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b14fb28dc85da5c691c85d1a61a58b5b6f0fa46e12403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 63 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\SlideShows\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2317, 107, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                    ");
                EndContext();
                BeginContext(2424, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b14fb28dc85da5c691c85d1a61a58b5b6f0fa46e14358", async() => {
                    BeginContext(2446, 12, true);
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
                BeginContext(2462, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2487, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
