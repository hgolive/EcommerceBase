#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.PaymentNganLuong\Areas\PaymentNganLuong\Views\Shared\Components\NganLuongLanding\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5bf07d2041142a39a361094dfdf74d6e9dc9b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PaymentNganLuong_Views_Shared_Components_NganLuongLanding_Default), @"mvc.1.0.view", @"/Areas/PaymentNganLuong/Views/Shared/Components/NganLuongLanding/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.PaymentNganLuong\Areas\PaymentNganLuong\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.PaymentNganLuong\Areas\PaymentNganLuong\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5bf07d2041142a39a361094dfdf74d6e9dc9b2d", @"/Areas/PaymentNganLuong/Views/Shared/Components/NganLuongLanding/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/PaymentNganLuong/Views/_ViewImports.cshtml")]
    public class Areas_PaymentNganLuong_Views_Shared_Components_NganLuongLanding_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<label>Ng??n h??ng n???i ?????a, Visa, Master (Ng??n l?????ng)</label>
<button type=""button"" id=""nganluongPayment"" class=""btn btn-order"">Ch???n ng??n h??ng</button>

<script>
    /*global $ */
    $(function () {
        $('body').on('click', '#nganluongPayment', function () {
            $.ajax({
                type: 'GET',
                url: '/ngan-luong/payment-methods'
            }).done(function (data) {
                $('#shopModal').find('.modal-content').html(data);
                $('#shopModal').modal('show');
            });
        });
    });

</script>
");
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
