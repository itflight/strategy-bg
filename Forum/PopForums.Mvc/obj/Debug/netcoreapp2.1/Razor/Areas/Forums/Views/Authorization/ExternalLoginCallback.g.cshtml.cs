#pragma checksum "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018843f22dedcd11d8d47b608e2bec4813f51b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Forums_Views_Authorization_ExternalLoginCallback), @"mvc.1.0.view", @"/Areas/Forums/Views/Authorization/ExternalLoginCallback.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Forums/Views/Authorization/ExternalLoginCallback.cshtml", typeof(AspNetCore.Areas_Forums_Views_Authorization_ExternalLoginCallback))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 7 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Extensions;

#line default
#line hidden
#line 2 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Models;

#line default
#line hidden
#line 3 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Services;

#line default
#line hidden
#line 4 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Mvc.Areas.Forums.Controllers;

#line default
#line hidden
#line 5 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Mvc.Areas.Forums.Models;

#line default
#line hidden
#line 6 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\_ViewImports.cshtml"
using PopForums.Mvc.Areas.Forums.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018843f22dedcd11d8d47b608e2bec4813f51b19", @"/Areas/Forums/Views/Authorization/ExternalLoginCallback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5ec50b492d0ac5f784d62580bff0edbd26d79a", @"/Areas/Forums/Views/_ViewImports.cshtml")]
    public class Areas_Forums_Views_Authorization_ExternalLoginCallback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
  
	ViewBag.Title = @PopForums.Resources.Login;
    Layout = "~/Areas/Forums/Views/Shared/PopForumsMaster.cshtml";

#line default
#line hidden
            BeginContext(117, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("HeaderContent", async() => {
                BeginContext(142, 268, true);
                WriteLiteral(@"
	<script language=""javascript"" type=""text/javascript"">
		$(function () {
			$(""#LoginButton"").click(PopForums.processLoginExternal);
			$(""#EmailLogin,#PasswordLogin"").keydown(function (e) { if (e.keyCode == 13) PopForums.processLoginExternal(); });
		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(412, 24, true);
            WriteLiteral("\n<div class=\"row\">\n\t<h1>");
            EndContext();
            BeginContext(437, 25, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
   Write(PopForums.Resources.Login);

#line default
#line hidden
            EndContext();
            BeginContext(462, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(466, 34, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                Write(PopForums.Resources.ExternalLogins);

#line default
#line hidden
            EndContext();
            BeginContext(500, 109, true);
            WriteLiteral("</h1>\n\t<ul id=\"TopBreadcrumb\" class=\"breadcrumb\">\n\t\t<li><span class=\"glyphicon glyphicon-chevron-up\"></span> ");
            EndContext();
            BeginContext(609, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65bee8eb58574644876f23f975d02a18", async() => {
                BeginContext(670, 26, false);
#line 19 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                                                                                                        Write(PopForums.Resources.Forums);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 19 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                                                        WriteLiteral(HomeController.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(700, 69, true);
            WriteLiteral("</li>\n\t</ul>\n</div>\n\n<div class=\"row\">\n\t<div class=\"col-xs-6\">\n\t\t<h2>");
            EndContext();
            BeginContext(769, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91ecd7098fa4b7f9fa315e3fba5476a", async() => {
                BeginContext(818, 35, false);
#line 25 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                                       Write(PopForums.Resources.CreateAnAccount);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(857, 44, true);
            WriteLiteral("</h2>\n\t</div>\n\t<div class=\"col-xs-6\">\n\t\t<h2>");
            EndContext();
            BeginContext(902, 43, false);
#line 28 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
       Write(PopForums.Resources.UseExistingForumAccount);

#line default
#line hidden
            EndContext();
            BeginContext(945, 144, true);
            WriteLiteral("</h2>\n\t\t<div id=\"LoginResult\" class=\"bg-danger callout hide\"></div>\n\t\t<div role=\"form\">\n\t\t\t<div class=\"form-group\">\n\t\t\t\t<label for=\"EmailLogin\">");
            EndContext();
            BeginContext(1090, 25, false);
#line 32 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                   Write(PopForums.Resources.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 158, true);
            WriteLiteral("</label>\n\t\t\t\t<input type=\"text\" name=\"EmailLogin\" id=\"EmailLogin\" class=\"form-control\"/>\n\t\t\t</div>\n\t\t\t<div class=\"form-group\">\n\t\t\t\t<label for=\"PasswordLogin\">");
            EndContext();
            BeginContext(1274, 28, false);
#line 36 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
                                      Write(PopForums.Resources.Password);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 150, true);
            WriteLiteral("</label>\n\t\t\t\t<input type=\"password\" name=\"PasswordLogin\" id=\"PasswordLogin\" class=\"form-control\" />\n\t\t\t</div>\n\t\t\t<input id=\"LoginButton\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1452, "\"", 1486, 1);
#line 39 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
WriteAttributeValue("", 1460, PopForums.Resources.Login, 1460, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1487, 89, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n\t\t</div>\n\t\t<input type=\"hidden\" name=\"Referrer\" id=\"Referrer\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1576, "\"", 1611, 1);
#line 41 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Authorization\ExternalLoginCallback.cshtml"
WriteAttributeValue("", 1584, (object)ViewBag.Referrer, 1584, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1612, 19, true);
            WriteLiteral(" />\n\t</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591