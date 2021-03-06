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
    
    #line 11 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 12 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
    using Omnicx.WebStore.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Layout1/BlogsByEditor.cshtml")]
    public partial class _Views_Blog_Layout1_BlogsByEditor_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Site.BlogDetailViewModel>
    {
        public _Views_Blog_Layout1_BlogsByEditor_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
  
/*
Name: Blog list of selected editor
Purpose: Blog list of selected editor
Structure: /Views/Blog/Layout1/BlogsByEditor.cshtml
Contains (Partial Views Used):
    a-/Views/Shared/Layout1/_LayoutBlog.cshtml
Contained In (Where we Use this View) :
*/

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
  
    ViewBag.Title = ViewBag.selectedGroup;

    Layout = "~/Views/Shared/Layout1/_LayoutBlog.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    #landing-banner {\r\n        display: none !important;\r\n    }\r\n</sty" +
"le>\r\n<div");

WriteLiteral(" class=\"col-sm-12 margin-top-md\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                   Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 915), Tuple.Create("\"", 950)
            
            #line 31 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 922), Tuple.Create<System.Object, System.Int32>(Url.Action("Blogs", "Blog")
            
            #line default
            #line hidden
, 922), false)
);

WriteLiteral(">");

            
            #line 31 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                              Write(LT("Blogs.Links.Blogs", "Blogs"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        <li> ");

            
            #line 32 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
        Write(ViewBag.selectedGroup);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n");

            
            #line 37 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
         if(@Model.BlogList.Results.Count > 0 && @Model.BlogList != null)
        { 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"blog-homepage\"");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"editor-h1\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                             Write(Model.BlogList.Results[0].Author);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 blog-editor\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 1429), Tuple.Create("\"", 1476)
            
            #line 44 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(Model.BlogList.Results[0].EditorImage
            
            #line default
            #line hidden
, 1438), false)
);

WriteLiteral(" class=\"img-circle\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" />\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"editor-intro\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                               Write(Model.BlogList.Results[0].EditorBio);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n\r\n\r\n        <div");

WriteLiteral(" class=\"col-sm-12 no-padding margin-top-md\"");

WriteLiteral(">\r\n");

            
            #line 52 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
            
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
             foreach (var item in Model.BlogList.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-sm-8 col-md-8 col-md-offset-2 col-sm-offset-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row border-bottom-blog\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                             if (item.BlogImage == null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2140), Tuple.Create("\"", 2204)
            
            #line 59 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create<System.Object, System.Int32>(Url.Action("blogdetail", "blog", new { url = @item.URL})
            
            #line default
            #line hidden
, 2147), false)
);

WriteLiteral("><img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 2210), Tuple.Create("\"", 2261)
, Tuple.Create(Tuple.Create("", 2219), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/noimagefound.jpg")
, 2219), false)
);

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral("></a>\r\n");

            
            #line 60 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2422), Tuple.Create("\"", 2486)
            
            #line 63 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 2429), Tuple.Create<System.Object, System.Int32>(Url.Action("blogdetail", "blog", new { url = @item.URL})
            
            #line default
            #line hidden
, 2429), false)
);

WriteLiteral("><img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 2492), Tuple.Create("\"", 2516)
            
            #line 63 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                 , Tuple.Create(Tuple.Create("", 2501), Tuple.Create<System.Object, System.Int32>(item.BlogImage
            
            #line default
            #line hidden
, 2501), false)
);

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral("></a>\r\n");

            
            #line 64 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-sm-8\"");

WriteLiteral(">\r\n                            <h3");

WriteLiteral(" class=\"blog-h3\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2747), Tuple.Create("\"", 2811)
            
            #line 67 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 2754), Tuple.Create<System.Object, System.Int32>(Url.Action("blogdetail", "blog", new { url = @item.URL})
            
            #line default
            #line hidden
, 2754), false)
);

WriteLiteral(">");

            
            #line 67 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                                                                                               Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></h3>\r\n                            <hr>\r\n                            <p");

WriteLiteral(" class=\"blog-intro\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 70 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                           Write(item.Abstract);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </p>\r\n                            <p");

WriteLiteral(" class=\"blog-category\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 73 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                           Write(item.Days);

            
            #line default
            #line hidden
WriteLiteral(" days ago. By<a");

WriteAttribute("href", Tuple.Create(" href=\"", 3115), Tuple.Create("\"", 3139)
, Tuple.Create(Tuple.Create("", 3122), Tuple.Create("/", 3122), true)
            
            #line 73 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 3123), Tuple.Create<System.Object, System.Int32>(item.EditorSlug
            
            #line default
            #line hidden
, 3123), false)
);

WriteLiteral("> ");

            
            #line 73 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                                                               Write(item.Author);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </p>                          \r\n               " +
"         </div>\r\n                    </div>\r\n                </div>\r\n");

            
            #line 78 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

            
            #line 81 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
        }
        else
        { 

            
            #line default
            #line hidden
WriteLiteral("          <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n            <h3 >No Blog(s) exist.</h3>\r\n        </div>\r\n");

            
            #line 87 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-6 no-padding\"");

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
            
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
             if(@Model.BlogList.Results !=  null && @Model.BlogList.Results.Count > 0)
            { 

            
            #line default
            #line hidden
WriteLiteral("            <ul");

WriteLiteral(" class=\"pull-right pagination\"");

WriteLiteral(">\r\n");

            
            #line 94 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                 if (@Model.BlogList.Total > @Model.PageSize)
                {
                    for (var i = 1; i <= Convert.ToDecimal(@Model.BlogList.Results.Count / @Model.PageSize)+1; i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"ng-scope\"");

WriteLiteral(">\r\n                           \r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4064), Tuple.Create("\"", 4112)
, Tuple.Create(Tuple.Create("", 4071), Tuple.Create("/", 4071), true)
            
            #line 100 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 4072), Tuple.Create<System.Object, System.Int32>(Model.BlogList.Results[0].EditorSlug
            
            #line default
            #line hidden
, 4072), false)
, Tuple.Create(Tuple.Create("", 4109), Tuple.Create("/", 4109), true)
            
            #line 100 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 4110), Tuple.Create<System.Object, System.Int32>(i
            
            #line default
            #line hidden
, 4110), false)
);

WriteLiteral(">");

            
            #line 100 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                                                           Write(i);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                         </li>\r\n");

            
            #line 102 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 104 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                 if (@Model.BlogList.Total == @Model.PageSize)
                {
                    for (var i = 1; i <= Convert.ToDecimal(@Model.BlogList.Results.Count / @Model.PageSize); i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"ng-scope\"");

WriteLiteral(">\r\n                            \r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4524), Tuple.Create("\"", 4572)
, Tuple.Create(Tuple.Create("", 4531), Tuple.Create("/", 4531), true)
            
            #line 110 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 4532), Tuple.Create<System.Object, System.Int32>(Model.BlogList.Results[0].EditorSlug
            
            #line default
            #line hidden
, 4532), false)
, Tuple.Create(Tuple.Create("", 4569), Tuple.Create("/", 4569), true)
            
            #line 110 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
, Tuple.Create(Tuple.Create("", 4570), Tuple.Create<System.Object, System.Int32>(i
            
            #line default
            #line hidden
, 4570), false)
);

WriteLiteral(">");

            
            #line 110 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                                                                           Write(i);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </li>\r\n");

            
            #line 112 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                    }
                }
                
            
            #line default
            #line hidden
            
            #line 120 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
                   

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n");

            
            #line 122 "..\..\Views\Blog\Layout1\BlogsByEditor.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        window.app.constant(\'blogConfig\', {\r\n        });\r\n    </s" +
"cript>\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
