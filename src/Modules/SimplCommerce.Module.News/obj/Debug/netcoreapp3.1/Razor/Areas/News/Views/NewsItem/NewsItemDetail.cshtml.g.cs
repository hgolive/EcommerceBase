#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\NewsItem\NewsItemDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7129af50e71f695f21905a64e36dec75b163615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_News_Views_NewsItem_NewsItemDetail), @"mvc.1.0.view", @"/Areas/News/Views/NewsItem/NewsItemDetail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7129af50e71f695f21905a64e36dec75b163615", @"/Areas/News/Views/NewsItem/NewsItemDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de60e33cc27e4e118bc0808a0e74bae73482b185", @"/Areas/News/Views/_ViewImports.cshtml")]
    public class Areas_News_Views_NewsItem_NewsItemDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.News.Areas.News.ViewModels.NewsItemVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\NewsItem\NewsItemDetail.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"news-detail\">\n    <div class=\"row\">\n        <h3 class=\"news-title\">");
#nullable restore
#line 9 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\NewsItem\NewsItemDetail.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n        <div class=\"thumbnail\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 284, 1);
#nullable restore
#line 12 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\NewsItem\NewsItemDetail.cshtml"
WriteAttributeValue("", 260, Model.ThumbnailImageUrl, 260, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 285, "\"", 291, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n        <div class=\"news-item-full-description\">\n            ");
#nullable restore
#line 15 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.News\Areas\News\Views\NewsItem\NewsItemDetail.cshtml"
       Write(Html.Raw(Model.FullContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.News.Areas.News.ViewModels.NewsItemVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
