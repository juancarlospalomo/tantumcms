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
    
    #line 28 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/WidgetRecent.cshtml")]
    public partial class _Views_Content_Partial_WidgetRecent_cshtml : System.Web.Mvc.WebViewPage<IList<BetterCms.Module.Pages.ViewModels.Widgets.WidgetViewModel>>
    {
        public _Views_Content_Partial_WidgetRecent_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
    
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
     if (Model != null && Model.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("<div class=\"bcms-category-titles\">");

            
            #line 39 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                   Write(PagesGlobalization.AddPageContent_WidgetTab_RecentWidgets_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 40 "..\..\Views\Content\Partial\WidgetRecent.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("<div class=\"bcms-templates-holder\">\r\n");

            
            #line 42 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
        for (int i = 0; i < Model.Count; i++)
        {
            var widget = Model[i];


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-grid-box bcms-grid-box-pages bcms-js-preview-block\"");

WriteLiteral("\r\n                 data-id=\"");

            
            #line 47 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                     Write(widget.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                 data-original-id=\"");

            
            #line 48 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                              Write(widget.OriginalId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                 data-version=\"");

            
            #line 49 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                          Write(widget.Version);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                 data-original-version=\"");

            
            #line 50 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                   Write(widget.OriginalVersion);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                 data-type=\"");

            
            #line 51 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                       Write(widget.WidgetType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                 data-category-id=\"");

            
            #line 52 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                               Write(Guid.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                            Write(widget.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 56 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                 if (!string.IsNullOrWhiteSpace(widget.PreviewImageUrl))
                {
                    
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
               Write(Html.PreviewContentBox(widget.PreviewImageUrl, widget.PreviewImageUrl, widget.Name, true));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                                                                              
                }
                else
                {
                    var url1 = Html.BuildUrlFromExpression<WidgetsController>(f => f.PreviewWidget(widget.Id.ToString(), false));
                    var url2 = Html.BuildUrlFromExpression<WidgetsController>(f => f.PreviewWidget(widget.Id.ToString(), true));
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
               Write(Html.PreviewContentBox(url1, url2, widget.Name));

            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                                    
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-grid-controls-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-selection bcms-js-insert\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                              Write(PagesGlobalization.AddPageContent_WidgetTab_InsertButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 69 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                     if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.Administration))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"bcms-grid-controls-helper\"");

WriteLiteral(">\r\n");

            
            #line 72 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                             if (!widget.Status.Equals(ContentStatus.Published.ToString()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"bcms-action-edit bcms-draft bcms-js-content-edit\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3681), Tuple.Create("\"", 3744)
            
            #line 74 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                     , Tuple.Create(Tuple.Create("", 3689), Tuple.Create<System.Object, System.Int32>(PagesGlobalization.AddPageContent_WidgetTab_EditButton
            
            #line default
            #line hidden
, 3689), false)
);

WriteLiteral(">");

            
            #line 74 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                                                                                                                         Write(PagesGlobalization.AddPageContent_WidgetTab_EditButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 75 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"bcms-action-edit bcms-js-content-edit\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3987), Tuple.Create("\"", 4050)
            
            #line 78 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
          , Tuple.Create(Tuple.Create("", 3995), Tuple.Create<System.Object, System.Int32>(PagesGlobalization.AddPageContent_WidgetTab_EditButton
            
            #line default
            #line hidden
, 3995), false)
);

WriteLiteral(">");

            
            #line 78 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                                                                                                              Write(PagesGlobalization.AddPageContent_WidgetTab_EditButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 79 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"bcms-action-delete bcms-js-content-delete\"");

WriteAttribute("title", Tuple.Create(" title=\"", 4228), Tuple.Create("\"", 4293)
            
            #line 80 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
          , Tuple.Create(Tuple.Create("", 4236), Tuple.Create<System.Object, System.Int32>(PagesGlobalization.AddPageContent_WidgetTab_DeleteButton
            
            #line default
            #line hidden
, 4236), false)
);

WriteLiteral(">");

            
            #line 80 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                                                                                                                                                Write(PagesGlobalization.AddPageContent_WidgetTab_DeleteButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n");

            
            #line 82 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

            
            #line 85 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("</div>\r\n");

            
            #line 87 "..\..\Views\Content\Partial\WidgetRecent.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
