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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/SiteSettingTab.cshtml")]
    public partial class _Views_Shared_Partial_SiteSettingTab_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Partial_SiteSettingTab_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-site-setting-tab-template\"");

WriteLiteral(@">
    <div class=""bcms-inner-navigation"">
        <!-- ko foreach: tabs -->
        <div class=""bcms-inner-navigation-ui bcms-tab-item"" data-bind=""
            text: title,
            attr: {'data-name': href},
            click: tabClick, clickBubble: true""></div>
        <!-- /ko -->
    </div>

    <div class=""bcms-window-settings"">
        <!-- ko foreach: tabs -->
        <div class=""bcms-tab-single"" data-bind=""attr: {id: tabId}, stopBinding: true"">
            ");

WriteLiteral("\r\n            <div></div>\r\n        </div>\r\n        <!-- /ko -->\r\n    </div>\r\n</sc" +
"ript>\r\n");

        }
    }
}
#pragma warning restore 1591
