#pragma checksum "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Shared\EditorTemplates\GridForeignKey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e557156996bc43f700f5accc5ec8a953cb50540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_GridForeignKey), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/GridForeignKey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/GridForeignKey.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_GridForeignKey))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e557156996bc43f700f5accc5ec8a953cb50540", @"/Views/Shared/EditorTemplates/GridForeignKey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eea10d43a8cda2d592e6e7b5a8ffeea504dcab6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_GridForeignKey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 13, true);
            WriteLiteral("           \r\n");
            EndContext();
            BeginContext(30, 146, false);
#line 3 "C:\0TUYENNGUYEN\NLU\DotNet\WebBenhVien\HospitalWeb\Hospital.Web\Views\Shared\EditorTemplates\GridForeignKey.cshtml"
Write(
 Html.Kendo().DropDownListFor(m => m)        
        .BindTo((SelectList)ViewData[ViewData.TemplateInfo.GetFullHtmlFieldName("") + "_Data"])
);

#line default
#line hidden
            EndContext();
            BeginContext(177, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
