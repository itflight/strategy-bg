#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79fb4a185881d53d919eaf0d6cd31bb2a6d31c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Index), @"mvc.1.0.view", @"/Views/Article/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Article/Index.cshtml", typeof(AspNetCore.Views_Article_Index))]
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models.ViewModels.Account;

#line default
#line hidden
#line 5 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models.ViewModels.Portal;

#line default
#line hidden
#line 6 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models.ViewModels.MulticriteriaAnalysis;

#line default
#line hidden
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using WebCommon.TagHelpers;

#line default
#line hidden
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using WebCommon.Models;

#line default
#line hidden
#line 9 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Models.Context;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79fb4a185881d53d919eaf0d6cd31bb2a6d31c8", @"/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a9a60c20537480d66fd9d2d41d1eec08c8ef00", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OgpLeftMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
  
    ViewData["Title"] = "Партньорство за открито управление";
    ViewData["SectionTitle"] = ViewData["Title"];

#line default
#line hidden
            DefineSection("breadcrumbs", async() => {
                BeginContext(142, 45, true);
                WriteLiteral("\r\n    <div class=\"breadcrumbs\">\r\n        / <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 187, "\"", 221, 1);
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
WriteAttributeValue("", 194, Url.Action("Index","Home"), 194, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(222, 25, true);
                WriteLiteral(">Начало</a>\r\n        / <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 247, "\"", 274, 1);
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
WriteAttributeValue("", 254, Url.Action("Index"), 254, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(275, 23, true);
                WriteLiteral(">Новини и събития</a>\r\n");
                EndContext();
#line 9 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
         if (ViewBag.category > 0)
        {
            

#line default
#line hidden
                BeginContext(363, 3, true);
                WriteLiteral(" / ");
                EndContext();
                BeginContext(367, 20, false);
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                Write(ViewBag.categoryName);

#line default
#line hidden
                EndContext();
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                                                 
        }

#line default
#line hidden
                BeginContext(407, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(422, 112, true);
            WriteLiteral("\r\n<div class=\"container-fluid information\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(534, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3651a2957a8947a48239247e8c797709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ("91023");

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(584, 132, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            <div id=\"gridview\"></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(733, 102, true);
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\'#gridview\').gridView({\r\n                url: \'");
                EndContext();
                BeginContext(837, 26, false);
#line 33 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                  Write(Url.Action("LoadDataGrid"));

#line default
#line hidden
                EndContext();
                BeginContext(864, 36, true);
                WriteLiteral("\',\r\n                data: {category:");
                EndContext();
                BeginContext(902, 16, false);
#line 34 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                            Write(ViewBag.category);

#line default
#line hidden
                EndContext();
                BeginContext(919, 446, true);
                WriteLiteral(@"},
                filter: true,
                template: '#articleTemplate',
                empty_text: 'Няма намерени елементи.'
            });
        });
    </script>
    <script type=""text/x-handlebars-template"" id=""articleTemplate"">
        <div class=""col-md-4 col-sm-6 col-xs-12"">
            <article class=""article--news image--left"">
                <a {{#if isRss}} href=""{{rssPostLink}}"" target=""_blank"" {{else}} href=""");
                EndContext();
                BeginContext(1366, 18, false);
#line 44 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                                                                                  Write(Url.Action("View"));

#line default
#line hidden
                EndContext();
                BeginContext(1384, 142, true);
                WriteLiteral("?id={{id}}\" {{/if}}>\r\n                    {{#if mainImageFileId}}\r\n                    <div class=\"image\">\r\n                        <img src=\"");
                EndContext();
                BeginContext(1527, 130, false);
#line 47 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                             Write(Html.Raw(Url.Action("ViewImage","FileCdn",new { area="",sourceType=GlobalConstants.SourceTypes.Library_ImagesThumbs})+"&sourceId"));

#line default
#line hidden
                EndContext();
                BeginContext(1657, 358, true);
                WriteLiteral(@"={{mainImageFileId}}"">
                    </div>
                    {{/if}}
                    <h4 class=""title"">
                        {{{title}}}
                    </h4>
                    <p class=""date"">{{eventDateTXT}}</p>
                </a>
                <p class=""type""><i class=""fa fa-folder"" title=""Категория""></i>&nbsp;<a href=""");
                EndContext();
                BeginContext(2016, 19, false);
#line 55 "C:\Projects\Strategy\newSingleSite\Domain\Views\Article\Index.cshtml"
                                                                                        Write(Url.Action("Index"));

#line default
#line hidden
                EndContext();
                BeginContext(2035, 174, true);
                WriteLiteral("?category={{categoryId}}\" title=\"Преглед на всички статии в категория: {{{categoryName}}}\">{{{categoryName}}}</a></p>\r\n            </article>\r\n        </div>\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591