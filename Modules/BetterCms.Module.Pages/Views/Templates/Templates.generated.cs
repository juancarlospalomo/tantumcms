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
    
    #line 28 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 35 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 36 "..\..\Views\Templates\Templates.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 37 "..\..\Views\Templates\Templates.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 38 "..\..\Views\Templates\Templates.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Templates/Templates.cshtml")]
    public partial class _Views_Templates_Templates_cshtml : System.Web.Mvc.WebViewPage<SiteSettingTemplateListViewModel>
    {
        public _Views_Templates_Templates_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 41 "..\..\Views\Templates\Templates.cshtml"
  
    var controller = (CmsControllerBase)ViewContext.Controller;
    var roles = string.Format("{0},{1},{2}",
        RootModuleConstants.UserRoles.PublishContent,
        RootModuleConstants.UserRoles.EditContent,
        RootModuleConstants.UserRoles.DeleteContent);
    var canViewPages = controller.SecurityService.IsAuthorized(roles);

    Action<ColumnBuilder<SiteSettingTemplateItemViewModel>> columns = column =>
    {
        column.EditButtonColumn(renderId: false);

        column.For(f => string.Format("<a class=\"bcms-tables-link bcms-grid-item-edit-button bcms-template-name\" data-id=\"{0}\" data-url=\"{2}\">{1}</a>", f.Id, f.TemplateName, f.Url))
            .Named(PagesGlobalization.SiteSettings_Templates_NameColumn)
            .SortColumnName("TemplateName")
            .Encode(false);

        if (canViewPages)
        {
            column.For(f => string.Format("<div class=\"bcms-action-usage\" data-id=\"{0}\" title=\"{1}\">{1}</div>", f.Id, PagesGlobalization.SiteSettings_Templates_Usage))
                .HeaderAttributes(@style => "width: 40px; padding: 8px 0;")
                .Named("")
                .Sortable(false)
                .Encode(false);
        }

        column.DeleteButtonColumn(false);
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 71 "..\..\Views\Templates\Templates.cshtml"
 using (Html.BeginForm<TemplatesController>(f => f.Templates(null), FormMethod.Post, new { @id = "bcms-templates-form", @class = "bcms-ajax-form" }))
{

    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Templates\Templates.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Templates\Templates.cshtml"
                       


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 77 "..\..\Views\Templates\Templates.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-top-controls-btn-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-page-button\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Templates\Templates.cshtml"
                                                                   Write(PagesGlobalization.SiteSettings_Pages_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-btn-opener\"");

WriteLiteral("> </div>\r\n                \r\n                <div");

WriteLiteral(" class=\"bcms-btn-opener-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-opener-link\"");

WriteLiteral(" id=\"bcms-register-template-button\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Templates\Templates.cshtml"
                                                                                    Write(PagesGlobalization.SiteSettings_Widgets_RegisterNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-template-search-btn\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Templates\Templates.cshtml"
                                                                      Write(PagesGlobalization.SiteSettings_Template_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 91 "..\..\Views\Templates\Templates.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 96 "..\..\Views\Templates\Templates.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 100 "..\..\Views\Templates\Templates.cshtml"
    Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RowAttributes(delegate(GridRowViewData<SiteSettingTemplateItemViewModel> row)
                  {
                      return new Dictionary<string, object>
                              {
                                    {"data-id", row.Item.Id},
                                    {"data-version", row.Item.Version},
                                    {"data-ismasterpage", row.Item.IsMasterPage ? "1" : "0"}
                              };
                  }).RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingTemplateItemViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 110 "..\..\Views\Templates\Templates.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-template-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 113 "..\..\Views\Templates\Templates.cshtml"
Write(Html.Grid(new List<SiteSettingTemplateItemViewModel> { new SiteSettingTemplateItemViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingTemplateItemViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
