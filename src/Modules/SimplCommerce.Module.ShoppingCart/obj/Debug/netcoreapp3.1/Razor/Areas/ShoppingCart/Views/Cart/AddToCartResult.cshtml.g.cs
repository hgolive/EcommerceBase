#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "199bef471bbf209b09f335d2a7fbc8739b9aa038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_AddToCartResult), @"mvc.1.0.view", @"/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199bef471bbf209b09f335d2a7fbc8739b9aa038", @"/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/ShoppingCart/Views/_ViewImports.cshtml")]
    public class Areas_ShoppingCart_Views_Cart_AddToCartResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.AddToCartResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"modal-header\">\n    <h5 class=\"modal-title\" id=\"myModalLabel\">");
#nullable restore
#line 4 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                         Write(Localizer["The product has been added to your cart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n</div>\n<div class=\"modal-body\">\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            <img");
            BeginWriteAttribute("alt", " alt=\"", 450, "\"", 474, 1);
#nullable restore
#line 10 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
WriteAttributeValue("", 456, Model.ProductName, 456, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 493, "\"", 518, 1);
#nullable restore
#line 10 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
WriteAttributeValue("", 499, Model.ProductImage, 499, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"col-md-6\">\n            <h4>");
#nullable restore
#line 13 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h6>");
#nullable restore
#line 14 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
           Write(Model.VariationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        </div>\n        <div class=\"col-md-3\">\n            ");
#nullable restore
#line 17 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
       Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 17 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                         Write(Model.ProductPriceString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-7\">\n            ");
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
       Write(Localizer["You have"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"cart-item-count\">");
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                                            Write(Model.CartItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                                                                        Write(Localizer["products in your cart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"col-md-5\">\n            ");
#nullable restore
#line 25 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
       Write(Localizer["Cart subtotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 25 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                    Write(Model.CartAmountString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn btn-light\" data-dismiss=\"modal\">");
#nullable restore
#line 30 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                                                Write(Localizer["Continue shopping"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "199bef471bbf209b09f335d2a7fbc8739b9aa0389887", async() => {
#nullable restore
#line 31 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.ShoppingCart\Areas\ShoppingCart\Views\Cart\AddToCartResult.cshtml"
                                                    Write(Localizer["View cart"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.AddToCartResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
