#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7057f81e26d4020534c00dde7b581311c1784d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoiDapYkhoas_Delete), @"mvc.1.0.view", @"/Views/HoiDapYkhoas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoiDapYkhoas/Delete.cshtml", typeof(AspNetCore.Views_HoiDapYkhoas_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7057f81e26d4020534c00dde7b581311c1784d4e", @"/Views/HoiDapYkhoas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00b3f6a877d1c1a7c47539d8be0adabbf5e0ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_HoiDapYkhoas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminWebBenhVien.EfModels.HoiDapYkhoa>
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
#line 2 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
  
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
#line 18 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(570, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(650, 38, false);
#line 21 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(688, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(768, 49, false);
#line 24 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NoiDungCauHoi));

#line default
#line hidden
            EndContext();
            BeginContext(817, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(897, 45, false);
#line 27 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NoiDungCauHoi));

#line default
#line hidden
            EndContext();
            BeginContext(942, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1022, 49, false);
#line 30 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.HoTenNguoiHoi));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1151, 45, false);
#line 33 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.HoTenNguoiHoi));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1276, 44, false);
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1400, 40, false);
#line 39 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1520, 49, false);
#line 42 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NoiDungTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1649, 45, false);
#line 45 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NoiDungTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1774, 49, false);
#line 48 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NgayGuiCauHoi));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1903, 45, false);
#line 51 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NgayGuiCauHoi));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2028, 46, false);
#line 54 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NgayTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2074, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2154, 42, false);
#line 57 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NgayTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2276, 47, false);
#line 60 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NguoiTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2323, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2403, 43, false);
#line 63 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NguoiTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2526, 42, false);
#line 66 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsShow));

#line default
#line hidden
            EndContext();
            BeginContext(2568, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2648, 38, false);
#line 69 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IsShow));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2766, 44, false);
#line 72 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.DaTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2810, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2890, 40, false);
#line 75 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.DaTraLoi));

#line default
#line hidden
            EndContext();
            BeginContext(2930, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3010, 41, false);
#line 78 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3051, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3131, 37, false);
#line 81 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3248, 42, false);
#line 84 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3370, 38, false);
#line 87 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(3408, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3488, 47, false);
#line 90 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.SoDienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3615, 43, false);
#line 93 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.SoDienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(3658, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3738, 58, false);
#line 96 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkChuyenKhoaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3796, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3876, 57, false);
#line 99 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkChuyenKhoaNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3933, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(4013, 55, false);
#line 102 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkNamSinhNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4068, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4148, 54, false);
#line 105 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkNamSinhNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(4282, 58, false);
#line 108 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FkUserTraLoiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4340, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4420, 63, false);
#line 111 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FkUserTraLoiNavigation.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(4483, 70, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            EndContext();
            BeginContext(4553, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7057f81e26d4020534c00dde7b581311c1784d4e20656", async() => {
                BeginContext(4579, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4601, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7057f81e26d4020534c00dde7b581311c1784d4e21061", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 116 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\HoiDapYkhoas\Delete.cshtml"
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
                BeginContext(4637, 107, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                    ");
                EndContext();
                BeginContext(4744, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7057f81e26d4020534c00dde7b581311c1784d4e23019", async() => {
                    BeginContext(4766, 12, true);
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
                BeginContext(4782, 18, true);
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
            BeginContext(4807, 58, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminWebBenhVien.EfModels.HoiDapYkhoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
