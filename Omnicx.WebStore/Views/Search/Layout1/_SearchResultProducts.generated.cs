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
    
    #line 20 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 22 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 23 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 24 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    #line 25 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Layout1/_SearchResultProducts.cshtml")]
    public partial class _Views_Search_Layout1__SearchResultProducts_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Helpers.PaginatedResult<Omnicx.WebStore.Models.Catalog.ProductModel>>
    {
        public _Views_Search_Layout1__SearchResultProducts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
  
/*
    Name: Search Result
    Purpose: Show Product list after search Result
    Structure: /Views/Search/Layout1/_SearchResultProducts.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/Layout1/_SearchFacetsMobile.cshtml
        b-/Views/Search/Layout1/_SearchFacets.cshtml
        c-/Views/Search/Layout1/_SearchTopBar.cshtml
        d-/Views/Search/Layout1/_NoResults.cshtml
        e-/Views/Search/Layout1/_ProductWidget.cshtml
        f-/Views/Search/Layout1/_ProductListWidget.cshtml
        g-/Views/Search/Layout1/_SearchBottomBar.cshtml
        h-/Views/Product/Layout1/_QuickViewModal.cshtml

    Contained In (Where we Use this View):
        a-/Views/Search/Layout1/Search.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n<section");

WriteLiteral(" ng-controller=\"productCtrl as pm\"");

WriteAttribute("ng-init", Tuple.Create(" ng-init=\'", 1177), Tuple.Create("\'", 1297)
, Tuple.Create(Tuple.Create("", 1187), Tuple.Create("pm.initProducts(", 1187), true)
            
            #line 30 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 1203), Tuple.Create<System.Object, System.Int32>(Html.Json(Model)
            
            #line default
            #line hidden
, 1203), false)
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create(");pm.getView=pm.getViewBycookie;pm.getToWishlist(pm.productResponse.results);", 1220), true)
);

WriteLiteral(">\r\n\r\n");

            
            #line 32 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* Start WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-success wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistsaved\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 34 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddToWishlist", "Product added to wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistexistserror\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 37 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AlreadyAddedToWishlist", "Product already added in wishlist"));

            
            #line default
            #line hidden
WriteLiteral("!</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlisterror\"");

WriteLiteral(">\r\n        User <strong>");

            
            #line 40 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                Write(LT("ProductDetail.Message.LoginRequired", "Login Required"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n");

            
            #line 42 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*  End WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 44 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* Start products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 visible-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       Write(Html.Partial("~/Views/Search/Layout1/_SearchFacetsMobile.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-2 filterContainer hidden-xs\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
              
                /* Start left filter grid */
                var listClass = "col-sm-12 col-xs-12";
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 54 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
             if (Model.Results != null && Model.Results.Count != 0 && Model.SearchCriteria.AllowFacet)
            {
                listClass = "col-sm-10 col-xs-12";

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/Layout1/_SearchFacets.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 60 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 61 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* End left filter grid */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2826), Tuple.Create("\"", 2844)
            
            #line 63 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 2834), Tuple.Create<System.Object, System.Int32>(listClass
            
            #line default
            #line hidden
, 2834), false)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 dataContainer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                        <li><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                   Write(LT("ProductListing.Breadcrumb.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 68 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                         if (!string.IsNullOrEmpty(Model.SearchCriteria.FreeText))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 70 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                           Write(Model.SearchCriteria.FreeText);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 71 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 72 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                         if (!string.IsNullOrEmpty(Model.SearchCriteria.BreadCrumb))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 74 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                           Write(Html.Raw(Model.SearchCriteria.BreadCrumb));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 75 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n");

            
            #line 78 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                  
                    if (Model.Images != null && Model.Images.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 clearfix margin-bottom-lg no-padding\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" id=\"carousel-example-generic\"");

WriteLiteral(" class=\"carousel slide omnicomponent component-slider\"");

WriteLiteral(" list-id=\"\"");

WriteLiteral(" list-type=\"\"");

WriteLiteral(" data-ride=\"carousel\"");

WriteLiteral(">\r\n                                <ol");

WriteLiteral(" class=\"carousel-indicators\"");

WriteLiteral(">\r\n\r\n");

            
            #line 85 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                     foreach (var img in Model.Images.Select((index) => new { index }))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" data-target=\"#carousel-example-generic\"");

WriteLiteral(" data-slide-to=\"");

            
            #line 87 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                              Write(img.index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4285), Tuple.Create("\"", 4320)
, Tuple.Create(Tuple.Create("", 4296), Tuple.Create("{active", 4296), true)
, Tuple.Create(Tuple.Create(" ", 4303), Tuple.Create(":", 4304), true)
            
            #line 87 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                  , Tuple.Create(Tuple.Create(" ", 4305), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4306), false)
, Tuple.Create(Tuple.Create("", 4316), Tuple.Create("==0}", 4316), true)
);

WriteLiteral("></li>\r\n");

            
            #line 88 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </ol>\r\n                                <div");

WriteLiteral(" class=\"carousel-inner\"");

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                     foreach (var img in Model.Images.Select((obj, index) => new { index, obj }))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"item\"");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4680), Tuple.Create("\"", 4715)
, Tuple.Create(Tuple.Create("", 4691), Tuple.Create("{active", 4691), true)
, Tuple.Create(Tuple.Create(" ", 4698), Tuple.Create(":", 4699), true)
            
            #line 93 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create(" ", 4700), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4701), false)
, Tuple.Create(Tuple.Create("", 4711), Tuple.Create("==0}", 4711), true)
);

