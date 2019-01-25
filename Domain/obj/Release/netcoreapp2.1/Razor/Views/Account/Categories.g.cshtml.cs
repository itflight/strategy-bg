#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb61fc7be2a3273078259ec5ddbd1e0883c3563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Categories), @"mvc.1.0.view", @"/Views/Account/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Categories.cshtml", typeof(AspNetCore.Views_Account_Categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb61fc7be2a3273078259ec5ddbd1e0883c3563", @"/Views/Account/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a9a60c20537480d66fd9d2d41d1eec08c8ef00", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDialog.cshtml";
    ViewData["Title"] = "Моите категории";

#line default
#line hidden
            BeginContext(104, 34, true);
            WriteLiteral("\r\n<h3 style=\"margin-bottom:20px;\">");
            EndContext();
            BeginContext(139, 17, false);
#line 6 "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(156, 193, true);
            WriteLiteral("</h3>\r\n<a href=\"#\" onclick=\"addCategory(); return false;\" class=\"btn btn-success\"><i class=\"fa fa-plus\"></i> Добави категория</a>\r\n<table id=\"mainTable\" class=\"table\" cellspacing=\"0\"></table>\r\n");
            EndContext();
            BeginContext(349, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3ca3629ef07447a989e6668699a5b7d", async() => {
                BeginContext(373, 7, true);
                WriteLiteral("Обратно");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(403, 148, true);
                WriteLiteral("\r\n    <script>\r\n    var dt = {};\r\n    $(function () {\r\n         dt  = $(\'#mainTable\').DataTable({\r\n             \"ajax\": {\r\n                 \"url\": \'");
                EndContext();
                BeginContext(552, 33, false);
#line 16 "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml"
                    Write(Url.Action("Categories_LoadData"));

#line default
#line hidden
                EndContext();
                BeginContext(585, 977, true);
                WriteLiteral(@"',
                 ""type"": ""POST""
             },
             fnDrawCallback: function (settings) {
                 $(this).parent().toggle(settings.fnRecordsDisplay() > 0);
             },
             ""columns"": [
                 {
                     data: ""categoryName"",
                     title: 'Наименование'
                 },
                 {
                     data: null,
                     ""render"": function (item) {

                         var btn = '<a href=""#"" onclick=""removeCategory('+item.categoryId+',\''+item.categoryName+'\');"" class=""btn btn-sm btn-danger pull-right"" title=""Премахни""><i class=""fa fa-remove""></i></a>';
                         return btn;
                     },
                     sortable: false
                 }
             ],
             filter: false,
             paging: false,
             ""bInfo"": false

        });

    });
    function addCategory() {
         var url = '");
                EndContext();
                BeginContext(1563, 38, false);
#line 45 "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml"
               Write(Url.Action("Categories_Add","Account"));

#line default
#line hidden
                EndContext();
                BeginContext(1601, 278, true);
                WriteLiteral(@"';
         ShowPlainDialogFromAction('Добави категория', url);
    }
        function removeCategory(catId,catName) {
            if (!confirm('Потвърдете премахването на категория: ' + catName)) {
                return false;
            }
            requestContent('");
                EndContext();
                BeginContext(1880, 42, false);
#line 52 "C:\Projects\Strategy\newSingleSite\Domain\Views\Account\Categories.cshtml"
                       Write(Url.Action("Categories_Remove", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(1922, 86, true);
                WriteLiteral("\', { categoryId: catId }, function () { dt.ajax.reload();});\r\n    }\r\n    </script>\r\n\r\n");
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