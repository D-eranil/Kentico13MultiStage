#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd939e5dbc6a356548a3a9801d635e53d916ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout__ShoppingCartTotals), @"mvc.1.0.view", @"/Views/Checkout/_ShoppingCartTotals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd939e5dbc6a356548a3a9801d635e53d916ee7", @"/Views/Checkout/_ShoppingCartTotals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout__ShoppingCartTotals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CartViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
  
    var tax = Model.TotalTax;
    var shipping = Model.TotalShipping;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
 if (tax > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"cart-total-viewer\">\n        <div class=\"label\">\n            ");
#nullable restore
#line 12 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
       Write(HtmlLocalizer["Total tax"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"value\">\n            ");
#nullable restore
#line 15 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
       Write(Model.FormatPrice(tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 18 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 20 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
 if (shipping > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"cart-total-viewer\">\n        <div class=\"label\">\n            ");
#nullable restore
#line 24 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
       Write(HtmlLocalizer["Shipping"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"value\">\n            ");
#nullable restore
#line 27 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
       Write(Model.FormatPrice(shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 30 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 33 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
 if ((tax > 0) || (shipping > 0))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\n");
#nullable restore
#line 36 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"cart-total\">\n    <div class=\"cart-total-viewer\">\n        <div class=\"label\">\n            <span>");
#nullable restore
#line 41 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
             Write(HtmlLocalizer["Total (incl. tax estimate)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n        <div class=\"value\">\n            <span>");
#nullable restore
#line 44 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\_ShoppingCartTotals.cshtml"
             Write(Model.FormatPrice(Model.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n    </div>\n</div>\n");
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
