#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2006ce9255aa9d4a5dec4f0ee095c76395cbf9bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexOldWithPeshka), @"mvc.1.0.view", @"/Views/Home/IndexOldWithPeshka.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexOldWithPeshka.cshtml", typeof(AspNetCore.Views_Home_IndexOldWithPeshka))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2006ce9255aa9d4a5dec4f0ee095c76395cbf9bd", @"/Views/Home/IndexOldWithPeshka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexOldWithPeshka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
  
    Layout = "~/Views/Shared/_LayoutPublicMain.cshtml";

#line default
#line hidden
            DefineSection("head", async() => {
                BeginContext(131, 124, true);
                WriteLiteral("\r\n    <style>\r\n        .section .image img {\r\n            width: auto;\r\n            height: auto;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(258, 18, true);
            WriteLiteral("<!-- IMAGES  -->\r\n");
            EndContext();
            BeginContext(1939, 172, true);
            WriteLiteral("<!-- END IMAGES  -->\r\n\r\n\r\n<section class=\"section__wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"section col-lg-3 col-md-6 col-sm-12\">\r\n            <p class=\"type\">");
            EndContext();
            BeginContext(2112, 31, false);
#line 57 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                       Write(Localizer["SECTION_ASSESSMENT"]);

#line default
#line hidden
            EndContext();
            BeginContext(2143, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(2162, 92, false);
#line 58 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
       Write(await Component.InvokeAsync("MasterPage", new { pageTypeId = GlobalConstants.PageTypes.OV }));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 30, true);
            WriteLiteral("\r\n            <p class=\"type\">");
            EndContext();
            BeginContext(2285, 36, false);
#line 59 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                       Write(Localizer["SECTION_OTHER_RESOURCES"]);

#line default
#line hidden
            EndContext();
            BeginContext(2321, 43, true);
            WriteLiteral("</p>\r\n            <div>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2364, "\"", 2433, 1);
#line 61 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
WriteAttributeValue("", 2371, Url.Action("ListPCSubjects", "PCSubjects", new { area = "" }), 2371, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2434, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2436, 36, false);
#line 61 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                                                                                    Write(Localizer["SECTION_LINK_ZNA_PEOPLE"]);

#line default
#line hidden
            EndContext();
            BeginContext(2472, 63, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2535, "\"", 2614, 1);
#line 64 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
WriteAttributeValue("", 2542, Url.Action("ListChangeProposals", "ChangeProposals", new { area = "" }), 2542, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2615, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2617, 39, false);
#line 64 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                                                                                              Write(Localizer["SECTION_LINK_LAW_PROPOSALS"]);

#line default
#line hidden
            EndContext();
            BeginContext(2656, 129, true);
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n        <div class=\"section col-lg-3 col-md-6 col-sm-12\">\r\n            <p class=\"type\">");
            EndContext();
            BeginContext(2786, 38, false);
#line 68 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                       Write(Localizer["MENU_PUBLIC_CONSULTATIONS"]);

#line default
#line hidden
            EndContext();
            BeginContext(2824, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(2843, 78, false);
#line 69 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
       Write(await Component.InvokeAsync("PublicConsultationWidget", new { loadCount = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 105, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"section col-lg-3 col-md-6 col-sm-12\">\r\n            <p class=\"type\">");
            EndContext();
            BeginContext(3027, 37, false);
#line 72 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                       Write(Localizer["MENU_STRATEGIC_DOCUMENTS"]);

#line default
#line hidden
            EndContext();
            BeginContext(3064, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(3083, 78, false);
#line 73 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
       Write(await Component.InvokeAsync("StrategicDocumentsWidget", new { loadCount = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(3161, 270, true);
            WriteLiteral(@"
        </div>
        <div class=""section col-lg-3 col-md-6 col-sm-12"" style=""vertical-align:top;"">
            <ul class=""nav nav-tabs"" style=""margin-top: -10px;"">
                <li class=""active""><a href=""#tabNews"" role=""tab"" data-toggle=""tab""><p class=""type"">");
            EndContext();
            BeginContext(3433, 22, false);
#line 77 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                                                                                               Write(Localizer["MENU_NEWS"]);

#line default
#line hidden
            EndContext();
            BeginContext(3456, 107, true);
            WriteLiteral("</p></a></li>\r\n                <li><a href=\"#tabPublications\" role=\"tab\" data-toggle=\"tab\"><p class=\"type\">");
            EndContext();
            BeginContext(3565, 30, false);
#line 78 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
                                                                                        Write(Localizer["MENU_PUBLICATIONS"]);

#line default
#line hidden
            EndContext();
            BeginContext(3596, 154, true);
            WriteLiteral("</p></a></li>\r\n            </ul>\r\n            <div class=\"tab-content\" >\r\n                <div id=\"tabNews\" class=\"tab-pane active\">\r\n                    ");
            EndContext();
            BeginContext(3751, 82, false);
#line 82 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
               Write(await Component.InvokeAsync("ArticleWidget", new { view = "News", loadCount = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(3833, 107, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"tabPublications\" class=\"tab-pane\">\r\n                    ");
            EndContext();
            BeginContext(3941, 89, false);
#line 85 "C:\Projects\Strategy\newSingleSite\Domain\Views\Home\IndexOldWithPeshka.cshtml"
               Write(await Component.InvokeAsync("ArticleWidget", new { view = "Publication", loadCount = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 90, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            EndContext();
            BeginContext(6090, 60, true);
            WriteLiteral("\r\n<div class=\"spacer\"></div>\r\n<!-- END ARTICLES & NEWS -->\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<CommonResources> Localizer { get; private set; }
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
