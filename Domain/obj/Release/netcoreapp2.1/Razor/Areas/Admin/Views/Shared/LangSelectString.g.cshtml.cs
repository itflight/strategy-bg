#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e199686e1ddbdab2a0fb7da1a96b2a19d61d94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_LangSelectString), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/LangSelectString.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/LangSelectString.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_LangSelectString))]
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
using Models;

#line default
#line hidden
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\_ViewImports.cshtml"
using Models.Context;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e199686e1ddbdab2a0fb7da1a96b2a19d61d94", @"/Areas/Admin/Views/Shared/LangSelectString.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec689d54487eca61e3f158b7f8d73212d01bdb46", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_LangSelectString : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
  
    string lang = Model;

#line default
#line hidden
            BeginContext(63, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(108, 45, true);
            WriteLiteral("        <input type=\"hidden\" name=\"lang\" />\r\n");
            EndContext();
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
         foreach (var item in GlobalConstants.SelectLangs())
        {
            var btnClass = "btn-default";
            if (item.Lang == lang)
            {
                btnClass = "btn-primary";
            }

#line default
#line hidden
            BeginContext(378, 23, true);
            WriteLiteral("            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 401, "\"", 429, 3);
            WriteAttributeValue("", 409, "submit", 409, 6, true);
            WriteAttributeValue(" ", 415, "btn", 416, 4, true);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
WriteAttributeValue(" ", 419, btnClass, 420, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(430, 12, true);
            WriteLiteral(" data-lang=\"");
            EndContext();
            BeginContext(443, 9, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
                                                           Write(item.Lang);

#line default
#line hidden
            EndContext();
            BeginContext(452, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 453, "\"", 490, 4);
            WriteAttributeValue("", 461, "Покажи", 461, 6, true);
            WriteAttributeValue(" ", 467, "данните", 468, 8, true);
            WriteAttributeValue(" ", 475, "на", 476, 3, true);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
WriteAttributeValue(" ", 478, item.Title, 479, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(491, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(493, 19, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
                                                                                                             Write(item.Lang.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(512, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 18 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
        }

#line default
#line hidden
#line 18 "C:\Projects\Strategy\newSingleSite\Domain\Areas\Admin\Views\Shared\LangSelectString.cshtml"
         
    }

#line default
#line hidden
            BeginContext(536, 253, true);
            WriteLiteral("    <br/>\r\n</div>\r\n<script>\r\n    $(function () {\r\n        $(\'a.submit\').click(function () {\r\n            var lang = $(this).data(\'lang\');\r\n            $(this).parents(\'form:first\').find(\'input[type=\"hidden\"]\').val(lang);\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591