#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69337728701fc2359535c60c04545505ce2fd8ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MasterPage_Menu), @"mvc.1.0.view", @"/Views/Shared/Components/MasterPage/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MasterPage/Menu.cshtml", typeof(AspNetCore.Views_Shared_Components_MasterPage_Menu))]
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
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Domain.Class;

#line default
#line hidden
#line 12 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69337728701fc2359535c60c04545505ce2fd8ed", @"/Views/Shared/Components/MasterPage/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MasterPage_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PageVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
            BeginContext(58, 70, true);
            WriteLiteral("    <div class=\"aside row\">\r\n        <div class=\"title\">\r\n            ");
            EndContext();
            BeginContext(129, 17, false);
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
       Write(ViewBag.menuTitle);

#line default
#line hidden
            EndContext();
            BeginContext(146, 54, true);
            WriteLiteral("\r\n        </div>\r\n        <ul class=\"list--default\">\r\n");
            EndContext();
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
             foreach (var item in Model)
            {
                var linkUrl = Url.Action("Preview", "Page", new { id = item.ContentId, url = item.Url });
                if (!string.IsNullOrEmpty(item.Action))
                {
                    linkUrl = Url.Action(item.Action, item.Controller, new { area = "" });

                }

#line default
#line hidden
            BeginContext(553, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 597, "\"", 622, 1);
#line 19 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
WriteAttributeValue("", 604, Html.Raw(linkUrl), 604, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(623, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(651, 10, false);
#line 20 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(661, 51, true);
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n");
            EndContext();
#line 23 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
            }

#line default
#line hidden
            BeginContext(727, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 26 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
}
else
{
    

#line default
#line hidden
#line 29 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\MasterPage\Menu.cshtml"
                                
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PageVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
