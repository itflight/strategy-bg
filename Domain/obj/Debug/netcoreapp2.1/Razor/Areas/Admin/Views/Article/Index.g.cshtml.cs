#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df03f86b3fdc2d27912d3795147bc9a0dc033fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Article_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Article/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Article/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Article_Index))]
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models.ViewModels.Account;

#line default
#line hidden
#line 5 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models.Context.Account;

#line default
#line hidden
#line 6 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using WebCommon.TagHelpers;

#line default
#line hidden
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models.Context;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df03f86b3fdc2d27912d3795147bc9a0dc033fb2", @"/Areas/Admin/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec689d54487eca61e3f158b7f8d73212d01bdb46", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
  
    ViewData["Title"] = "Новини и събития \"Партньорство за открито управление\"";

#line default
#line hidden
            BeginContext(91, 33, true);
            WriteLiteral("<section class=\"content\">\r\n\r\n    ");
            EndContext();
            BeginContext(124, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "070ea8f916f2495cb0b6f0c80175059d", async() => {
                BeginContext(177, 40, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Добави новина");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(221, 184, true);
            WriteLiteral("\r\n\r\n    <div class=\"search-form\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div>\r\n                    <span>Дата от</span>\r\n                    ");
            EndContext();
            BeginContext(406, 75, false);
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
               Write(Html.TextBox("dateFrom", null, new { @class = "form-control date-picker" }));

#line default
#line hidden
            EndContext();
            BeginContext(481, 111, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <span>Дата до</span>\r\n                    ");
            EndContext();
            BeginContext(593, 73, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
               Write(Html.TextBox("dateTo", null, new { @class = "form-control date-picker" }));

#line default
#line hidden
            EndContext();
            BeginContext(666, 112, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <span>Заглавие</span>\r\n                    ");
            EndContext();
            BeginContext(779, 59, false);
#line 21 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
               Write(Html.TextBox("term", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(838, 348, true);
            WriteLiteral(@"
                </div>
                <div>
                    <span>&nbsp;</span>
                    <button type=""button"" class=""btn btn-primary dt-reload""><i class=""fa fa-search""></i> Търсене</button>
                </div>
            </div>
        </div>
    </div>

    <div id=""gridview"" class=""news-list""></div>
</section>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1203, 296, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $('button.dt-reload').click(function () {
                LoadData();
                return false;
            }).trigger('click');
        });
        function LoadData() {
             $('#gridview').gridView({
                url: '");
                EndContext();
                BeginContext(1501, 26, false);
#line 43 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
                  Write(Url.Action("LoadDataGrid"));

#line default
#line hidden
                EndContext();
                BeginContext(1528, 518, true);
                WriteLiteral(@"',
                data: { dateFrom: $('#dateFrom').val(), dateTo: $('#dateTo').val(), term: $('#term').val()},
                 filter: false,
                 size_selector: false,
                template: '#listTemplate',
                empty_text: 'Няма намерени елементи.'
            });
        }
    </script>
    <script type=""text/x-handlebars-template"" id=""listTemplate"">
        <div class=""col-md-4 col-sm-6"">
            <article class=""article--news image--left"">
                <a href=""");
                EndContext();
                BeginContext(2047, 18, false);
#line 55 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
                    Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(2065, 153, true);
                WriteLiteral("?id={{id}}\" title=\"Редакция\">\r\n                    {{#if mainImageFileId}}\r\n\r\n                    <div class=\"image\">\r\n                        <img src=\"");
                EndContext();
                BeginContext(2219, 126, false);
#line 59 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Article\Index.cshtml"
                             Write(Html.Raw(Url.Action("ViewImage","FileCdn",new { area="",sourceType=GlobalConstants.SourceTypes.Library_ImagesThumbs, max=75})));

#line default
#line hidden
                EndContext();
                BeginContext(2345, 495, true);
                WriteLiteral(@"&sourceId={{mainImageFileId}}"">
                    </div>
                    {{/if}}
                    <h4 class=""title"">
                        {{{title}}}
                    </h4>
                    <p class=""type"">
                        {{{categoryName}}}
                    </p>
                    <p class=""date"">{{eventDateTXT}}</p>
                    <p class=""date"">{{eventDateTXT}}</p>
                </a>
            </article>
        </div>
    </script>
");
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
