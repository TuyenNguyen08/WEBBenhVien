#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acde08b24ecefd99eb19b3643069865f43dd20d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Delete), @"mvc.1.0.view", @"/Views/Events/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Delete.cshtml", typeof(AspNetCore.Views_Events_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acde08b24ecefd99eb19b3643069865f43dd20d3", @"/Views/Events/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00b3f6a877d1c1a7c47539d8be0adabbf5e0ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminWebBenhVien.EfModels.Event>
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
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 427, true);
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
            BeginContext(522, 42, false);
#line 18 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(564, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(644, 38, false);
#line 21 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(682, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(762, 45, false);
#line 24 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.GioiThieu));

#line default
#line hidden
            EndContext();
            BeginContext(807, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(887, 41, false);
#line 27 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.GioiThieu));

#line default
#line hidden
            EndContext();
            BeginContext(928, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1008, 43, false);
#line 30 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1131, 39, false);
#line 33 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1250, 40, false);
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1370, 36, false);
#line 39 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1486, 43, false);
#line 42 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1609, 39, false);
#line 45 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1728, 39, false);
#line 48 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Stt));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1847, 35, false);
#line 51 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Stt));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1962, 42, false);
#line 54 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NewTab));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2084, 38, false);
#line 57 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NewTab));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2202, 55, false);
#line 60 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkNgonNguNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2337, 54, false);
#line 63 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkNgonNguNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2471, 55, false);
#line 66 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkUserTaoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2606, 60, false);
#line 69 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkUserTaoNavigation.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2666, 70, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            EndContext();
            BeginContext(2736, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acde08b24ecefd99eb19b3643069865f43dd20d313708", async() => {
                BeginContext(2762, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2784, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acde08b24ecefd99eb19b3643069865f43dd20d314113", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 74 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\Events\Delete.cshtml"
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
                BeginContext(2820, 107, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                    ");
                EndContext();
                BeginContext(2927, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acde08b24ecefd99eb19b3643069865f43dd20d316064", async() => {
                    BeginContext(2949, 12, true);
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
                BeginContext(2965, 18, true);
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
            BeginContext(2990, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminWebBenhVien.EfModels.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591