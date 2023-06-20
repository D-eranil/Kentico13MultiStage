#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f79b0e0e886947c7bd525c99fcd940577b8cb94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_ProductListItem), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/ProductListItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f79b0e0e886947c7bd525c99fcd940577b8cb94", @"/Views/Shared/DisplayTemplates/ProductListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_DisplayTemplates_ProductListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ProductListItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
  
    var price = Model.PriceDetail;
    var currency = price.Currency;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article class=\"product-tile\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 173, "\"", 190, 1);
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
WriteAttributeValue("", 180, Model.Url, 180, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1 class=\"product-heading\">");
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
         if (!string.IsNullOrEmpty(Model.PublicStatusName))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"product-tile-status\">\r\n                ");
#nullable restore
#line 14 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
           Write(HtmlLocalizer[Model.PublicStatusName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <figure class=\"product-tile-image\">\r\n");
#nullable restore
#line 18 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
             if (!string.IsNullOrEmpty(Model.ImagePath))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 594, "\"", 616, 1);
#nullable restore
#line 20 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
WriteAttributeValue("", 600, Model.ImagePath, 600, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 617, "\"", 634, 1);
#nullable restore
#line 20 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
WriteAttributeValue("", 623, Model.Name, 623, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 635, "\"", 654, 1);
#nullable restore
#line 20 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
WriteAttributeValue("", 643, Model.Name, 643, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
                 if (!Model.Available)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"product-tile-stock notavailable\"> ");
#nullable restore
#line 23 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
                                                              Write(HtmlLocalizer["Out of stock"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </figure>\r\n        <div class=\"product-tile-info\">\r\n            <span class=\"product-tile-price\">\r\n                ");
#nullable restore
#line 29 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
           Write(string.Format(currency.CurrencyFormatString, price.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 31 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
             if (price.ListPrice > price.Price)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"product-tile-list-price\">\r\n                    ");
#nullable restore
#line 34 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
               Write(string.Format(currency.CurrencyFormatString, price.ListPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n");
#nullable restore
#line 36 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Shared\DisplayTemplates\ProductListItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </a>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ProductListItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
