#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2f8bedbb529f4e3fffc22f86407fc6002a79e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Shared_Components_CarouselWidget_Default), @"mvc.1.0.view", @"/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c2f8bedbb529f4e3fffc22f86407fc6002a79e6", @"/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e487af9f599b2cd461681599ad34205d5bca37", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Shared_Components_CarouselWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div");
            BeginWriteAttribute("id", " id=\"", 88, "\"", 112, 2);
            WriteAttributeValue("", 93, "carousel", 93, 8, true);
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 101, Model.Id, 101, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"");
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                                    Write(Model.DataInterval);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <ol class=\"carousel-indicators\">\n");
#nullable restore
#line 5 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
         for (int i = 0; i < Model.Items.Count; i++)
        {
            if (i == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel");
#nullable restore
#line 9 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"0\" class=\"active\"></li>\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel");
#nullable restore
#line 13 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 13 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\n    <div class=\"carousel-inner\">\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 676, "\"", 746, 2);
            WriteAttributeValue("", 684, "carousel-item", 684, 13, true);
#nullable restore
#line 20 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue(" ", 697, item == Model.Items.First() ? "active" : null, 698, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <a");
            BeginWriteAttribute("href", " href=\"", 763, "\"", 785, 1);
#nullable restore
#line 21 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 770, item.TargetUrl, 770, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <img");
            BeginWriteAttribute("src", " src=\"", 808, "\"", 825, 1);
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 814, item.Image, 814, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 826, "\"", 845, 1);
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 832, item.Caption, 832, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\n                <div class=\"carousel-caption d-none d-md-block\" role=\"option\">\n                    <p>\n                        ");
#nullable restore
#line 25 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                   Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                </div>\n            </a>\n        </div>\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1169, 2);
            WriteAttributeValue("", 1149, "#carousel", 1149, 9, true);
#nullable restore
#line 32 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 1158, Model.Id, 1158, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\n        <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Previous</span>\n    </a>\n    <a class=\"carousel-control-next\"");
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1398, 2);
            WriteAttributeValue("", 1378, "#carousel", 1378, 9, true);
#nullable restore
#line 36 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 1387, Model.Id, 1387, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\n        <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Next</span>\n    </a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
