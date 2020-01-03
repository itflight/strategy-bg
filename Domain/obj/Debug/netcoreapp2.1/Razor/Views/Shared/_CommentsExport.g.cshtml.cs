#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb968f730c3a63342990bec41401f6fa67e6e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentsExport), @"mvc.1.0.view", @"/Views/Shared/_CommentsExport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentsExport.cshtml", typeof(AspNetCore.Views_Shared__CommentsExport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb968f730c3a63342990bec41401f6fa67e6e1a", @"/Views/Shared/_CommentsExport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentsExport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ViewModels.Consultations.CommentsExportVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
  Layout = "~/Views/Shared/_ExportLayout.cshtml";

#line default
#line hidden
            BeginContext(111, 89, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-5 col-lg-6 body\">\r\n        <h2>\r\n            ");
            EndContext();
            BeginContext(201, 33, false);
#line 8 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
       Write(Html.Raw(Model.ConsultationTitle));

#line default
#line hidden
            EndContext();
            BeginContext(234, 45, true);
            WriteLiteral("\r\n        </h2>\r\n\r\n        <h3>\r\n            ");
            EndContext();
            BeginContext(280, 23, false);
#line 12 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
       Write(Html.Raw(Model.Summary));

#line default
#line hidden
            EndContext();
            BeginContext(303, 79, true);
            WriteLiteral("\r\n        </h3>\r\n\r\n        <div class=\"row  comments\" id=\"commentsContainer\">\r\n");
            EndContext();
#line 16 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
             if (Model.Comments.Any())
            {

#line default
#line hidden
            BeginContext(437, 129, true);
            WriteLiteral("                <div class=\"col-md-12 comment\">\r\n                    <div class=\"title\">Коментари</div>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                 foreach (var item in Model.Comments)
                {

#line default
#line hidden
            BeginContext(640, 81, true);
            WriteLiteral("                    <div class=\"col-md-12 comment\">\r\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 721, "\"", 787, 2);
            WriteAttributeValue("", 729, "panel", 729, 5, true);
#line 24 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
WriteAttributeValue(" ", 734, item.TookIntoConsideration ? "panel-success" : "", 735, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(788, 116, true);
            WriteLiteral(">\r\n                            <div class=\"panel-heading\">\r\n                                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(905, 10, false);
#line 26 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(915, 43, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n");
            EndContext();
#line 28 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                             if (!String.IsNullOrEmpty(item.PageTag))
                            {

#line default
#line hidden
            BeginContext(1060, 115, true);
            WriteLiteral("                                <div class=\"panel-body\">\r\n                                    <strong>Към</strong> ");
            EndContext();
            BeginContext(1176, 12, false);
#line 31 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                                    Write(item.PageTag);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 33 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                            }

#line default
#line hidden
            BeginContext(1261, 54, true);
            WriteLiteral("\r\n                            <div class=\"panel-body\">");
            EndContext();
            BeginContext(1316, 19, false);
#line 35 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                               Write(Html.Raw(item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 36 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                             if (!String.IsNullOrEmpty(item.TookIntoConsiderationReason))
                            {

#line default
#line hidden
            BeginContext(1465, 98, true);
            WriteLiteral("                                <div class=\"panel-body\">\r\n                                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1563, "\"", 1633, 1);
#line 39 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
WriteAttributeValue("", 1571, item.TookIntoConsideration ? "text-success" : "text-danger", 1571, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1634, 53, true);
            WriteLiteral(">\r\n                                        Коментара ");
            EndContext();
            BeginContext(1689, 41, false);
#line 40 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                              Write(item.TookIntoConsideration ? "е" : "не е");

#line default
#line hidden
            EndContext();
            BeginContext(1731, 147, true);
            WriteLiteral(" взет под внимание <i class=\"fa fa-arrow-circle-o-down\"></i>\r\n                                    </div>\r\n                                    <div>");
            EndContext();
            BeginContext(1879, 32, false);
#line 42 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                    Write(item.TookIntoConsiderationReason);

#line default
#line hidden
            EndContext();
            BeginContext(1911, 48, true);
            WriteLiteral("</div>\r\n                                </div>\r\n");
            EndContext();
#line 44 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                            }

#line default
#line hidden
            BeginContext(1990, 107, true);
            WriteLiteral("                            <div class=\"panel-footer\">\r\n                                <span class=\"name\">");
            EndContext();
            BeginContext(2098, 13, false);
#line 46 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                              Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(2120, 44, false);
#line 46 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                                                                    Write(item.Publish.ToString("dd.MM.yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 50 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                }

#line default
#line hidden
#line 50 "C:\Projects\Strategy\newSingleSite\Domain\Views\Shared\_CommentsExport.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(2298, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ViewModels.Consultations.CommentsExportVM> Html { get; private set; }
    }
}
#pragma warning restore 1591