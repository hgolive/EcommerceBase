#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182070d65fc5dda043968be9d97c52d748ad1315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Orders_Views_Shared_Components_OrderSummary_Default), @"mvc.1.0.view", @"/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182070d65fc5dda043968be9d97c52d748ad1315", @"/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/Orders/Views/_ViewImports.cshtml")]
    public class Areas_Orders_Views_Shared_Components_OrderSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.CartVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h3>");
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
Write(Localizer["Order summary"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n<table class=\"table\">\n    <tr>\n        <th>");
#nullable restore
#line 6 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
       Write(Localizer["Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <th class=\"text-center\">");
#nullable restore
#line 7 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                           Write(Localizer["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <th class=\"text-right\">");
#nullable restore
#line 8 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                          Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    </tr>\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 14 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                 if (item.VariationOptions.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"list-unstyled\">\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                         foreach (var attr in item.VariationOptions)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><span>");
#nullable restore
#line 20 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                 Write(attr.OptionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 20 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                                          Write(attr.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td class=\"text-center\">");
#nullable restore
#line 25 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">");
#nullable restore
#line 26 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                              Write(item.ProductPriceString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 30 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
       Write(Localizer["Order note"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                      Write(Model.OrderNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 34 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
       Write(Localizer["Subtotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
#nullable restore
#line 35 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                      Write(Model.SubTotalString);

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\" id=\"orderSubtotal\"");
            BeginWriteAttribute("value", " value=\"", 1219, "\"", 1242, 1);
#nullable restore
#line 35 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
WriteAttributeValue("", 1227, Model.SubTotal, 1227, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 38 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
       Write(Localizer["Shipping"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td colspan=\"2\" id=\"orderSummaryShipping\" class=\"text-right\">");
#nullable restore
#line 39 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                                                Write(Model.ShippingAmountString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
     if (!Model.IsProductPriceIncludeTax)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>Tax</td>\n            <td colspan=\"2\" id=\"orderSummaryTax\" class=\"text-right\">");
#nullable restore
#line 45 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                                               Write(Model.TaxAmountString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 49 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
       Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
#nullable restore
#line 50 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                      Write(Model.DiscountString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>\n            <strong>");
#nullable restore
#line 54 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
               Write(Localizer["Order Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 55 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
             if (Model.IsProductPriceIncludeTax)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> (");
#nullable restore
#line 57 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                   Write(Localizer["VAT included"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\n");
#nullable restore
#line 58 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n        <td colspan=\"2\" class=\"text-right\"><strong id=\"orderTotal\">");
#nullable restore
#line 60 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Orders\Areas\Orders\Views\Shared\Components\OrderSummary\Default.cshtml"
                                                              Write(Model.OrderTotalString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n    </tr>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.CartVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
