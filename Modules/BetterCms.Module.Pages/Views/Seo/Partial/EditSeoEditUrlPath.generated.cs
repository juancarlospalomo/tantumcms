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
    
    #line 28 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Seo/Partial/EditSeoEditUrlPath.cshtml")]
    public partial class _Views_Seo_Partial_EditSeoEditUrlPath_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Seo.EditSeoViewModel>
    {
        public _Views_Seo_Partial_EditSeoEditUrlPath_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
   Write(PagesGlobalization.EditSeo_UrlPath);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 35 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                       Write(Html.Tooltip(PagesGlobalization.EditSeo_UrlPath_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-editor-link\"");

WriteLiteral(" id=\"bcms-editseo-editurlpath\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                               Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"bcms-editor-path\"");

WriteLiteral(" id=\"bcms-page-permalink-info\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                           Write(Html.Raw(string.IsNullOrWhiteSpace(Model.PageUrlPath) ? "&nbsp;" : Html.Encode(Model.PageUrlPath)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
Write(Html.HiddenFor(f => f.PageUrlPath));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-editor-box bcms-js-edit-box\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
       Write(Html.TextBoxFor(f => f.ChangedUrlPath, new { @class = "bcms-field-text bcms-js-url-path" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
       Write(Html.BcmsValidationMessageFor(f => f.ChangedUrlPath));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"bcms-editseo-editurlpath-save\"");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                                    Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" id=\"bcms-editseo-editurlpath-cancel\"");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                                     Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-checkbox-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
       Write(Html.CheckBoxFor(f => f.CreatePermanentRedirect));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-checkbox-label bcms-js-edit-label\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                           Write(PagesGlobalization.EditSeo_EditUrlPath_PermanentRedirect);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-checkbox-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
       Write(Html.CheckBoxFor(f => f.UseCanonicalUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-checkbox-label bcms-js-edit-label\"");

WriteLiteral(">");

            
            #line 57 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                           Write(PagesGlobalization.EditSeo_EditUrlPath_UseCanonicalUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n\r\n");

            
            #line 60 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
        
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
         if (Model.IsInSitemap)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-checkbox-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
           Write(Html.CheckBoxFor(f => f.UpdateSitemap));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-checkbox-label bcms-js-edit-label\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                               Write(PagesGlobalization.EditSeo_EditUrlPath_UpdateSitemap);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 66 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
