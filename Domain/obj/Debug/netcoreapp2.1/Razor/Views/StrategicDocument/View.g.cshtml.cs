#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da879f823fb324c2b3b0cd31c1c3482d60cbe3a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StrategicDocument_View), @"mvc.1.0.view", @"/Views/StrategicDocument/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StrategicDocument/View.cshtml", typeof(AspNetCore.Views_StrategicDocument_View))]
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
#line 2 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
using Domain.Extensions;

#line default
#line hidden
#line 3 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
using Models.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da879f823fb324c2b3b0cd31c1c3482d60cbe3a8", @"/Views/StrategicDocument/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_StrategicDocument_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Context.Legacy.StrategicDocuments>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
  
    ViewData["SectionTitle"] = "Стратегически документи";
    var documents = (IQueryable<DocumentLinkVM>)ViewBag.documents;
    List<BreadcrumbVM> breadcrumb = ViewBag.Breadcrumb != null ? (List<BreadcrumbVM>)ViewBag.Breadcrumb : new List<BreadcrumbVM>();

#line default
#line hidden
            DefineSection("breadcrumbs", async() => {
                BeginContext(389, 33, true);
                WriteLiteral("\r\n    <div class=\"breadcrumbs\">\r\n");
                EndContext();
#line 11 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
         foreach (var item in breadcrumb)
        {

#line default
#line hidden
                BeginContext(476, 14, true);
                WriteLiteral("            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 490, "\"", 506, 1);
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
WriteAttributeValue("", 497, item.Url, 497, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(507, 3, true);
                WriteLiteral(">/ ");
                EndContext();
                BeginContext(511, 10, false);
#line 13 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
                             Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(521, 7, true);
                WriteLiteral(" </a>\r\n");
                EndContext();
#line 14 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
        }

#line default
#line hidden
                BeginContext(539, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(554, 143, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid information\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-9 body\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(698, 21, false);
#line 24 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
           Write(Html.Raw(Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(719, 68, true);
            WriteLiteral("\r\n            </h3>\r\n            <p class=\"title\">\r\n                ");
            EndContext();
            BeginContext(788, 23, false);
#line 27 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
           Write(Html.Raw(Model.Summary));

#line default
#line hidden
            EndContext();
            BeginContext(811, 431, true);
            WriteLiteral(@"
            </p>
            <!-- TABLE DATES -->
            <div class=""row"">
                <div class=""col-md-5"">
                    <table class=""table table-bordered table--dates table--stripped"">
                        <tbody>
                            <!-- LOOP -->
                            <tr>
                                <td>Документът е валиден до края :</td>
                                <td>");
            EndContext();
            BeginContext(1243, 27, false);
#line 37 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
                               Write(Model.ValidTo.ValidToText());

#line default
#line hidden
            EndContext();
            BeginContext(1270, 249, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <!-- END LOOP -->\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- END TABLE DATES -->\r\n            ");
            EndContext();
            BeginContext(1520, 129, false);
#line 46 "C:\Projects\Strategy\newSingleSite\Domain\Views\StrategicDocument\View.cshtml"
       Write(await Component.InvokeAsync("FileList", new { sourceType = GlobalConstants.SourceTypes.StrategicDocuments, sourceId = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 234, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"breadcrumbs\">\r\n    <button onclick=\"goBack()\">< Назад</button>\r\n</div>\r\n\r\n<script>\r\n    function goBack() {\r\n        window.history.back();\r\n    }\r\n</script>\r\n<!-- END COMMENTS -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Context.Legacy.StrategicDocuments> Html { get; private set; }
    }
}
#pragma warning restore 1591
