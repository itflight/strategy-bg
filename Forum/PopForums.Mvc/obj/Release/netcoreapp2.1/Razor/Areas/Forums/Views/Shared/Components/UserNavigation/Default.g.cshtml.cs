#pragma checksum "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c255ef79751d622b5d41f9d01c04ac04945c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Forums_Views_Shared_Components_UserNavigation_Default), @"mvc.1.0.view", @"/Areas/Forums/Views/Shared/Components/UserNavigation/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Forums/Views/Shared/Components/UserNavigation/Default.cshtml", typeof(AspNetCore.Areas_Forums_Views_Shared_Components_UserNavigation_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c255ef79751d622b5d41f9d01c04ac04945c87", @"/Areas/Forums/Views/Shared/Components/UserNavigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5ec50b492d0ac5f784d62580bff0edbd26d79a", @"/Areas/Forums/Views/_ViewImports.cshtml")]
    public class Areas_Forums_Views_Shared_Components_UserNavigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserNavigationContainer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
 if (Model.User == null)
{

#line default
#line hidden
            BeginContext(59, 5, true);
            WriteLiteral("\t<li>");
            EndContext();
            BeginContext(65, 111, false);
#line 5 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
   Write(Html.ActionLink(PopForums.Resources.CreateAnAccount, "Create", AccountController.Name, new { Area = "Forums" }));

#line default
#line hidden
            EndContext();
            BeginContext(176, 11, true);
            WriteLiteral("</li>\n\t<li>");
            EndContext();
            BeginContext(188, 100, false);
#line 6 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
   Write(Html.ActionLink(PopForums.Resources.Login, "Login", AccountController.Name, new { Area = "Forums" }));

#line default
#line hidden
            EndContext();
            BeginContext(288, 11, true);
            WriteLiteral("</li>\n\t<li>");
            EndContext();
            BeginContext(300, 116, false);
#line 7 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
   Write(Html.ActionLink(PopForums.Resources.Recent, "Recent", ForumController.Name, new { page = 1, Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(416, 11, true);
            WriteLiteral("</li>\n\t<li>");
            EndContext();
            BeginContext(428, 79, false);
#line 8 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
   Write(Html.ActionLink(PopForums.Resources.ActivityFeed, "Index", FeedController.Name));

#line default
#line hidden
            EndContext();
            BeginContext(507, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 9 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(522, 84, true);
            WriteLiteral("\t<li class=\"dropdown\">\n\t\t<a class=\"dropdown-toggle\" data-toggle=\"dropdown\" href=\"#\">");
            EndContext();
            BeginContext(607, 15, false);
#line 13 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
                                                              Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(622, 81, true);
            WriteLiteral(" <span class=\"caret\"></span></a>\n\t\t<ul class=\"dropdown-menu\" role=\"menu\">\n\t\t\t<li>");
            EndContext();
            BeginContext(704, 138, false);
#line 15 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.Profile, "ViewProfile", AccountController.Name, new { id = Model.User.UserID, Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(842, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(856, 130, false);
#line 16 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.Subscriptions, "Topics", SubscriptionController.Name, new { page = 1, Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(986, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1000, 123, false);
#line 17 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.Favorites, "Topics", FavoritesController.Name, new { page = 1, Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 42, true);
            WriteLiteral("</li>\n\t\t\t<li class=\"divider\"></li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1166, 118, false);
#line 19 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.EditProfile, "EditProfile", AccountController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1298, 127, false);
#line 20 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.ChangeYourEmailPassword, "Security", AccountController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1439, 124, false);
#line 21 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.ManageYourPhotos, "ManagePhotos", AccountController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1577, 124, false);
#line 22 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.ExternalLogins, "ExternalLogins", AccountController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 23 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
             if (Model.User.IsInRole(PermanentRoles.Admin))
			{

#line default
#line hidden
            BeginContext(1763, 43, true);
            WriteLiteral("\t\t\t\t<li class=\"divider\"></li>\n\t\t\t\t\t\t\t\t\t<li>");
            EndContext();
            BeginContext(1807, 82, false);
#line 26 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
                                   Write(Html.ActionLink(PopForums.Resources.PopForumsAdmin, "Index", AdminController.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 27 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
			}

#line default
#line hidden
            BeginContext(1900, 36, true);
            WriteLiteral("\t\t\t<li class=\"divider\"></li>\n\t\t\t<li>");
            EndContext();
            BeginContext(1937, 83, false);
#line 29 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.Logout, "Logout", AuthorizationController.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2020, 105, true);
            WriteLiteral("</li>\n\t\t</ul>\n\t</li>\n\t<li class=\"dropdown\">\n\t\t<a class=\"dropdown-toggle\" data-toggle=\"dropdown\" href=\"#\">");
            EndContext();
            BeginContext(2126, 25, false);
#line 33 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
                                                              Write(PopForums.Resources.Forum);

#line default
#line hidden
            EndContext();
            BeginContext(2151, 81, true);
            WriteLiteral(" <span class=\"caret\"></span></a>\n\t\t<ul class=\"dropdown-menu\" role=\"menu\">\n\t\t\t<li>");
            EndContext();
            BeginContext(2233, 116, false);
#line 35 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.Recent, "Recent", ForumController.Name, new { page = 1, Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(2363, 110, false);
#line 36 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.ActivityFeed, "Index", FeedController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2473, 13, true);
            WriteLiteral("</li>\n\t\t\t<li>");
            EndContext();
            BeginContext(2487, 107, false);
#line 37 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
           Write(Html.ActionLink(PopForums.Resources.ForumHome, "Index", HomeController.Name, new { Area = "Forums" }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2594, 31, true);
            WriteLiteral("</li>\n\t\t</ul>\n\t</li>\n\t<li>\n\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2625, "\"", 2719, 1);
#line 41 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
WriteAttributeValue("", 2632, Url.Action("Index", PrivateMessagesController.Name, new { page = 1, Area = "Forums" }), 2632, 87, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2720, "\"", 2764, 1);
#line 41 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
WriteAttributeValue("", 2728, PopForums.Resources.PrivateMessages, 2728, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2765, 52, true);
            WriteLiteral("><span class=\"glyphicon glyphicon-envelope\"></span> ");
            EndContext();
            BeginContext(2818, 23, false);
#line 41 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
                                                                                                                                                                                                     Write(Html.Raw(Model.PMCount));

#line default
#line hidden
            EndContext();
            BeginContext(2841, 12, true);
            WriteLiteral("</a>\n\t</li>\n");
            EndContext();
#line 43 "C:\Projects\Strategy\newSingleSite\Forum\PopForums.Mvc\Areas\Forums\Views\Shared\Components\UserNavigation\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserNavigationContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591