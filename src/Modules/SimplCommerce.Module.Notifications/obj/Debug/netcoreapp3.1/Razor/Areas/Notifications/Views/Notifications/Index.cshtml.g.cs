#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Notifications\Areas\Notifications\Views\Notifications\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8cf405d9f239ba71314c9e2bbb14d27e396bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Notifications_Views_Notifications_Index), @"mvc.1.0.view", @"/Areas/Notifications/Views/Notifications/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Notifications\Areas\Notifications\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Notifications\Areas\Notifications\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8cf405d9f239ba71314c9e2bbb14d27e396bbf", @"/Areas/Notifications/Views/Notifications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/Notifications/Views/_ViewImports.cshtml")]
    public class Areas_Notifications_Views_Notifications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Notifications\Areas\Notifications\Views\Notifications\Index.cshtml"
  
    ViewData["Title"] = "Notifications";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Notifications</h1>\n\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Notifications\Areas\Notifications\Views\Notifications\Index.cshtml"
Write(await Component.InvokeAsync("TestRealTimeNotificationForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591