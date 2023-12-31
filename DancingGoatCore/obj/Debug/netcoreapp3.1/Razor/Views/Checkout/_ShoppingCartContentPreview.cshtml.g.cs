#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2331b5526ef7236f5fd879f4f64541ae05baa094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout__ShoppingCartContentPreview), @"mvc.1.0.view", @"/Views/Checkout/_ShoppingCartContentPreview.cshtml")]
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
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2331b5526ef7236f5fd879f4f64541ae05baa094", @"/Views/Checkout/_ShoppingCartContentPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout__ShoppingCartContentPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CartViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
 foreach (var cartItem in Model.CartItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 7 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
             if (!string.IsNullOrEmpty(cartItem.SKUImagePath))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"cart-item-image\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 294, "\"", 358, 1);
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
WriteAttributeValue("", 301, Url.Action("ItemDetail", new { skuId = cartItem.SKUID }), 301, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 390, "\"", 418, 1);
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
WriteAttributeValue("", 396, cartItem.SKUImagePath, 396, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 419, "\"", 442, 1);
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
WriteAttributeValue("", 425, cartItem.SKUName, 425, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 443, "\"", 468, 1);
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
WriteAttributeValue("", 451, cartItem.SKUName, 451, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 14 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cart-item-info\">\r\n                ");
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
           Write(Html.ActionLink(cartItem.SKUName, "ItemDetail", new { skuId = cartItem.SKUID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"cart-item-amount\">\r\n                <span>Qty</span>\r\n                <input type=\"text\" name=\"Units\"");
            BeginWriteAttribute("value", " value=\"", 824, "\"", 855, 1);
#nullable restore
#line 20 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
WriteAttributeValue("", 832, cartItem.CartItemUnits, 832, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" disabled />\r\n            </div>\r\n\r\n            ");
#nullable restore
#line 23 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
       Write(Html.ValidationMessage(cartItem.CartItemID.ToString(), new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"col-md-2 cart-item-subtotal\">\r\n            <span>");
#nullable restore
#line 27 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
             Write(Model.FormatPrice(cartItem.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 31 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartContentPreview.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
