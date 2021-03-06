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
    
    #line 28 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Pages.Command.History.GetContentHistory;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Pages.ViewModels.History;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 35 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 36 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 37 "..\..\Views\History\ContentHistoryTable.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 38 "..\..\Views\History\ContentHistoryTable.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 39 "..\..\Views\History\ContentHistoryTable.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/ContentHistoryTable.cshtml")]
    public partial class _Views_History_ContentHistoryTable_cshtml : System.Web.Mvc.WebViewPage<ContentHistoryViewModel>
    {

#line 41 "..\..\Views\History\ContentHistoryTable.cshtml"
public System.Web.WebPages.HelperResult PreviewLink(ContentHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 42 "..\..\Views\History\ContentHistoryTable.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-action-usage bcms-js-preview\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 1981), Tuple.Create("\"", 2022)

#line 43 "..\..\Views\History\ContentHistoryTable.cshtml"
, Tuple.Create(Tuple.Create("", 1989), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Preview

#line default
#line hidden
, 1989), false)
);

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 43 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                        WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 43 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                                  WriteTo(__razor_helper_writer, RootGlobalization.Button_Preview);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 44 "..\..\Views\History\ContentHistoryTable.cshtml"


#line default
#line hidden
});

#line 44 "..\..\Views\History\ContentHistoryTable.cshtml"
}
#line default
#line hidden

#line 45 "..\..\Views\History\ContentHistoryTable.cshtml"
public System.Web.WebPages.HelperResult RestoreLink(ContentHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 46 "..\..\Views\History\ContentHistoryTable.cshtml"
 
    if (item.CanCurrentUserRestoreIt)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-action-restore bcms-js-restore\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 2238), Tuple.Create("\"", 2279)

#line 49 "..\..\Views\History\ContentHistoryTable.cshtml"
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Restore

#line default
#line hidden
, 2246), false)
);

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 49 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                              WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, " data-version=\"");


#line 49 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                                                      WriteTo(__razor_helper_writer, item.Version);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 49 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                                                                     WriteTo(__razor_helper_writer, RootGlobalization.Button_Restore);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 50 "..\..\Views\History\ContentHistoryTable.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "&nbsp;\r\n");


#line 54 "..\..\Views\History\ContentHistoryTable.cshtml"
    }


#line default
#line hidden
});

#line 55 "..\..\Views\History\ContentHistoryTable.cshtml"
}
#line default
#line hidden

#line 56 "..\..\Views\History\ContentHistoryTable.cshtml"
public System.Web.WebPages.HelperResult DisplayStatus(string statusName, ContentStatus status)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 57 "..\..\Views\History\ContentHistoryTable.cshtml"
 
    switch (status)
    {
        case ContentStatus.Archived:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-archived-state\">");


#line 61 "..\..\Views\History\ContentHistoryTable.cshtml"
                 WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 62 "..\..\Views\History\ContentHistoryTable.cshtml"
            break;
        case ContentStatus.Draft:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-draft-state\">");


#line 64 "..\..\Views\History\ContentHistoryTable.cshtml"
              WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 65 "..\..\Views\History\ContentHistoryTable.cshtml"
            break;
        case ContentStatus.Published:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-published-state\">");


#line 67 "..\..\Views\History\ContentHistoryTable.cshtml"
                  WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 68 "..\..\Views\History\ContentHistoryTable.cshtml"
            break;
        default:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "statusName\r\n");


#line 71 "..\..\Views\History\ContentHistoryTable.cshtml"
            break;
    }


#line default
#line hidden
});

#line 73 "..\..\Views\History\ContentHistoryTable.cshtml"
}
#line default
#line hidden

        public _Views_History_ContentHistoryTable_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 74 "..\..\Views\History\ContentHistoryTable.cshtml"
  
    Action<ColumnBuilder<ContentHistoryItem>> columns = column =>
    {
        column.For(f => PreviewLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 40px; padding: 0;", @class => "bcms-tables-nohover");

        column.For(m => m.PublishedOn.ToFormattedDateString())
               .Named(PagesGlobalization.ContentHistory_Column_PublishedOn)
               .SortColumnName("PublishedOn")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => m.PublishedByUser)
               .Named(PagesGlobalization.ContentHistory_Column_PublishedByUser)
               .SortColumnName("PublishedByUser");

        column.For(m => m.ArchivedOn.ToFormattedDateString())
               .Named(PagesGlobalization.ContentHistory_Column_ArchivedOn)
               .SortColumnName("ArchivedOn")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => m.DisplayedFor.ToFormatedTimeString())
               .Named(PagesGlobalization.ContentHistory_Column_DisplayedFor)
               .SortColumnName("DisplayedFor")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => DisplayStatus(m.StatusName, m.Status))
               .Named(PagesGlobalization.ContentHistory_Column_Status)
               .SortColumnName("StatusName")
               .Encode(false)
               .HeaderAttributes(@style => "width: 95px;");

        column.For(f => RestoreLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 40px; padding: 0;", @class => "bcms-tables-nohover");
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-history-preview-holder bcms-history-preview-iframe\"");

WriteLiteral(" id=\"bcms-history-preview\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-history-info\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">");

            
            #line 117 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                          Write(PagesGlobalization.ContentHistory_SelectVersionToPreviewMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-history-preview-data\"");

WriteLiteral(" id=\"bcms-history-preview-properties\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-history-info\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">");

            
            #line 123 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                          Write(PagesGlobalization.ContentHistory_SelectVersionToPreviewMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-history-table-holder\"");

WriteLiteral(">\r\n");

            
            #line 128 "..\..\Views\History\ContentHistoryTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 128 "..\..\Views\History\ContentHistoryTable.cshtml"
     using (Html.BeginForm<HistoryController>(f => f.ContentHistory((GetContentHistoryRequest)null), FormMethod.Post, new { @id = "bcms-pagecontenthistory-form", @class = "bcms-ajax-form" }))
    {
        
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\History\ContentHistoryTable.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\History\ContentHistoryTable.cshtml"
   Write(Html.HiddenFor(model => model.ContentId));

            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                 


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-history-table-top\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 134 "..\..\Views\History\ContentHistoryTable.cshtml"
                                      Write(PagesGlobalization.ContentHistory_OlderVersions);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pagecontenthistory-search-btn\"");

WriteLiteral(">");

            
            #line 136 "..\..\Views\History\ContentHistoryTable.cshtml"
                                                                                Write(RootGlobalization.Button_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 138 "..\..\Views\History\ContentHistoryTable.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 142 "..\..\Views\History\ContentHistoryTable.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-history-items-list\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 144 "..\..\Views\History\ContentHistoryTable.cshtml"
       Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables bcms-history-grid").RenderUsing(new EditableHtmlTableGridRenderer<ContentHistoryItem>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 145 "..\..\Views\History\ContentHistoryTable.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 147 "..\..\Views\History\ContentHistoryTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
