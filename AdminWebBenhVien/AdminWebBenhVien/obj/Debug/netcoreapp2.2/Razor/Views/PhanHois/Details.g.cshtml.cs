#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6605df7ac5a9238d7be6505e651ed3111e68e59f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhanHois_Details), @"mvc.1.0.view", @"/Views/PhanHois/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhanHois/Details.cshtml", typeof(AspNetCore.Views_PhanHois_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6605df7ac5a9238d7be6505e651ed3111e68e59f", @"/Views/PhanHois/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00b3f6a877d1c1a7c47539d8be0adabbf5e0ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_PhanHois_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminWebBenhVien.EfModels.PhanHoi>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(71, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(100, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6605df7ac5a9238d7be6505e651ed3111e68e59f4478", async() => {
                BeginContext(106, 89, true);
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
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(204, 3392, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6605df7ac5a9238d7be6505e651ed3111e68e59f5756", async() => {
                BeginContext(210, 103, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>PhanHoi</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(314, 44, false);
#line 21 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayKham));

#line default
#line hidden
                EndContext();
                BeginContext(358, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(402, 40, false);
#line 24 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayKham));

#line default
#line hidden
                EndContext();
                BeginContext(442, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(486, 48, false);
#line 27 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSoBenhNhan));

#line default
#line hidden
                EndContext();
                BeginContext(534, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(578, 44, false);
#line 30 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaSoBenhNhan));

#line default
#line hidden
                EndContext();
                BeginContext(622, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(666, 43, false);
#line 33 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoVaTen));

#line default
#line hidden
                EndContext();
                BeginContext(709, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(753, 39, false);
#line 36 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoVaTen));

#line default
#line hidden
                EndContext();
                BeginContext(792, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(836, 41, false);
#line 39 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(877, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(921, 37, false);
#line 42 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(958, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1002, 44, false);
#line 45 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
                EndContext();
                BeginContext(1046, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1090, 40, false);
#line 48 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
                EndContext();
                BeginContext(1130, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1174, 44, false);
#line 51 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
                EndContext();
                BeginContext(1218, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1262, 40, false);
#line 54 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
                EndContext();
                BeginContext(1302, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1346, 45, false);
#line 57 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
                EndContext();
                BeginContext(1391, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1435, 41, false);
#line 60 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
                EndContext();
                BeginContext(1476, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1520, 43, false);
#line 63 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
                EndContext();
                BeginContext(1563, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1607, 39, false);
#line 66 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoiDung));

#line default
#line hidden
                EndContext();
                BeginContext(1646, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1690, 43, false);
#line 69 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayGui));

#line default
#line hidden
                EndContext();
                BeginContext(1733, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1777, 39, false);
#line 72 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayGui));

#line default
#line hidden
                EndContext();
                BeginContext(1816, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1860, 41, false);
#line 75 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DaXem));

#line default
#line hidden
                EndContext();
                BeginContext(1901, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1945, 37, false);
#line 78 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.DaXem));

#line default
#line hidden
                EndContext();
                BeginContext(1982, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2026, 49, false);
#line 81 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkLoaiPhanHoi));

#line default
#line hidden
                EndContext();
                BeginContext(2075, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2119, 45, false);
#line 84 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkLoaiPhanHoi));

#line default
#line hidden
                EndContext();
                BeginContext(2164, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2208, 49, false);
#line 87 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoiDungTraLoi));

#line default
#line hidden
                EndContext();
                BeginContext(2257, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2301, 45, false);
#line 90 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoiDungTraLoi));

#line default
#line hidden
                EndContext();
                BeginContext(2346, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2390, 46, false);
#line 93 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayTraLoi));

#line default
#line hidden
                EndContext();
                BeginContext(2436, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2480, 42, false);
#line 96 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayTraLoi));

#line default
#line hidden
                EndContext();
                BeginContext(2522, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2566, 42, false);
#line 99 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
                EndContext();
                BeginContext(2608, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2652, 38, false);
#line 102 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
                EndContext();
                BeginContext(2690, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2734, 42, false);
#line 105 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsShow));

#line default
#line hidden
                EndContext();
                BeginContext(2776, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2820, 38, false);
#line 108 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsShow));

#line default
#line hidden
                EndContext();
                BeginContext(2858, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2902, 42, false);
#line 111 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
                EndContext();
                BeginContext(2944, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2988, 38, false);
#line 114 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
                EndContext();
                BeginContext(3026, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3070, 55, false);
#line 117 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkNgonNguNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(3125, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3169, 54, false);
#line 120 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkNgonNguNavigation.Id));

#line default
#line hidden
                EndContext();
                BeginContext(3223, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3267, 58, false);
#line 123 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkUserTraLoiNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(3325, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3369, 63, false);
#line 126 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkUserTraLoiNavigation.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(3432, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(3479, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6605df7ac5a9238d7be6505e651ed3111e68e59f22378", async() => {
                    BeginContext(3525, 4, true);
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
#line 131 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\AdminWebBenhVien\AdminWebBenhVien\Views\PhanHois\Details.cshtml"
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
                BeginContext(3533, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(3541, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6605df7ac5a9238d7be6505e651ed3111e68e59f24844", async() => {
                    BeginContext(3563, 12, true);
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
                BeginContext(3579, 10, true);
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
            BeginContext(3596, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminWebBenhVien.EfModels.PhanHoi> Html { get; private set; }
    }
}
#pragma warning restore 1591
