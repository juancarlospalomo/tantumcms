﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 28 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Content\EditPageHtmlContent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/EditPageHtmlContent.cshtml")]
    public partial class _Views_Content_EditPageHtmlContent_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public _Views_Content_EditPageHtmlContent_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 34 "..\..\Views\Content\EditPageHtmlContent.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                              Write(PagesGlobalization.EditPageContent_RegularContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Content\EditPageHtmlContent.cshtml"
                                                                  Write(PagesGlobalization.EditPageContent_AdvancedOptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 47 "..\..\Views\Content\EditPageHtmlContent.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 50 "..\..\Views\Content\EditPageHtmlContent.cshtml"
   Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 52 "..\..\Views\Content\EditPageHtmlContent.cshtml"
        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Content\EditPageHtmlContent.cshtml"
         using (Html.BeginForm<ContentController>(c => c.SavePageHtmlContent(null), FormMethod.Post,
        new
        {
            @id = "bcms-content-form",
            @class = "bcms-ajax-form",
            data_readonly = Model.IsReadOnly.ToString().ToLowerInvariant()
        }))
        {


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContent", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsPageContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Version));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 65 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentVersion, new { @id = "bcmsPageContentVersion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentId, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 67 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ParentPageContentId, new { @id = "bcmsParentPageContentId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.PageId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.RegionId, new { @id = "bcmsContentToRegionId" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 70 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 71 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.IsUserConfirmed, new { @id = "bcms-user-confirmed-region-deletion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 73 "..\..\Views\Content\EditPageHtmlContent.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 75 "..\..\Views\Content\EditPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContentJsCss", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 77 "..\..\Views\Content\EditPageHtmlContent.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
