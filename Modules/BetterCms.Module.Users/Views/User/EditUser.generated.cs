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
    
    #line 28 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.Content.Resources;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.Controllers;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\User\EditUser.cshtml"
    using BetterCms.Module.Users.ViewModels.User;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\User\EditUser.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/EditUser.cshtml")]
    public partial class _Views_User_EditUser_cshtml : System.Web.Mvc.WebViewPage<EditUserViewModel>
    {
        public _Views_User_EditUser_cshtml()
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

            
            #line 38 "..\..\Views\User\EditUser.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Views\User\EditUser.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\User\EditUser.cshtml"
         using (Html.BeginForm<UserController>(c => c.SaveUser(null), FormMethod.Post, new { @class = "bcms-ajax-form" }))
        {
            
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\User\EditUser.cshtml"
       Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\User\EditUser.cshtml"
                                      
            
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\User\EditUser.cshtml"
       Write(Html.HiddenFor(m => m.Version));

            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\User\EditUser.cshtml"
                                           
            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\User\EditUser.cshtml"
       Write(Html.HiddenFor(model => model.Image.ImageId, new { data_bind = "value: image().id()" }));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\User\EditUser.cshtml"
                                                                                                    


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-form-block-holder\"");

WriteLiteral(">\r\n                <div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_FirstName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 51 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_FirstName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 53 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "bcms-field-text", data_bind = "value: firstName, valueUpdate: 'afterkeydown'" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 54 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_LastName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 60 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_LastName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 62 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { @class = "bcms-field-text", data_bind = "value: lastName, valueUpdate: 'afterkeydown'" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 63 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_UserName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 69 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_UserName_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 71 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "bcms-field-text", data_bind = "value: userName, valueUpdate: 'afterkeydown', event: {keyup: userNameOnKeyUp}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 72 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 77 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_Email_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 78 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_Email_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 80 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 81 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_Password_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 87 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_Password_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 89 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "bcms-field-text", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 90 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                 " +
"   <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 95 "..\..\Views\User\EditUser.cshtml"
                                                    Write(UsersGlobalization.EditUser_RetypePassword_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 96 "..\..\Views\User\EditUser.cshtml"
                                                                Write(UsersGlobalization.EditUser_RetypePassword_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 98 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.RetypedPassword, new { @class = "bcms-field-text", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 99 "..\..\Views\User\EditUser.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.RetypedPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n\r\n                <div>\r\n                    <div");

WriteLiteral(" class=\"bcms-thumb-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-thumb-box\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 108 "..\..\Views\User\EditUser.cshtml"
                                                            Write(UsersGlobalization.EditUser_Image_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                <div");

WriteLiteral(" class=\"bcms-tooltip-mark\"");

WriteLiteral(" data-message=\"");

            
            #line 109 "..\..\Views\User\EditUser.cshtml"
                                                                        Write(UsersGlobalization.EditUser_UserImage_Tooltip_Description);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></div>\r\n                            </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"bcms-thumb-image\"");

WriteLiteral(">\r\n                                <!-- ko if: image().url() -->\r\n               " +
"                 <div");

WriteLiteral(" class=\"bcms-remove-image\"");

WriteLiteral(" data-bind=\"click: image().remove.bind(image())\"");

WriteLiteral(">");

            
            #line 114 "..\..\Views\User\EditUser.cshtml"
                                                                                                          Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                <div");

WriteLiteral(" data-bind=\"click: image().preview.bind(image())\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" data-bind=\"attr: { src: image().thumbnailUrl(), alt: image().tooltip() }\"");

WriteLiteral(" />\r\n                                </div>\r\n                                <!--" +
" /ko -->\r\n                                <!-- ko ifnot: image().url() -->\r\n    " +
"                            <svg");

WriteLiteral(" class=\"bcms-grid-no-preview\"");

WriteLiteral(" width=\"50\"");

WriteLiteral(" height=\"50\"");

WriteLiteral(" viewBox=\"-205 372 50 50\"");

WriteLiteral(" enable-background=\"new -205 372 50 50\"");

WriteLiteral(">\r\n                                    <g");

WriteLiteral(" fill=\"#cdcdcd\"");

WriteLiteral(">\r\n                                        <path");

WriteLiteral(" d=\"m-205 422h50v-50h-50v50m2-48h46v46h-46v-46\"");

WriteLiteral("></path>\r\n                                        <path");

WriteLiteral(" d=\"m-164.3 406.2l1.4-1.4-11.5-11.5-7.7 7.6-3.6-3.6-11.5 11.5 1.4 1.4 10.1-10.1 1" +
"1.1 11.1 1.4-1.4-7.5-7.5 6.3-6.2 10.1 10.1\"");

WriteLiteral("></path>\r\n                                        <path");

WriteLiteral(" d=\"m-187.9 382.4c-2.8 0-5 2.2-5 5 0 2.8 2.2 5 5 5 2.8 0 5-2.2 5-5 0-2.8-2.2-5-5-" +
"5m0 2c1.7 0 3 1.4 3 3 0 1.7-1.3 3-3 3-1.6 0-3-1.3-3-3 0-1.7 1.3-3 3-3\"");

WriteLiteral("></path>\r\n                                    </g>\r\n                             " +
"   </svg>\r\n                                <!-- /ko -->\r\n                       " +
"     </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-selection\"");

WriteLiteral(" data-bind=\"click: image().select.bind(image())\"");

WriteLiteral(">");

            
            #line 130 "..\..\Views\User\EditUser.cshtml"
                                                                                                       Write(UsersGlobalization.EditUser_UploadImage_Button_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n\r\n           " +
"         <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 135 "..\..\Views\User\EditUser.cshtml"
                   Write(Html.Partial("Partial/EditUserRoles"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 139 "..\..\Views\User\EditUser.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591