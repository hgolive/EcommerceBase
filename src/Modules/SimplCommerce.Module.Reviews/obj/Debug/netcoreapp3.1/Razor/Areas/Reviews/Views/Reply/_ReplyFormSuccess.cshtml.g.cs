#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Reviews\Areas\Reviews\Views\Reply\_ReplyFormSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d9dd3bbf4cdd6838aa3126731aa09d99371b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reviews_Views_Reply__ReplyFormSuccess), @"mvc.1.0.view", @"/Areas/Reviews/Views/Reply/_ReplyFormSuccess.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Reviews\Areas\Reviews\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Reviews\Areas\Reviews\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d9dd3bbf4cdd6838aa3126731aa09d99371b9d", @"/Areas/Reviews/Views/Reply/_ReplyFormSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b18b37fdf10ebd4e5da15d287bba8bbf9154ca2", @"/Areas/Reviews/Views/_ViewImports.cshtml")]
    public class Areas_Reviews_Views_Reply__ReplyFormSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels.ReplyForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"alert alert-success\" role=\"alert\">\n    <h4>\n        ");
#nullable restore
#line 5 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Reviews\Areas\Reviews\Views\Reply\_ReplyFormSuccess.cshtml"
   Write(Localizer["Thank you {0} for your reply", Model.ReplierName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h4>\n\n    <p>");
#nullable restore
#line 8 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Reviews\Areas\Reviews\Views\Reply\_ReplyFormSuccess.cshtml"
  Write(Localizer["Your reply will be shown within the next 24h."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels.ReplyForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
