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
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Layout1/_IndexCms.cshtml")]
    public partial class _Views_Page_Layout1__IndexCms_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Site.SiteViewModel>
    {
        public _Views_Page_Layout1__IndexCms_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Page\Layout1\_IndexCms.cshtml"
  
/*
    Name: CMS Home Page
    Purpose: Render CMS generated UI with HTML structure for Home Page
    Structure: /Views/Page/Layout1/_IndexCms.cshtml
    Contains (Partial Views Used): NO Partial View Used
    Contained In (Where we Use this View): /Views/Page/Layout1/Index.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"akc-container-fluid\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Views\Page\Layout1\_IndexCms.cshtml"
Write(Html.Raw(Model.HtmlBody));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
