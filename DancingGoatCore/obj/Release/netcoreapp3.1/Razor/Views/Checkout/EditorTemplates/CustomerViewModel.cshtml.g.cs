#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a3cbac6492e023830bb562b79f7d09e7a018c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_EditorTemplates_CustomerViewModel), @"mvc.1.0.view", @"/Views/Checkout/EditorTemplates/CustomerViewModel.cshtml")]
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
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
using DancingGoat.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3cbac6492e023830bb562b79f7d09e7a018c1b", @"/Views/Checkout/EditorTemplates/CustomerViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_EditorTemplates_CustomerViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CustomerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<h4>");
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(HtmlLocalizer["Customer details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 7 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
 if (User.Identity.IsAuthenticated && !string.IsNullOrWhiteSpace(Model.Email))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.HiddenFor(model => model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(model => model.Email, disabled: true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
                                                                  
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
                                                  
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 19 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h4>");
#nullable restore
#line 21 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(HtmlLocalizer["Company details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 23 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 24 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.OrganizationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 25 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Checkout\EditorTemplates\CustomerViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.TaxRegistrationID));

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
