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
    
    #line 28 "..\..\Views\Page\SelectPage.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Page\SelectPage.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Page\SelectPage.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Page\SelectPage.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/SelectPage.cshtml")]
    public partial class _Views_Page_SelectPage_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<SiteSettingPageViewModel>>
    {
        public _Views_Page_SelectPage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 36 "..\..\Views\Page\SelectPage.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\r\n");

            
            #line 39 "..\..\Views\Page\SelectPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Page\SelectPage.cshtml"
         using (Html.BeginForm<PageController>(controller => controller.SelectPage(null), FormMethod.Post, new { @id = "bcms-pages-form", @class = "bcms-ajax-form" }))
        {
            
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Page\SelectPage.cshtml"
       Write(Html.Partial("Partial/SiteSettingsPagesList"));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Page\SelectPage.cshtml"
                                                          
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
