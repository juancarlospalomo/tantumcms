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
    
    #line 28 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.ViewModels.Widgets;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/EditServerControlWidget.cshtml")]
    public partial class _Views_Widgets_EditServerControlWidget_cshtml : System.Web.Mvc.WebViewPage<EditServerControlWidgetViewModel>
    {
        public _Views_Widgets_EditServerControlWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
  
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = PagesGlobalization.EditPageProperties_BasicPropertiesTab_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 43 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
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

            
            #line 50 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                              Write(PagesGlobalization.EditWidget_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                  Write(PagesGlobalization.EditWidget_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 56 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.MessagesBox("bcms-edit-widget-messages"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 57 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n");

            
            #line 60 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
        
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
         using (Html.BeginForm<WidgetsController>(c => c.EditServerControlWidget((string)null), FormMethod.Post, new { @id = "bcms-widget-form", @class = "bcms-ajax-form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-form-block-holder\"");

WriteLiteral(">\r\n                    <div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                        Write(PagesGlobalization.Widget_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.Widget_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 69 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 70 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n         " +
"               <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 75 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                        Write(PagesGlobalization.Widget_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 76 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.Widget_Url_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 78 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.TextBoxFor(model => model.Url, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 79 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n         " +
"               <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                        Write(PagesGlobalization.WidgetPreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 85 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 87 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.TextBoxFor(model => model.PreviewImageUrl, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 88 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                           Write(Html.BcmsValidationMessageFor(m => m.PreviewImageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n         " +
"               <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 93 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                       Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 99 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                        Write(PagesGlobalization.WidgetPreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                            ");

            
            #line 100 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                       Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                            <div");

WriteLiteral(" class=\"bcms-preview-thumb\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" id=\"bcms-widget-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5319), Tuple.Create("\"", 5347)
            
            #line 103 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
, Tuple.Create(Tuple.Create("", 5325), Tuple.Create<System.Object, System.Int32>(Model.PreviewImageUrl
            
            #line default
            #line hidden
, 5325), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                                    <svg");

WriteLiteral(" class=\"bcms-grid-no-preview\"");

WriteLiteral(" id=\"bcms-widget-no-preview\"");

WriteLiteral(" width=\"50\"");

WriteLiteral(" height=\"50\"");

WriteLiteral(" viewBox=\"-205 372 50 50\"");

WriteLiteral(" enable-background=\"new -205 372 50 50\"");

WriteLiteral(">\r\n                                        <g");

WriteLiteral(" fill=\"#cdcdcd\"");

WriteLiteral(">\r\n                                            <path");

WriteLiteral(" d=\"m-205 422h50v-50h-50v50m2-48h46v46h-46v-46\"");

WriteLiteral(" />\r\n                                            <path");

WriteLiteral(" d=\"m-164.3 406.2l1.4-1.4-11.5-11.5-7.7 7.6-3.6-3.6-11.5 11.5 1.4 1.4 10.1-10.1 1" +
"1.1 11.1 1.4-1.4-7.5-7.5 6.3-6.2 10.1 10.1\"");

WriteLiteral(" />\r\n                                            <path");

WriteLiteral(" d=\"m-187.9 382.4c-2.8 0-5 2.2-5 5 0 2.8 2.2 5 5 5 2.8 0 5-2.2 5-5 0-2.8-2.2-5-5-" +
"5m0 2c1.7 0 3 1.4 3 3 0 1.7-1.3 3-3 3-1.6 0-3-1.3-3-3 0-1.7 1.3-3 3-3\"");

WriteLiteral(" />\r\n                                        </g>\r\n                              " +
"      </svg>\r\n                            </div>\r\n                        </div>" +
"\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 116 "..\..\Views\Widgets\EditServerControlWidget.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 118 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
           Write(Html.Partial(PagesConstants.OptionsGridTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 120 "..\..\Views\Widgets\EditServerControlWidget.cshtml"

            
            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                             
            
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.HiddenFor(model => model.Version, new { @id = "bcmsContentVersion" }));

            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                       
            
            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                             
            
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.HiddenFor(modal => modal.PreviewOnPageContentId, new { @class = "bcms-preview-page-content-id" }));

            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                                   
            
            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
