#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54262170445e836fad8bd2765131277c5bc62c3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TargetGroups_EditTargetGroups), @"mvc.1.0.view", @"/Areas/Admin/Views/TargetGroups/EditTargetGroups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/TargetGroups/EditTargetGroups.cshtml", typeof(AspNetCore.Areas_Admin_Views_TargetGroups_EditTargetGroups))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54262170445e836fad8bd2765131277c5bc62c3d", @"/Areas/Admin/Views/TargetGroups/EditTargetGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec689d54487eca61e3f158b7f8d73212d01bdb46", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TargetGroups_EditTargetGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ViewModels.TargetGroupsModel.TargetGroupsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListTargetGroups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTargetGroups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
  
    ViewData["Title"] = "Целева група";

#line default
#line hidden
            BeginContext(116, 96, true);
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            ");
            EndContext();
            BeginContext(212, 1101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfc2acc800941599934838112498771", async() => {
                BeginContext(248, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(266, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ded410d5cae467f9939237cfb11c1ca", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(332, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(351, 25, false);
#line 12 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
                EndContext();
                BeginContext(376, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(395, 34, false);
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.DateCreated));

#line default
#line hidden
                EndContext();
                BeginContext(429, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(448, 33, false);
#line 14 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.IsApproved));

#line default
#line hidden
                EndContext();
                BeginContext(481, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(500, 33, false);
#line 15 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.LanguageId));

#line default
#line hidden
                EndContext();
                BeginContext(533, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(552, 38, false);
#line 16 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.CreatedByUserId));

#line default
#line hidden
                EndContext();
                BeginContext(590, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(609, 39, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.ModifiedByUserId));

#line default
#line hidden
                EndContext();
                BeginContext(648, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(667, 35, false);
#line 18 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.DateModified));

#line default
#line hidden
                EndContext();
                BeginContext(702, 20, true);
                WriteLiteral("\r\n\r\n                ");
                EndContext();
                BeginContext(723, 27, false);
#line 20 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(750, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(769, 31, false);
#line 21 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.EditorFor(m => m.IsActive));

#line default
#line hidden
                EndContext();
                BeginContext(800, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 23 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
                 if(Model.Id == 0)
                {
                

#line default
#line hidden
                BeginContext(876, 32, false);
#line 25 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.HiddenFor(m => m.IsDeleted));

#line default
#line hidden
                EndContext();
#line 25 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
                                                 
                }
                else
                {
                

#line default
#line hidden
                BeginContext(987, 32, false);
#line 29 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
           Write(Html.EditorFor(m => m.IsDeleted));

#line default
#line hidden
                EndContext();
#line 29 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\TargetGroups\EditTargetGroups.cshtml"
                                                 
                }

#line default
#line hidden
                BeginContext(1040, 154, true);
                WriteLiteral("                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Запис\" class=\"btn btn-success btn-flat\" />\r\n                    ");
                EndContext();
                BeginContext(1194, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11c3fbd0193c4c6491f915a38188ed0b", async() => {
                    BeginContext(1259, 5, true);
                    WriteLiteral("Назад");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1268, 38, true);
                WriteLiteral("\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1313, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ViewModels.TargetGroupsModel.TargetGroupsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591