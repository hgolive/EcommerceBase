#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17dfdacd768f687e9a197c290ee543dd9f5b915e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Page_PageDetail), @"mvc.1.0.view", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17dfdacd768f687e9a197c290ee543dd9f5b915e", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e487af9f599b2cd461681599ad34205d5bca37", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Page_PageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.PageVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
  
    ViewBag.Title = Model.MetaTitle ?? Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("additionalMeta", async() => {
                WriteLiteral("\n    <meta name=\"title\"");
                BeginWriteAttribute("content", " content=\"", 166, "\"", 190, 1);
#nullable restore
#line 8 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 176, ViewBag.Title, 176, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 220, "\"", 249, 1);
#nullable restore
#line 9 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 230, Model.MetaKeywords, 230, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 282, "\"", 314, 1);
#nullable restore
#line 10 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 292, Model.MetaDescription, 292, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
            }
            );
            WriteLiteral("\n<div>");
#nullable restore
#line 13 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.PageVm> Html { get; private set; }
    }
}
#pragma warning restore 1591