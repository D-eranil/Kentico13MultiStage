#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae451523645ad578f62c8e60a14d42a8cf3320c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Widgets_Articles__ArticlesWidget), @"mvc.1.0.view", @"/Components/Widgets/Articles/_ArticlesWidget.cshtml")]
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
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
using DancingGoat.InlineEditors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
using DancingGoat.Widgets;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae451523645ad578f62c8e60a14d42a8cf3320c9", @"/Components/Widgets/Articles/_ArticlesWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_Widgets_Articles__ArticlesWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticlesWidgetViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Components/InlineEditors/SpinnerEditor/_SpinnerEditor.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
  
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
 if (Context.Kentico().PageBuilder().EditMode)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae451523645ad578f62c8e60a14d42a8cf3320c95266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new SpinnerEditorViewModel
                    {
                        PropertyName = nameof(ArticlesWidgetProperties.Count),
                        Count = Model.Count
                    };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"articles-section\">\r\n    <div class=\"row\">\r\n        <div class=\"title-wrapper\">\r\n            <h1 class=\"title-tab\">");
#nullable restore
#line 23 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                             Write(HtmlLocalizer["Latest article"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n");
#nullable restore
#line 25 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
           var first = true; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
         foreach (var article in Model.Articles)
        {
            if (first)
            {
                first = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"article-tile article-tile-large\">\r\n                    <div class=\"article-tile-inner\">\r\n                        <div class=\"col-md-12 col-lg-6 col-xl-5\">\r\n");
#nullable restore
#line 34 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                             if (article.TeaserUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1161, 1);
#nullable restore
#line 36 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 1149, article.Url, 1149, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1205, "\"", 1242, 1);
#nullable restore
#line 37 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 1211, article.TeaserUrl.RelativePath, 1211, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1243, "\"", 1263, 1);
#nullable restore
#line 37 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 1249, article.Title, 1249, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1264, "\"", 1286, 1);
#nullable restore
#line 37 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 1272, article.Title, 1272, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"article-tile-image\" />\r\n                                </a>\r\n");
#nullable restore
#line 39 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-12 col-lg-6 col-xl-7 article-tile-info\">\r\n                            <div class=\"article-tile-date\">\r\n                                ");
#nullable restore
#line 43 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                           Write(article.PublicationDate.ToString("m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"article-tile-content\">\r\n                                <h2>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1814, "\"", 1833, 1);
#nullable restore
#line 47 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 1821, article.Url, 1821, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                                                      Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h2>\r\n                                <p class=\"article-tile-text lead-paragraph\">\r\n                                    ");
#nullable restore
#line 50 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                               Write(article.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
            }
            else
            {
                var lastInRow = "";
                if (i % 4 == 0)
                {
                    lastInRow = "last";
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 2403, "\"", 2462, 4);
            WriteAttributeValue("", 2411, "col-md-3", 2411, 8, true);
            WriteAttributeValue(" ", 2419, "article-tile", 2420, 13, true);
            WriteAttributeValue(" ", 2432, "article-tile-small", 2433, 19, true);
#nullable restore
#line 65 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue(" ", 2451, lastInRow, 2452, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"article-tile-inner\">\r\n");
#nullable restore
#line 67 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                         if (article.TeaserUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2634, "\"", 2653, 1);
#nullable restore
#line 69 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 2641, article.Url, 2641, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2693, "\"", 2776, 1);
#nullable restore
#line 70 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 2699, article.TeaserUrl.WithSizeConstraint(SizeConstraint.Width(400)).RelativePath, 2699, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2777, "\"", 2797, 1);
#nullable restore
#line 70 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 2783, article.Title, 2783, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2798, "\"", 2820, 1);
#nullable restore
#line 70 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 2806, article.Title, 2806, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"article-tile-image\" />\r\n                            </a>\r\n");
#nullable restore
#line 72 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"article-tile-info\">\r\n                            <div class=\"article-tile-date\">\r\n                                ");
#nullable restore
#line 75 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                           Write(article.PublicationDate.ToString("m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"article-tile-content\">\r\n                                <h2 class=\"h4\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3291, "\"", 3310, 1);
#nullable restore
#line 79 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 3298, article.Url, 3298, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                                                      Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                </h2>\r\n                                <p class=\"article-tile-text\">\r\n                                    ");
#nullable restore
#line 82 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                               Write(article.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                if (i % 4 == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"clear\"></div>\r\n");
#nullable restore
#line 91 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
                }
                i++;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"clear center-text\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3905, "\"", 3967, 1);
#nullable restore
#line 99 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
WriteAttributeValue("", 3912, Url.Kentico().PageUrl(ContentItemIdentifiers.ARTICLES), 3912, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-more\">\r\n                ");
#nullable restore
#line 100 "D:\Project\Kentico13Multi\DancingGoatCore\Components\Widgets\Articles\_ArticlesWidget.cshtml"
           Write(HtmlLocalizer["More articles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticlesWidgetViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
