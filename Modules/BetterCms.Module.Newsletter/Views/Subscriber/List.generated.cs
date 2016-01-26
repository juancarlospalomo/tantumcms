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
    
    #line 28 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Newsletter.Content.Resources;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Subscriber/List.cshtml")]
    public partial class _Views_Subscriber_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Subscriber_List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Subscriber\List.cshtml"
      
        var gridViewModel = new EditableGridViewModel { ShowMessages = true, TopBlockTitle = NewsletterGlobalization.SiteSettings_NewsletterSubscribers_Title, Columns = new List<EditableGridColumn> { new EditableGridColumn(NewsletterGlobalization.SiteSettings_NewsletterSubscribers_Email_Title, "Email", "email") { AutoFocus = true, FocusIdentifier = "hasFocus" } } };
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1969), Tuple.Create("\"", 2005)
            
            #line 39 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 1977), Tuple.Create<System.Object, System.Int32>(gridViewModel.TopBlockClass
            
            #line default
            #line hidden
, 1977), false)
);

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-top-controls-btn-holder\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Views\Subscriber\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Subscriber\List.cshtml"
             if (gridViewModel.CanAddNewItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" data-bind=\"click: addNewItem\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Subscriber\List.cshtml"
                                                                    Write(gridViewModel.AddNewTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener\"");

WriteLiteral("> </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-opener-link\"");

WriteLiteral(" id=\"download-subscribers-in-csv\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Subscriber\List.cshtml"
                                                                                  Write(NewsletterGlobalization.Download_NewsletterSubscribers_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n");

            
            #line 48 "..\..\Views\Subscriber\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 50 "..\..\Views\Subscriber\List.cshtml"
        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Subscriber\List.cshtml"
         if (gridViewModel.ShowSearch)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-search\' : searchEnabled }\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" data-bind=\"click: toggleSearch\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Subscriber\List.cshtml"
                                                                        Write(RootGlobalization.Button_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"bcms-search-field-box\"");

WriteLiteral(" data-bind=\"value: options().searchQuery, valueUpdate: \'afterkeydown\', enterPress" +
": searchItems, hasfocus: options().hasFocus, enable: searchEnabled\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3089), Tuple.Create("\"", 3138)
            
            #line 55 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                                                      , Tuple.Create(Tuple.Create("", 3103), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WaterMark_Search
            
            #line default
            #line hidden
, 3103), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");

            
            #line 58 "..\..\Views\Subscriber\List.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 59 "..\..\Views\Subscriber\List.cshtml"
         if (gridViewModel.AddPaging)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n                <!-- ko with: options().paging -->\r\n                <div");

WriteLiteral(" class=\"bcms-featured-grid bcms-clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 64 "..\..\Views\Subscriber\List.cshtml"
               Write(Html.Partial(gridViewModel.PagingView, gridViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <!-- /ko -->\r\n            </div>\r\n");

            
            #line 68 "..\..\Views\Subscriber\List.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n");

            
            #line 71 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\Subscriber\List.cshtml"
     if (gridViewModel.ShowMessages)
    {
        
            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Subscriber\List.cshtml"
   Write(Html.MessagesBox(null, new Dictionary<string, string> { { "data-bind", "attr: { id: messagesDomId() }" } }));

            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                    
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 76 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Subscriber\List.cshtml"
      
        var visibleColumns = gridViewModel.Columns.Where(c => c.IsRendered).ToList();
        var visibleColumnsCount = visibleColumns.Count;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <table");

WriteLiteral(" class=\"bcms-tables\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" style=\"width: 40px; padding: 0;\"");

WriteLiteral(">&nbsp;</th>\r\n");

            
            #line 85 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Subscriber\List.cshtml"
                 foreach (var column in visibleColumns)
                {
                    
            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Subscriber\List.cshtml"
               Write(Html.Partial(column.HeaderView, column));

            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Subscriber\List.cshtml"
                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <" +
"!-- ko foreach: items -->\r\n            <tr");

WriteLiteral(" data-bind=\"click: onOpen, css: {\'bcms-table-row-active\' : isActive() || isSelect" +
"edForInsert()}, attr: {id: getRowId()}\"");

WriteLiteral(">\r\n                <!-- ko if: saving() || deleting() -->\r\n");

            
            #line 96 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: saving() -->\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 4816), Tuple.Create("\"", 4846)
            
            #line 100 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 4826), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 4826), false)
);

WriteLiteral(">");

            
            #line 100 "..\..\Views\Subscriber\List.cshtml"
                                                                              Write(RootGlobalization.Message_Saving);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 102 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 103 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: deleting() -->\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 5166), Tuple.Create("\"", 5196)
            
            #line 107 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 5176), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 5176), false)
);

WriteLiteral(">");

            
            #line 107 "..\..\Views\Subscriber\List.cshtml"
                                                                              Write(RootGlobalization.Message_Deleting);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 109 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <!-- /ko -->\r\n                <!-- ko ifnot: saving() || deleting" +
"() -->\r\n");

            
            #line 112 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 112 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n                        <!-- ko if: !editingIsDisabled(" +
") -->\r\n                        <div");

WriteLiteral(" class=\"bcms-action-edit\"");

WriteLiteral(" data-bind=\"click: onEdit\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5614), Tuple.Create("\"", 5652)
            
            #line 116 "..\..\Views\Subscriber\List.cshtml"
       , Tuple.Create(Tuple.Create("", 5622), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Edit
            
            #line default
            #line hidden
, 5622), false)
);

