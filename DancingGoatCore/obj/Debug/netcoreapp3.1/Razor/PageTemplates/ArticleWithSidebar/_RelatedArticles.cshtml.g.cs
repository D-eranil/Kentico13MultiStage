#pragma checksum "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9059d01da4824766263cf3ed75360d973d5ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PageTemplates_ArticleWithSidebar__RelatedArticles), @"mvc.1.0.view", @"/PageTemplates/ArticleWithSidebar/_RelatedArticles.cshtml")]
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
#line 1 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9059d01da4824766263cf3ed75360d973d5ca6", @"/PageTemplates/ArticleWithSidebar/_RelatedArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/PageTemplates/_ViewImports.cshtml")]
    #nullable restore
    public class PageTemplates_ArticleWithSidebar__RelatedArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DancingGoat.PageTemplates.RelatedArticleViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" article-related-articles\">\r\n        <div class=\"title-wrapper\">\r\n            <h1 class=\"title-tab\">");
#nullable restore
#line 6 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                             Write(HtmlLocalizer["Related articles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
             foreach (var article in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 373, "\"", 463, 2);
            WriteAttributeValue("", 381, "article-tile", 381, 12, true);
#nullable restore
#line 11 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue(" ", 393, article.HandleArticlePosition ? "col-lg-3 col-md-6 col-sm-12" : "", 394, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"article-tile-inner\">\r\n");
#nullable restore
#line 13 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                         if (!string.IsNullOrEmpty(article.TeaserPath))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 651, "\"", 670, 1);
#nullable restore
#line 15 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue("", 658, article.Url, 658, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 710, "\"", 735, 1);
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue("", 716, article.TeaserPath, 716, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 736, "\"", 756, 1);
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue("", 742, article.Title, 742, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 757, "\"", 779, 1);
#nullable restore
#line 16 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue("", 765, article.Title, 765, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"article-tile-image\" />\r\n                            </a>\r\n");
#nullable restore
#line 18 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"article-tile-info\">\r\n                            <div class=\"article-tile-date\">\r\n                                ");
#nullable restore
#line 21 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                           Write(article.PublicationDate.ToString("m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"article-tile-content\">\r\n                                <h2 class=\"h4\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1269, 1);
#nullable restore
#line 25 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
WriteAttributeValue("", 1257, article.Url, 1257, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                                                      Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                </h2>\r\n                                <p class=\"article-tile-text\">\r\n                                    ");
#nullable restore
#line 28 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
                               Write(article.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Project\Kentico13Multi\DancingGoatCore\PageTemplates\ArticleWithSidebar\_RelatedArticles.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DancingGoat.PageTemplates.RelatedArticleViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
