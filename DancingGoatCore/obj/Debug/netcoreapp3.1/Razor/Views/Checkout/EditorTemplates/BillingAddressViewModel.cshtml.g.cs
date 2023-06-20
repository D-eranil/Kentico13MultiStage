#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd05907626747daa4c42aba22c86de0f97fad44b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_EditorTemplates_BillingAddressViewModel), @"mvc.1.0.view", @"/Views/Checkout/EditorTemplates/BillingAddressViewModel.cshtml")]
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
#nullable restore
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
using DancingGoat.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd05907626747daa4c42aba22c86de0f97fad44b", @"/Views/Checkout/EditorTemplates/BillingAddressViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_EditorTemplates_BillingAddressViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.BillingAddressViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<h4>");
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(HtmlLocalizer["Billing address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n\n<div data-addresstype=\'BillingAddress\' data-fields=\'[\"Line1\", \"Line2\", \"City\", \"PostalCode\"]\'>\n    ");
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.EditorFor(m => m.BillingAddressSelector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressLine1, HtmlLocalizer["e.g. street address, P.O.box, c/o"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressLine2, HtmlLocalizer["e.g. apartment, suite, unit, building"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 12 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 13 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    ");
#nullable restore
#line 15 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.EditorFor(m => m.BillingAddressCountryStateSelector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.BillingAddressViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591