#pragma checksum "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5b3cb6955db319ffba85ebe4b84e8537fbbcb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StandartForms_index_StandartForm_1), @"mvc.1.0.view", @"/Views/StandartForms/index_StandartForm_1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StandartForms/index_StandartForm_1.cshtml", typeof(AspNetCore.Views_StandartForms_index_StandartForm_1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5b3cb6955db319ffba85ebe4b84e8537fbbcb4", @"/Views/StandartForms/index_StandartForm_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf1412ad68915763abac5573310d172851b2661", @"/Views/_ViewImports.cshtml")]
    public class Views_StandartForms_index_StandartForm_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ViewModels.StandartForms.StandartForm_1VM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index_StandartForm_1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportSF1ToPDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
  
    ViewData["Title"] = "Приложение № 1";
      ViewData["SectionTitle"] = "Оценка на въздействието ";

#line default
#line hidden
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("breadcrumbs", async() => {
                BeginContext(192, 45, true);
                WriteLiteral("\r\n    <div class=\"breadcrumbs\">\r\n        / <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 237, "\"", 271, 1);
#line 9 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
WriteAttributeValue("", 244, Url.Action("Index","Home"), 244, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(272, 25, true);
                WriteLiteral(">Начало</a>\r\n        / <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 297, "\"", 340, 1);
#line 10 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
WriteAttributeValue("", 304, Url.Action("Index","StandartForms"), 304, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(341, 65, true);
                WriteLiteral(">Електронни формуляри</a>\r\n        / Приложение № 1\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(409, 116, true);
            WriteLiteral("\r\n<section class=\"container-fluid information\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(526, 145, false);
#line 18 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
       Write(await Component.InvokeAsync("MasterPage", new { pageTypeId = GlobalConstants.PageTypes.OV, display = "menu", title = "Оценка на въздействието" }));

#line default
#line hidden
            EndContext();
            BeginContext(671, 107, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-9\">\r\n            <div style=\"padding: 10px\">\r\n                ");
            EndContext();
            BeginContext(778, 5879, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e505cc218e234ab2b456b1fbcd89456f", async() => {
                BeginContext(823, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(845, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d87c926bea473784214d60f87d575c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 23 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
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
                BeginContext(911, 651, true);
                WriteLiteral(@"
                    <h2>
                        <div align=""center"">
                            Приложение № 1
                        </div>
                    </h2>
                    <h3>
                        </br>
                        <div align=""center"">
                            към чл. 16 от Наредбата за обхвата и методологията за извършване на оценка на въздействието
                        </div>
                    </h3>
                    </br></br>
                    <table width=""100%"" border=""0"" cellpadding=""5"" cellspacing=""5"">
                        <tr>
                            <td width=""49%"">");
                EndContext();
                BeginContext(1563, 34, false);
#line 38 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.Institution));

#line default
#line hidden
                EndContext();
                BeginContext(1597, 107, true);
                WriteLiteral("</td>\r\n                            <td width=\"2%\">&nbsp;</td>\r\n                            <td width=\"49%\">");
                EndContext();
                BeginContext(1705, 32, false);
#line 40 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.Enactment));

#line default
#line hidden
                EndContext();
                BeginContext(1737, 112, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"49%\">");
                EndContext();
                BeginContext(1850, 29, false);
#line 43 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.Period));

#line default
#line hidden
                EndContext();
                BeginContext(1879, 108, true);
                WriteLiteral("</td>\r\n                            <td width=\"2%\">&nbsp;</td>\r\n                            <td width=\"49%\"> ");
                EndContext();
                BeginContext(1988, 32, false);
#line 45 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                        Write(Html.EditorFor(m => m.DateFirst));

#line default
#line hidden
                EndContext();
                BeginContext(2020, 112, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"49%\">");
                EndContext();
                BeginContext(2133, 30, false);
#line 48 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(2163, 108, true);
                WriteLiteral("</td>\r\n                            <td width=\"2%\">&nbsp;</td>\r\n                            <td width=\"49%\"> ");
                EndContext();
                BeginContext(2272, 28, false);
#line 50 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                        Write(Html.EditorFor(m => m.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(2300, 145, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                    <h3>1. Дефиниране на проблема:</h3>\r\n                    ");
                EndContext();
                BeginContext(2446, 27, false);
#line 54 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p1_1));

#line default
#line hidden
                EndContext();
                BeginContext(2473, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2496, 27, false);
#line 55 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p1_2));

#line default
#line hidden
                EndContext();
                BeginContext(2523, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2546, 27, false);
#line 56 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p1_3));

#line default
#line hidden
                EndContext();
                BeginContext(2573, 61, true);
                WriteLiteral("\r\n                    <h3>2. Цели:</h3>\r\n                    ");
                EndContext();
                BeginContext(2635, 25, false);
#line 58 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p2));

#line default
#line hidden
                EndContext();
                BeginContext(2660, 98, true);
                WriteLiteral("\r\n                    <h3>3. Идентифициране на заинтересованите страни:</h3>\r\n                    ");
                EndContext();
                BeginContext(2759, 25, false);
#line 60 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p3));

#line default
#line hidden
                EndContext();
                BeginContext(2784, 77, true);
                WriteLiteral("\r\n                    <h3>4. Варианти на действие:</h3>\r\n                    ");
                EndContext();
                BeginContext(2862, 25, false);
#line 62 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p4));

#line default
#line hidden
                EndContext();
                BeginContext(2887, 78, true);
                WriteLiteral("\r\n                    <h3>5. Негативни въздействия:</h3>\r\n                    ");
                EndContext();
                BeginContext(2966, 25, false);
#line 64 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p5));

#line default
#line hidden
                EndContext();
                BeginContext(2991, 80, true);
                WriteLiteral("\r\n                    <h3>6. Положителни въздействия:</h3>\r\n                    ");
                EndContext();
                BeginContext(3072, 25, false);
#line 66 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p6));

#line default
#line hidden
                EndContext();
                BeginContext(3097, 76, true);
                WriteLiteral("\r\n                    <h3>7. Потенциални рискове:</h3>\r\n                    ");
                EndContext();
                BeginContext(3174, 25, false);
#line 68 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p7));

#line default
#line hidden
                EndContext();
                BeginContext(3199, 677, true);
                WriteLiteral(@"
                    <h3>8. Административна тежест:</h3>
                    <div>
                        <b>8.1 Административната тежест за физическите и юридическите лица:</b><br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p8_1"" value=""1"" checked />&nbsp;&nbsp;&nbsp;Ще се повиши<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p8_1"" value=""2"" />&nbsp;&nbsp;&nbsp;Ще се намали<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p8_1"" value=""3"" />&nbsp;&nbsp;&nbsp;Няма ефект<br><br>
                    </div>
                    ");
                EndContext();
                BeginContext(3877, 27, false);
#line 76 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p8_2));

#line default
#line hidden
                EndContext();
                BeginContext(3904, 191, true);
                WriteLiteral("\r\n                    <h3>9. Създават ли се нови регистри?</h3>\r\n                    <br>\r\n                    <i>Когато отговорът е „да“, посочете колко и кои са те</i>\r\n                    ");
                EndContext();
                BeginContext(4096, 25, false);
#line 80 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p9));

#line default
#line hidden
                EndContext();
                BeginContext(4121, 1131, true);
                WriteLiteral(@"
                    <h3>10. Как въздейства актът върху микро-, малките и средните предприятия (МСП)?</h3>
                    <div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p10"" value=""1"" checked />&nbsp;&nbsp;&nbsp;Актът засяга пряко МСП<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p10"" value=""2"" />&nbsp;&nbsp;&nbsp;Актът не засяга МСП<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p10"" value=""3"" />&nbsp;&nbsp;&nbsp;Няма ефект<br><br>
                    </div>
                    <h3>11.  Проектът на нормативен акт изисква ли цялостна оценка на въздействието?</h3>
                    <div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p11"" value=""1"" checked />&nbsp;&nbsp;&nbsp;Да<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p11"" value=""2"" />&nbsp;&nbsp;&nbsp;Не<br><br>
");
                WriteLiteral("                    </div>\r\n                    <h3>12. Обществени консултации: </h3>\r\n                    ");
                EndContext();
                BeginContext(5253, 26, false);
#line 93 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p12));

#line default
#line hidden
                EndContext();
                BeginContext(5279, 464, true);
                WriteLiteral(@"
                    <h3>13. Приемането на нормативния акт произтича ли от правото на Европейския съюз?</h3>
                    <div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p13_1"" value=""1"" checked />&nbsp;&nbsp;&nbsp;Да<br><br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""radio"" name=""p13_1"" value=""2"" />&nbsp;&nbsp;&nbsp;Не<br><br>
                    </div>
                    ");
                EndContext();
                BeginContext(5744, 28, false);
#line 99 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
               Write(Html.EditorFor(m => m.p13_2));

#line default
#line hidden
                EndContext();
                BeginContext(5772, 299, true);
                WriteLiteral(@"
                    <h3>14. Име, длъжност, дата и подпис на директора на дирекцията, отговорна за изработването на нормативния акт:</h3>
                    <table width=""100%"" border=""0"" cellpadding=""5"" cellspacing=""5"">
                        <tr>
                            <td width=""49%"">");
                EndContext();
                BeginContext(6072, 31, false);
#line 103 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.NameRole));

#line default
#line hidden
                EndContext();
                BeginContext(6103, 107, true);
                WriteLiteral("</td>\r\n                            <td width=\"2%\">&nbsp;</td>\r\n                            <td width=\"49%\">");
                EndContext();
                BeginContext(6211, 30, false);
#line 105 "C:\Projects\Strategy\newSingleSite\Domain\Views\StandartForms\index_StandartForm_1.cshtml"
                                       Write(Html.EditorFor(m => m.DateEnd));

#line default
#line hidden
                EndContext();
                BeginContext(6241, 283, true);
                WriteLiteral(@"</td>
                        </tr>
                    </table>


                    <div class=""form-group"">
                        <input class=""btn btn-default btn-flat"" type=""submit"" value=""Печат PDF"" formaction=""/StandartForms/ExportSF1ToPDF"">
                        ");
                EndContext();
                BeginContext(6524, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109a1dea619340e18b5a803c15acaaa0", async() => {
                    BeginContext(6593, 7, true);
                    WriteLiteral("Изчисти");
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
                BeginContext(6604, 46, true);
                WriteLiteral("\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6657, 74, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6748, 913, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#btnPDF"").click(function () {
                $(""#form1"").submit(function () {
                    setTimeout('$(""#form2"").submit();', 10);
                    return false;
                });
            });
        });

        $(function () {
            $('.calculatorActivityId :input').attr(""disabled"", true);
        });

        $('#p1_1').summernote();
        $('#p1_2').summernote();
        $('#p1_3').summernote();
        $('#p2').summernote();
        $('#p3').summernote();
        $('#p4').summernote();
        $('#p5').summernote();
        $('#p6').summernote();
        $('#p7').summernote();
        $('#p8_2').summernote();
        $('#p9').summernote();
        $('#p11').summernote();
        $('#p12').summernote();
        $('#p13_2').summernote();
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ViewModels.StandartForms.StandartForm_1VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
