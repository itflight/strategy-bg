#pragma checksum "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5331f4f7f5aa4e77b0489f39b3b527a55b9dbd74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Forums_Views_Forum_PostItem), @"mvc.1.0.view", @"/Areas/Forums/Views/Forum/PostItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Forums/Views/Forum/PostItem.cshtml", typeof(AspNetCore.Areas_Forums_Views_Forum_PostItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5331f4f7f5aa4e77b0489f39b3b527a55b9dbd74", @"/Areas/Forums/Views/Forum/PostItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5ec50b492d0ac5f784d62580bff0edbd26d79a", @"/Areas/Forums/Views/_ViewImports.cshtml")]
    public class Areas_Forums_Views_Forum_PostItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostItemContainer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UndeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Moderator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deletePostForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
  
	string deleteLink;
	if (Model.Post.IsDeleted)
	{deleteLink = PopForums.Resources.Undelete;}
	else if (Model.Post.IsFirstInTopic)
	{deleteLink = PopForums.Resources.DeleteTopic;}
	else
	{deleteLink = PopForums.Resources.Delete;}

#line default
#line hidden
            BeginContext(312, 52, true);
            WriteLiteral("<table class=\"table dataTable no-footer\"><tr><td>\n<a");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 364, "\"", 389, 1);
#line 13 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 371, Model.Post.PostID, 371, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(390, 10, true);
            WriteLiteral("></a>\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 400, "\"", 459, 2);
#line 14 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 408, Model.Post.IsDeleted ? "bg-danger " : "", 408, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 451, "postItem", 451, 8, true);
            EndWriteAttribute();
            BeginContext(460, 14, true);
            WriteLiteral(" data-postid=\"");
            EndContext();
            BeginContext(475, 17, false);
#line 14 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                         Write(Model.Post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(492, 15, true);
            WriteLiteral("\" data-userid=\"");
            EndContext();
            BeginContext(508, 17, false);
#line 14 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                          Write(Model.Post.UserID);