WriteLiteral(">");

            
            #line 116 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                  Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <!-- /ko -->\r\n                    </td>\r\n");

            
            #line 119 "..\..\Views\Subscriber\List.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>&nbsp;</td>\r\n");

            
            #line 123 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 125 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\Subscriber\List.cshtml"
                 foreach (var column in visibleColumns)
                {
                    
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Subscriber\List.cshtml"
               Write(Html.Partial(column.CellView, column));

            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Subscriber\List.cshtml"
                                                          
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 130 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanDeleteItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <!-- ko if: !isActive() && !deletingIsDisabled() -->\r\n");

WriteLiteral("                    <td");

WriteLiteral(" style=\"width: 40px; padding: 10px 0;\"");

WriteLiteral(">                 \r\n                        <div");

WriteLiteral(" class=\"bcms-action-delete\"");

WriteLiteral(" data-bind=\"click: onDelete\"");

WriteAttribute("title", Tuple.Create(" title=\"", 6341), Tuple.Create("\"", 6381)
            
            #line 134 "..\..\Views\Subscriber\List.cshtml"
           , Tuple.Create(Tuple.Create("", 6349), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Delete
            
            #line default
            #line hidden
, 6349), false)
);

WriteLiteral(">");

            
            #line 134 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                        Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </td>\r\n");

WriteLiteral("                    <!-- /ko -->\r\n");

            
            #line 137 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 138 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <!-- ko if: isActive() -->\r\n");

WriteLiteral("                    <td");

WriteLiteral(" style=\"width: 120px;\"");

WriteLiteral(">                   \r\n                        <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: onSave\"");

WriteLiteral(">");

            
            #line 142 "..\..\Views\Subscriber\List.cshtml"
                                                                           Write(gridViewModel.SaveButtonTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: onCancelEdit\"");

WriteLiteral(">");

            
            #line 143 "..\..\Views\Subscriber\List.cshtml"
                                                                                Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>                   \r\n                    </td>\r\n");

WriteLiteral("                    <!-- /ko -->\r\n");

            
            #line 146 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 147 "..\..\Views\Subscriber\List.cshtml"
                 if (!gridViewModel.CanDeleteItems && !gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("<td>&nbsp;</td>\r\n");

            
            #line 150 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <!-- /ko -->\r\n            </tr>\r\n            <!-- /ko -->\r\n    " +
"        <!-- ko if: items().length == 0 -->\r\n            <tr>\r\n                <" +
"td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 7353), Tuple.Create("\"", 7389)
            
            #line 157 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 7363), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount + 2
            
            #line default
            #line hidden
, 7363), false)
);

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-table-no-data\"");

WriteLiteral(">");

            
            #line 158 "..\..\Views\Subscriber\List.cshtml"
                                               Write(RootGlobalization.Grid_NoDataAvailable_Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </td>\r\n            </tr>\r\n            <!-- /ko -->\r\n     " +
"   </tbody>\r\n    </table>\r\n\r\n");

            
            #line 165 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 165 "..\..\Views\Subscriber\List.cshtml"
     if (gridViewModel.AddHiddenFields)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko foreach: items -->\r\n");

            
            #line 168 "..\..\Views\Subscriber\List.cshtml"
        foreach (var column in gridViewModel.Columns)
        {
            if (!string.IsNullOrWhiteSpace(column.HiddenFieldName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" data-bind=\"valueBinder: ");

            
            #line 172 "..\..\Views\Subscriber\List.cshtml"
                                                                          Write(column.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(", attr {name hiddenfieldname(\'");

            
            #line 172 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                           Write(column.HiddenFieldName);

            
            #line default
            #line hidden
WriteLiteral("\', $index()) }\"");

WriteLiteral(">\r\n");

            
            #line 173 "..\..\Views\Subscriber\List.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");

            
            #line 176 "..\..\Views\Subscriber\List.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591