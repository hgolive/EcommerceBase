#pragma checksum "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95729a0e38e3a31743a27df71790681321c0d80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_Manage_Index), @"mvc.1.0.view", @"/Areas/Core/Views/Manage/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95729a0e38e3a31743a27df71790681321c0d80", @"/Areas/Core/Views/Manage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f9af2dbfb59a463c9fdb28e6eb5cce06455bad", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_Manage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private global::AspNetCore.Areas_Core_Views_Manage_Index.__Generated__DefaultShippingAddressViewComponentTagHelper __DefaultShippingAddressViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AccountMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/user/info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Core", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-bracketed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
  
    ViewData["Title"] = "Manage your account";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
 if (ViewData["StatusMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-success\">");
#nullable restore
#line 7 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                       Write(ViewData["StatusMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b95729a0e38e3a31743a27df71790681321c0d808413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"col-md-9\">\n        <h2>");
#nullable restore
#line 14 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
       Write(Localizer["Account Dashboard"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <hr />\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <div class=\"card\">\n                    <div class=\"card-header\">");
#nullable restore
#line 19 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                        Write(Localizer["Account Information"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"card-body\">\n                        ");
#nullable restore
#line 21 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\n                        ");
#nullable restore
#line 22 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <p class=\"text-right\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95729a0e38e3a31743a27df71790681321c0d8011095", async() => {
#nullable restore
#line 24 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                             Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mt-4"">
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">");
#nullable restore
#line 33 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                        Write(Localizer["Security"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"card-body\">\n                        <dl class=\"row\">\n                            <dt class=\"col-md-5\">");
#nullable restore
#line 36 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                            Write(Localizer["Password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</dt>\n                            <dd class=\"col-md-7\">\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                 if (Model.HasPassword)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95729a0e38e3a31743a27df71790681321c0d8013855", async() => {
#nullable restore
#line 40 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                                                                                                            Write(Localizer["Change"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95729a0e38e3a31743a27df71790681321c0d8016188", async() => {
#nullable restore
#line 44 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                                                                                                         Write(Localizer["Create"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 45 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </dd>\n                            <dt class=\"col-md-5\">");
#nullable restore
#line 47 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                            Write(Localizer["External Logins"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</dt>\n                            <dd class=\"col-md-7\">\n                                ");
#nullable restore
#line 49 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                           Write(Model.Logins.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95729a0e38e3a31743a27df71790681321c0d8019196", async() => {
#nullable restore
#line 49 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                                                                                                                          Write(Localizer["Manage"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </dd>\n                        </dl>\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-md-6\">\n                <div class=\"card\">\n                    <div class=\"card-header\">");
#nullable restore
#line 57 "C:\Users\User\Desktop\App\SimplCommerce-master\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Manage\Index.cshtml"
                                        Write(Localizer["Default shipping address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"card-body\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:default-shipping-address", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b95729a0e38e3a31743a27df71790681321c0d8021829", async() => {
            }
            );
            __DefaultShippingAddressViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Core_Views_Manage_Index.__Generated__DefaultShippingAddressViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__DefaultShippingAddressViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:default-shipping-address")]
        public class __Generated__DefaultShippingAddressViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__DefaultShippingAddressViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("DefaultShippingAddress", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591