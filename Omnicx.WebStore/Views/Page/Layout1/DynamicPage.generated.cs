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
    
    #line 10 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 17 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 16 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Layout1/DynamicPage.cshtml")]
    public partial class _Views_Page_Layout1_DynamicPage_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Site.SiteViewModel>
    {
        public _Views_Page_Layout1_DynamicPage_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
  
/*
    Name: Render CMS Generated Static Pages
    Purpose: Render CMS generated UI with HTML structure of Other Pages Like: About, Career..
    Structure: /Views/Page/Layout1/DynamicPage.cshtml
    Contains (Partial Views Used): /Views/Page/Layout1/_IndexJson.cshtml
    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
  
    ViewBag.Title = @Model.Title;
    Layout = "~/Views/Shared/Layout1/_LayoutCMS.cshtml";

    Html.AddTitleParts(Model.Title);
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordsParts(Model.MetaKeywords);
    Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.CmsPage, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 29 "..\..\Views\Page\Layout1\DynamicPage.cshtml"
Write(Html.Partial("~/Views/Page/Layout1/_IndexJson.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
