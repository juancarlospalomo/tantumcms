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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/TemplatesList.cshtml")]
    public partial class _Views_Page_Partial_TemplatesList_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Page_Partial_TemplatesList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-templates-holder\"");

WriteLiteral(" data-bind=\"foreach: templatesList.displayedTemplates\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-grid-box bcms-grid-box-pages bcms-js-grid-box\"");

WriteLiteral(" data-bind=\"css: { \'bcms-grid-box-active\': isActive, \'bcms-grid-box-notcompatible" +
"\': isCircularToCurrent }\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(" data-bind=\"text: title\"");

WriteLiteral("></div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-grid-image-holder\"");

WriteLiteral(">\r\n            <!-- ko if: previewThumbnailUrl || previewUrl -->\r\n            <di" +
"v");

WriteLiteral(" class=\"bcms-grid-image\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-bind=\"attr: { src: previewThumbnailUrl || previewUrl, alt: title }\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-zoom-overlay bcms-preview-template\"");

WriteLiteral(" data-bind=\"click: previewImage\"");

WriteLiteral("></div>}\r\n            <!-- /ko -->\r\n            <!-- ko ifnot: previewThumbnailUr" +
"l || previewUrl -->\r\n            <svg");

WriteLiteral(" class=\"bcms-grid-no-preview\"");

WriteLiteral(" viewBox=\"-237.5 336 138 121.5\"");

WriteLiteral(" enable-background=\"new -237.5 336 138 121.5\"");

WriteLiteral(">\r\n                <path");

WriteLiteral(" d=\"m-237 336h137v4h-137v-4\"");

WriteLiteral(" fill=\"#e6e6e6\"");

WriteLiteral(" />\r\n                <g");

WriteLiteral(" fill=\"#fff\"");

WriteLiteral(" stroke=\"#d7d4d4\"");

WriteLiteral(" stroke-linecap=\"square\"");

WriteLiteral(">\r\n                    <path");

WriteLiteral(" d=\"m-237 404h43v27h-43v-27z\"");

WriteLiteral(" />\r\n                    <path");

WriteLiteral(" d=\"m-190 404h43v27h-43v-27z\"");

WriteLiteral(" />\r\n                    <path");

WriteLiteral(" d=\"m-237 437h137v20h-137v-20z\"");

WriteLiteral(" />\r\n                    <path");

WriteLiteral(" d=\"m-143 404h43v27h-43v-27z\"");

WriteLiteral(" />\r\n                    <path");

WriteLiteral(" d=\"m-237 345h137v53h-137v-53z\"");

WriteLiteral(" />\r\n                </g>\r\n            </svg>\r\n            <!-- /ko -->\r\n        " +
"</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-btn-selection bcms-js-grid-box\"");

WriteLiteral(" data-bind=\"click: $root.templatesList.setActive\"");

WriteLiteral(">Select</div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
