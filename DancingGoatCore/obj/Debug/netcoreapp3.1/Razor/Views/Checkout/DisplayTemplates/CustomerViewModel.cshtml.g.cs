#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126209fab266ec487bf6b0ae7565c27e67b9d22d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_DisplayTemplates_CustomerViewModel), @"mvc.1.0.view", @"/Views/Checkout/DisplayTemplates/CustomerViewModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126209fab266ec487bf6b0ae7565c27e67b9d22d", @"/Views/Checkout/DisplayTemplates/CustomerViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_DisplayTemplates_CustomerViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CustomerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
                 Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 4 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
 if (Model.IsCompanyAccount)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <div>");
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div>");
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.OrganizationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div>");
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.TaxRegistrationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 12 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CustomerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
