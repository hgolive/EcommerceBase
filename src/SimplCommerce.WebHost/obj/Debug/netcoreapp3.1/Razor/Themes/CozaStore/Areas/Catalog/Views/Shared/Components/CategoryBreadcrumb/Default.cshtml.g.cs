#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\Shared\Components\CategoryBreadcrumb\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493397cf4c19fbdb04320bc8af2a653062772abe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Themes_CozaStore_Areas_Catalog_Views_Shared_Components_CategoryBreadcrumb_Default), @"mvc.1.0.view", @"/Themes/CozaStore/Areas/Catalog/Views/Shared/Components/CategoryBreadcrumb/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493397cf4c19fbdb04320bc8af2a653062772abe", @"/Themes/CozaStore/Areas/Catalog/Views/Shared/Components/CategoryBreadcrumb/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c6730de28836406dc9c2c70e72637c211429e73", @"/Themes/CozaStore/Areas/Catalog/Views/_ViewImports.cshtml")]
    public class Themes_CozaStore_Areas_Catalog_Views_Shared_Components_CategoryBreadcrumb_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.BreadcrumbViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-109 cl8 hov-cl1 trans-04"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\Shared\Components\CategoryBreadcrumb\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "493397cf4c19fbdb04320bc8af2a653062772abe4568", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 6 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\Shared\Components\CategoryBreadcrumb\Default.cshtml"
Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <i class=\"fa fa-angle-right m-l-9 m-r-10\" aria-hidden=\"true\"></i>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 129, "~/", 129, 2, true);
#nullable restore
#line 5 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\Shared\Components\CategoryBreadcrumb\Default.cshtml"
AddHtmlAttributeValue("", 131, item.Url, 131, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\App\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Catalog\Views\Shared\Components\CategoryBreadcrumb\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.BreadcrumbViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591