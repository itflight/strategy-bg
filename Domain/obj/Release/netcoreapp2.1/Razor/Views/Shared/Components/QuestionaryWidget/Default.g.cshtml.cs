#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d718900c634ed8ad75b08a6c60f18a593ad7a7a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_QuestionaryWidget_Default), @"mvc.1.0.view", @"/Views/Shared/Components/QuestionaryWidget/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/QuestionaryWidget/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_QuestionaryWidget_Default))]
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
#line 1 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
using Models.ViewModels.Questionary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d718900c634ed8ad75b08a6c60f18a593ad7a7a4", @"/Views/Shared/Components/QuestionaryWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_QuestionaryWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionaryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
            BeginContext(133, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 139, "\"", 243, 1);
#line 7 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
WriteAttributeValue("", 146, Url.Action("FillQuestionary","Questionary",new { area="",questionaryHeaderId=Model.Id,userId=0}), 146, 97, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 15, true);
            WriteLiteral(">\r\n        <h4>");
            EndContext();
            BeginContext(260, 11, false);
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(271, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(290, 27, false);
#line 9 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
      Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(317, 16, true);
            WriteLiteral("</p>\r\n    </a>\r\n");
            EndContext();
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\Components\QuestionaryWidget\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionaryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
