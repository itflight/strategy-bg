#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c325881e8decb824fa8a8009ef5e2cd48c5eedb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BannerWidget_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BannerWidget/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/BannerWidget/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_BannerWidget_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c325881e8decb824fa8a8009ef5e2cd48c5eedb7", @"/Views/Shared/Components/BannerWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BannerWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BannersListVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
 if (Model.Count() > 0)
{

    

#line default
#line hidden
#line 6 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
     foreach (var item in Model)
    {
        if (!string.IsNullOrEmpty(item.MainImageFileId))
        {

#line default
#line hidden
            BeginContext(177, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 191, "\"", 218, 1);
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
WriteAttributeValue("", 198, Html.Raw(item.Link), 198, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 219, "\"", 238, 1);
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
WriteAttributeValue("", 227, item.Label, 227, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(239, 39, true);
            WriteLiteral(" target=\"_blank\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 278, "\"", 375, 1);
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
WriteAttributeValue("", 284, Html.Raw(Url.Action("ViewImage", "FileCdn", new { area = "", id = item.MainImageFileId })), 284, 91, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 23, true);
            WriteLiteral(" />\r\n            </a>\r\n");
            EndContext();
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
        }
    }

#line default
#line hidden
#line 14 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\BannerWidget\Default.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BannersListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591