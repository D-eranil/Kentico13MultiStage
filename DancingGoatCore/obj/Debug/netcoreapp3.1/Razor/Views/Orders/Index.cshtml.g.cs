#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ea71bb3e44a085676f7882cf1e68808bb5d0e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ea71bb3e44a085676f7882cf1e68808bb5d0e5", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DancingGoat.Models.OrdersListViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YourAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-terciary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Your orders"].Value;
    ViewData["PageClass"] = "inverted no-bg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73ea71bb3e44a085676f7882cf1e68808bb5d0e55409", async() => {
                WriteLiteral("&larr; ");
#nullable restore
#line 8 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                                       Write(HtmlLocalizer["back to Your Account"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<h2>");
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
Write(HtmlLocalizer["Your orders"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div id=\"no-more-tables\">\n    <table class=\"orders-table\">\n        <thead>\n            <tr>\n                <th class=\"column-id\">");
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                 Write(HtmlLocalizer["Order ID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th class=\"column-date\">");
#nullable restore
#line 17 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                   Write(HtmlLocalizer["Order date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th class=\"column-status\">");
#nullable restore
#line 18 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                     Write(HtmlLocalizer["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th class=\"column-total\">");
#nullable restore
#line 19 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                    Write(HtmlLocalizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 23 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
             foreach (var order in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"column-id\">\n                        <span class=\"strong\">");
#nullable restore
#line 27 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                        Write(order.OrderInvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73ea71bb3e44a085676f7882cf1e68808bb5d0e59239", async() => {
#nullable restore
#line 28 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                                                                                           Write(HtmlLocalizer["Order Detail"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                                           WriteLiteral(order.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                    <td class=\"column-date\">");
#nullable restore
#line 30 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"column-status\">\n                        <span class=\"status\">\n                            ");
#nullable restore
#line 33 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                       Write(HtmlLocalizer[order.StatusName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </span>\n                    </td>\n                    <td class=\"column-total\">");
#nullable restore
#line 36 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
                                        Write(order.FormattedTotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 38 "D:\Project\Kentico13Multi\DancingGoatCore\Views\Orders\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DancingGoat.Models.OrdersListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
