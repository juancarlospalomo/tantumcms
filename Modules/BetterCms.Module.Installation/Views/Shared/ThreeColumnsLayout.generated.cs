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
    
    #line 29 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
    using BetterCms.Module.Installation;
    
    #line default
    #line hidden
    
    #line 28 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ThreeColumnsLayout.cshtml")]
    public partial class _Views_Shared_ThreeColumnsLayout_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Core.DataContracts.IPage>
    {
        public _Views_Shared_ThreeColumnsLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 31 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
  
    Layout = "~/Areas/bcms-Root/Views/Shared/BaseLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

DefineSection("Styles", () => {

WriteLiteral("    \r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
Write(Html.RenderStyleSheets<InstallationModuleDescriptor>());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n\r\n    <header");

WriteLiteral(" class=\"page-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
       Write(RenderSection("CMSHeader", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </header>\r\n\r\n    <div");

WriteLiteral(" class=\"page-block\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\r\n\r\n            <section");

WriteLiteral(" class=\"three-col-left\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
           Write(RenderSection("CMSMainContent", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 55 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n\r\n            <section");

WriteLiteral(" class=\"three-col-middle\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 59 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
           Write(RenderSection("CMSLeftSide", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n\r\n            <aside");

WriteLiteral(" class=\"col-right\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
           Write(RenderSection("CMSRightSide", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </aside>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<footer");

WriteLiteral(" class=\"page-footer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 73 "..\..\Views\Shared\ThreeColumnsLayout.cshtml"
   Write(RenderSection("CMSFooter", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</footer>\r\n");

        }
    }
}
#pragma warning restore 1591