#line default
#line hidden
            EndContext();
            BeginContext(525, 34, true);
            WriteLiteral("\">\n    <div class=\"information\">\r\n");
            EndContext();
            BeginContext(621, 30, true);
            WriteLiteral("        <div class=\"body\"><b> ");
            EndContext();
            BeginContext(651, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9bf4b16ba344de181a78926815e14d7", async() => {
                BeginContext(733, 15, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                          Write(Model.Post.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                               WriteLiteral(Model.Post.UserID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(752, 161, true);
            WriteLiteral("</b></div>\r\n        <div class=\"miniProfileBox bg-info text-info\"></div>\r\n        <small class=\"postTime text-right\">\r\n            <span class=\"fTime\" data-utc=\"");
            EndContext();
            BeginContext(914, 33, false);
#line 20 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                     Write(Model.Post.PostTime.ToString("o"));

#line default
#line hidden
            EndContext();
            BeginContext(947, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(950, 74, false);
#line 20 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                         Write(TimeFormattingService.GetFormattedTime(Model.Post.PostTime, Model.Profile));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 38, true);
            WriteLiteral("</span>\r\n        </small>\r\n    </div>\n");
            EndContext();
#line 23 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
     if (Model.Profile != null && !Model.Profile.HideVanity && (Model.Avatars).ContainsKey(Model.Post.UserID))
	{

#line default
#line hidden
            BeginContext(1173, 6, true);
            WriteLiteral("\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1179, "\"", 1262, 1);
#line 25 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 1185, Url.Action("Avatar", "Image", new {id = (Model.Avatars)[Model.Post.UserID]}), 1185, 77, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1263, "\"", 1332, 1);
#line 25 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 1269, String.Format(PopForums.Resources.NameAvatar, Model.Post.Name), 1269, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1333, 30, true);
            WriteLiteral(" class=\"avatar pull-right\" />\n");
            EndContext();
#line 26 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
	}

#line default
#line hidden
            BeginContext(1366, 2, true);
            WriteLiteral("\n\t");
            EndContext();
            BeginContext(1369, 29, false);
#line 28 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
Write(Html.Raw(Model.Post.FullText));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 29 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
     if (Model.Post.IsEdited && Model.Post.LastEditTime.HasValue)
	{

#line default
#line hidden
            BeginContext(1465, 9, true);
            WriteLiteral("\t\t<small>");
            EndContext();
            BeginContext(1475, 72, false);
#line 31 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
          Write(String.Format(PopForums.Resources.NameLastEdit, Model.Post.LastEditName));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 32, true);
            WriteLiteral(", <span class=\"fTime\" data-utc=\"");
            EndContext();
            BeginContext(1580, 43, false);
#line 31 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                                   Write(Model.Post.LastEditTime.Value.ToString("o"));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1626, 84, false);
#line 31 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                                                                                 Write(TimeFormattingService.GetFormattedTime(Model.Post.LastEditTime.Value, Model.Profile));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 16, true);
            WriteLiteral("</span></small>\n");
            EndContext();
#line 32 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
	}

#line default
#line hidden
            BeginContext(1729, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 34 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
     if (Model.Post.ShowSig && Model.Profile != null && !Model.Profile.HideVanity && (Model.Signatures).ContainsKey(Model.Post.UserID))
	{

#line default
#line hidden
            BeginContext(1866, 34, true);
            WriteLiteral("\t\t<hr />\n\t\t<div class=\"signature\">");
            EndContext();
            BeginContext(1901, 47, false);
#line 37 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                          Write(Html.Raw((Model.Signatures)[Model.Post.UserID]));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 38 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
	}

#line default
#line hidden
            BeginContext(1958, 70, true);
            WriteLiteral("\t<div class=\"postToolContainer\">\n\t\t<ul class=\"postTools list-inline\">\n");
            EndContext();
#line 41 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
             if (Model.User.IsPostEditable(Model.Post))
			{

#line default
#line hidden
            BeginContext(2080, 8, true);
            WriteLiteral("\t\t\t\t<li>");
            EndContext();
            BeginContext(2089, 96, false);
#line 43 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
               Write(Html.ActionLink(PopForums.Resources.Edit, "Edit", "Forum", new { id = Model.Post.PostID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 44 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
				if (Model.Post.IsDeleted)
				{

#line default
#line hidden
            BeginContext(2227, 16, true);
            WriteLiteral("\t\t\t\t\t<li>\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2243, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d9b455292445faa43f547ea3326a11", async() => {
                BeginContext(2383, 20, true);
                WriteLiteral("<input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2403, "\"", 2440, 1);
#line 47 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 2411, PopForums.Resources.Undelete, 2411, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2441, 20, true);
                WriteLiteral(" class=\"btn-link\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 47 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = false;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                             WriteLiteral(Model.Post.PostID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2468, 12, true);
            WriteLiteral("\n\t\t\t\t\t</li>\n");
            EndContext();
#line 49 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(2501, 16, true);
            WriteLiteral("\t\t\t\t\t<li>\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2517, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d2f9217cdc341f7b008957d7dd6cf25", async() => {
                BeginContext(2651, 20, true);
                WriteLiteral("<input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2671, "\"", 2690, 1);
#line 53 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 2679, deleteLink, 2679, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2691, 20, true);
                WriteLiteral(" class=\"btn-link\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 53 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = false;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                                                                                       WriteLiteral(Model.Post.PostID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2718, 12, true);
            WriteLiteral("\n\t\t\t\t\t</li>\n");
            EndContext();
#line 55 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
				}
			}

#line default
#line hidden
            BeginContext(2741, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 57 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
             if (Model.Post.IsEdited && Model.User != null && Model.User.IsInRole(PermanentRoles.Moderator))
			{

#line default
#line hidden
            BeginContext(2846, 28, true);
            WriteLiteral("\t\t\t\t<li><input data-postid=\"");
            EndContext();
            BeginContext(2875, 17, false);
#line 59 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
                                   Write(Model.Post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(2892, 49, true);
            WriteLiteral("\" class=\"btn-link postModLogButton\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2941, "\"", 2983, 1);
#line 59 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
WriteAttributeValue("", 2949, PopForums.Resources.ModerationLog, 2949, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2984, 9, true);
            WriteLiteral(" /></li>\n");
            EndContext();
#line 60 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Forum\PostItem.cshtml"
			}

#line default
#line hidden
            BeginContext(2998, 77, true);
            WriteLiteral("\t\t</ul>\n\t\t<div class=\"moderationLog\"></div>\n\t</div>\n</div>\n</td></tr></table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITimeFormattingService TimeFormattingService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostItemContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