WriteLiteral(">\r\n");

            
            #line 94 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                            
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                             if (img.obj.LinkType == LinkType.Href.GetHashCode().ToString())
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4926), Tuple.Create("\"", 4946)
            
            #line 96 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 4933), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 4933), false)
);

WriteLiteral(">\r\n                                                    <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5006), Tuple.Create("\"", 5027)
            
            #line 97 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 5015), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 5015), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 5028), Tuple.Create("\"", 5062)
, Tuple.Create(Tuple.Create("", 5034), Tuple.Create("Slide", 5034), true)
            
            #line 97 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
         , Tuple.Create(Tuple.Create(" ", 5039), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 5040), false)
, Tuple.Create(Tuple.Create(" ", 5050), Tuple.Create("of", 5051), true)
, Tuple.Create(Tuple.Create(" ", 5053), Tuple.Create("Carousel", 5054), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                        <h2>");

            
            #line 99 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                       Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                        <h3>");

            
            #line 100 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                       Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                        <p>");

            
            #line 101 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                      Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                    </div>\r\n               " +
"                                 </a>\r\n");

            
            #line 104 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5806), Tuple.Create("\"", 5827)
            
            #line 107 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 5815), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 5815), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 5828), Tuple.Create("\"", 5862)
, Tuple.Create(Tuple.Create("", 5834), Tuple.Create("Slide", 5834), true)
            
            #line 107 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
     , Tuple.Create(Tuple.Create(" ", 5839), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 5840), false)
, Tuple.Create(Tuple.Create(" ", 5850), Tuple.Create("of", 5851), true)
, Tuple.Create(Tuple.Create(" ", 5853), Tuple.Create("Carousel", 5854), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                    <h2>");

            
            #line 109 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                   Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                    <h3>");

            
            #line 110 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                   Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                    <p>");

            
            #line 111 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                  Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                    <p>\r\n");

            
            #line 113 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                        
            
            #line default
            #line hidden
            
            #line 113 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                         if (img.obj.LinkType == LinkType.Button.GetHashCode().ToString())
                                                        {

            
            #line default
            #line hidden
WriteLiteral("                                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6582), Tuple.Create("\"", 6602)
            
            #line 115 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 6589), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 6589), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral("> ");

            
            #line 115 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                                 Write(img.obj.ButtonText);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 116 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                        }

            
            #line default
            #line hidden
WriteLiteral("                                                    </p>\r\n                       " +
"                         </div>\r\n");

            
            #line 119 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </div>\r\n");

            
            #line 122 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div><a");

WriteLiteral(" class=\"left carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"prev\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"fa fa-chevron-left\"");

WriteLiteral("></span>\r\n                                </a>\r\n                                <" +
"a");

WriteLiteral(" class=\"right carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"next\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"fa fa-chevron-right\"");

WriteLiteral("></span>\r\n                                </a>\r\n                            </div" +
">\r\n                        </div>\r\n");

            
            #line 131 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                    }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 133 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 133 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 134 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(Html.Partial("~/Views/Search/Layout1/_SearchTopBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 135 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 135 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"row gridView\"");

WriteLiteral(" id=\"view\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 139 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/Layout1/_NoResults.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                    ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"panel-group\"");

WriteLiteral(" id=\"accordion1{{$index}}\"");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(" aria-multiselectable=\"true\"");

WriteLiteral(" ng-repeat=\"grp in pm.productResponse.groupsWithProducts track by $index\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"panel panel-default margin-bottom-lg\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(" id=\"heading1{{$index}}\"");

WriteLiteral(">\r\n                                    <h4");

WriteLiteral(" class=\"panel-title heading-h4\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-parent=\"#accordion1{{$index}}\"");

WriteLiteral(" href=\"#Data1{{$index}}\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(" aria-controls=\"Data{{$index}}\"");

WriteLiteral(" ng-bind=\"grp.groupName\"");

WriteLiteral("></a>\r\n                                    </h4>\r\n");

            
            #line 149 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                     if (Model.ProductGroupModel != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding groupSeparator\"");

WriteLiteral(" ng-hide=\"grp.groupName==\'\'\"");

WriteLiteral(">");

            
            #line 151 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                                                          Write(Html.Raw(Model.ProductGroupModel.GroupSeparator));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 152 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div>\r\n                                <div");

WriteLiteral(" id=\"Data1{{$index}}\"");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"heading1{{$index}}\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"panel-body no-padding no-border\"");

WriteLiteral(">\r\n                                        ");

WriteLiteral("\r\n                                        <div");

WriteLiteral(" class=\"col-md-5ths col-sm-5ths col-xs-5ths col-lg-5ths resultContainerRelated\"");

WriteLiteral(" ng-repeat=\"product in grp.products track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                                            ");

            
            #line 158 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                       Write(Html.Partial("~/Views/Search/Layout1/_ProductWidgetNew.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </div>\r\n                               " +
"     </div>\r\n                                </div>\r\n                           " +
" </div>\r\n                        </div>\r\n                    </div>\r\n           " +
"     </div>\r\n");

            
            #line 166 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 166 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   /*End product listing row*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 168 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 168 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 169 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 169 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                 if (Model.Results != null && Model.Results.Count != 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"margin-top-lg\"");

WriteLiteral(" ng-hide=\"pm.productResponse == null || pm.productResponse.results==null||pm.prod" +
"uctResponse.total==0\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 172 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   Write(Html.Partial("~/Views/Search/Layout1/_SearchBottomBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 174 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 175 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 179 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 179 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* End products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 181 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 181 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*Start Product quick view detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 182 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
Write(Html.Partial("~/Views/Product/Layout1/_QuickViewModal.cshtml", new ProductDetailModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 183 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 183 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*End detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
