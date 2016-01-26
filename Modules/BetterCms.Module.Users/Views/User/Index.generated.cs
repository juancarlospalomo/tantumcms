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
    
    #line 28 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Users.Content.Resources;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Users.Controllers;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\User\Index.cshtml"
    using BetterCms.Module.Users.ViewModels.User;
    
    #line default
    #line hidden
    
    #line 36 "..\..\Views\User\Index.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 35 "..\..\Views\User\Index.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/Index.cshtml")]
    public partial class _Views_User_Index_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.SiteSettings.SearchableGridViewModel<UserItemViewModel>>
    {
        public _Views_User_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 39 "..\..\Views\User\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\User\Index.cshtml"
      
        Action<ColumnBuilder<UserItemViewModel>> columns = column =>
        {
            column.EditButtonColumn();

            column.For(m => string.Format("<div class=\"bcms-tables-link bcms-grid-item-edit-button bcms-user-name\">{0}</div>", m.UserName))
                .Named(UsersGlobalization.SiteSettings_Users_NameColumn)
                .SortColumnName("UserName")
                .Encode(false);

            column.For(m => m.FullName)
               .Named(UsersGlobalization.SiteSettings_Users_FullNameColumn)
               .SortColumnName("FullName")
               .Attributes(@class => "bcms-user-fullName");

            column.For(m => m.Email)
               .Named(UsersGlobalization.SiteSettings_Users_EmailColumn)
               .SortColumnName("Email")
               .Attributes(@class => "bcms-user-email");


            column.DeleteButtonColumn();
        };
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 64 "..\..\Views\User\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\User\Index.cshtml"
     using (Html.BeginForm<UserController>(f => f.Index(null), FormMethod.Post, new { @id = "bcms-users-form", @class = "bcms-ajax-form" }))
    {
        
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\User\Index.cshtml"
   Write(Html.MessagesBox("bcms-users-messages"));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\User\Index.cshtml"
                                                

        
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\User\Index.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\User\Index.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-user-button\"");

WriteLiteral(">");

            
            #line 70 "..\..\Views\User\Index.cshtml"
                                                               Write(UsersGlobalization.User_Dialog_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-users-search-btn\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\User\Index.cshtml"
                                                                   Write(UsersGlobalization.User_Dialog_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 76 "..\..\Views\User\Index.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 81 "..\..\Views\User\Index.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 84 "..\..\Views\User\Index.cshtml"


        
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\User\Index.cshtml"
   Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<UserItemViewModel>()));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\User\Index.cshtml"
                                                                                                                                                                                
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-users-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 90 "..\..\Views\User\Index.cshtml"
   Write(Html.Grid(new List<UserItemViewModel> { new UserItemViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<UserItemViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591
