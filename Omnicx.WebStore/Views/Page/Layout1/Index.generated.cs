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
    
    #line 14 "..\..\Views\Page\Layout1\Index.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Page\Layout1\Index.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Layout1/Index.cshtml")]
    public partial class _Views_Page_Layout1_Index_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Site.SiteViewModel>
    {
        public _Views_Page_Layout1_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Page\Layout1\Index.cshtml"
  
/*
    Name: Home Page
    Purpose: WebStore Home Page Call Json or CMS View
    Structure: /Views/Page/Layout1/_IndexJson.cshtml
    Contains (Partial Views Used): 
        a-/Views/Page/Layout1/_IndexJson.cshtml OR      (JSON DATA Customize View)
        b-/Views/Page/Layout1/_IndexCms.cshtml          (CMS View With HTML Render)

    Contained In (Where we Use this View):
        a-/Views/Page/Layout1/Index.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Page\Layout1\Index.cshtml"
  
    var StoreTheme = ConfigKeys.StoreTheme;
    ViewBag.Title = "Home";
    Layout = "~/Views/Shared/Layout1/_LayoutCMS.cshtml";
    Html.AddTitleParts(Model.Title);
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordsParts(Model.MetaKeywords);
    Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.CmsPage, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 28 "..\..\Views\Page\Layout1\Index.cshtml"
Write(Html.Partial("~/Views/Page/Layout1/_IndexJson.cshtml", Model));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591