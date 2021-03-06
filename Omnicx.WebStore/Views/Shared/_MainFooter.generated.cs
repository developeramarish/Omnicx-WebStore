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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_MainFooter.cshtml")]
    public partial class _Views_Shared__MainFooter_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Site.NavigationModel>
    {
        public _Views_Shared__MainFooter_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_MainFooter.cshtml"
  
/*
Name: Footer Menu
Purpose: Show footer menu links and newsletter subscription detail
Structure: /Views/Shared/_MainFooter.cshtml
Contains (Partial Views Used):
Contained In (Where we Use this View) :
 * Shared/_LayoutFooter.cshtml
*/

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

            
            #line 14 "..\..\Views\Shared\_MainFooter.cshtml"
   /*Start Footer*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"footer\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Shared\_MainFooter.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\_MainFooter.cshtml"
      /*Start Footer Top menu and subscription form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" id=\"akc-container-fluid\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 63 "..\..\Views\Shared\_MainFooter.cshtml"
            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Shared\_MainFooter.cshtml"
               if (Model != null)
            {
                if (Model.Footer != null)
                {
                    foreach (var items in @Model.Footer.OrderBy(o => o.DisplayOrder))
                    {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteAttribute("style", Tuple.Create(" style=\"", 2907), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2915), Tuple.Create("width:", 2915), true)
            
            #line 69 "..\..\Views\Shared\_MainFooter.cshtml"
, Tuple.Create(Tuple.Create("", 2921), Tuple.Create<System.Object, System.Int32>(items.WidthPct
            
            #line default
            #line hidden
, 2921), false)
, Tuple.Create(Tuple.Create("", 2936), Tuple.Create("%;", 2936), true)
);

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Views\Shared\_MainFooter.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Shared\_MainFooter.cshtml"
                                 if (@items.NavBlocks != null)
                                {
                                    foreach (var child1 in @items.NavBlocks.OrderBy(o => o.DisplayOrder))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"col-md-2 col-sm-4 col-xs-12 no-padding-left\"");

WriteAttribute("style", Tuple.Create(" style=\"", 3283), Tuple.Create("\"", 3315)
, Tuple.Create(Tuple.Create("", 3291), Tuple.Create("width:", 3291), true)
            
            #line 74 "..\..\Views\Shared\_MainFooter.cshtml"
                              , Tuple.Create(Tuple.Create("", 3297), Tuple.Create<System.Object, System.Int32>(child1.WidthPct
            
            #line default
            #line hidden
, 3297), false)
, Tuple.Create(Tuple.Create("", 3313), Tuple.Create("%;", 3313), true)
);

WriteLiteral(">\r\n");

            
            #line 75 "..\..\Views\Shared\_MainFooter.cshtml"
                                            
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Shared\_MainFooter.cshtml"
                                             if (@child1.NavBlockType == 1)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <h2");

WriteLiteral(" class=\"menu-category-header\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3526), Tuple.Create("\"", 3548)
            
            #line 77 "..\..\Views\Shared\_MainFooter.cshtml"
          , Tuple.Create(Tuple.Create("", 3533), Tuple.Create<System.Object, System.Int32>(child1.ItemIds
            
            #line default
            #line hidden
, 3533), false)
);

WriteLiteral(">");

            
            #line 77 "..\..\Views\Shared\_MainFooter.cshtml"
                                                                                                      Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h2>\r\n");

            
            #line 78 "..\..\Views\Shared\_MainFooter.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <h4");

WriteLiteral(" class=\"footer-h4\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Shared\_MainFooter.cshtml"
                                                                 Write(child1.BoxTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                                                <div");

WriteLiteral(" class=\"akc-footer-line\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                                                <ul");

WriteLiteral(" class=\"footer-menu\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 84 "..\..\Views\Shared\_MainFooter.cshtml"
                                               Write(Html.Raw(child1.ContentBody));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </ul>\r\n");

            
            #line 86 "..\..\Views\Shared\_MainFooter.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                            <hr");

WriteLiteral(" class=\"hidden-md hidden-lg hidden-sm\"");

WriteLiteral(">\r\n                                        </div>\r\n");

            
            #line 89 "..\..\Views\Shared\_MainFooter.cshtml"
                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>\r\n");

            
            #line 92 "..\..\Views\Shared\_MainFooter.cshtml"
                        }
                    }
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 96 "..\..\Views\Shared\_MainFooter.cshtml"
            
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Shared\_MainFooter.cshtml"
              /*Start Footer email subscription form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-6 col-sm-12 col-xs-12 no-padding-right pull-right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-6 no-padding\"");

WriteLiteral(">\r\n                    <h4");

WriteLiteral(" class=\"white newsletter-h3\"");

WriteLiteral(">");

            
            #line 99 "..\..\Views\Shared\_MainFooter.cshtml"
                                               Write(LT("Footer.Label.NewLetterSignUp", "Sign up to our newsletter"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    <p");

WriteLiteral(" class=\"white newsletter-p\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Shared\_MainFooter.cshtml"
                                             Write(LT("Footer.Label.LatestRange", "For the latest ranges, VIP offers and inspiration"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-6 no-padding-right\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-inline text-right margin-top-2 border-xs\"");

WriteLiteral(">\r\n                        <form");

WriteLiteral(" ng-submit=\"gm.newsLetterSubscription(gm.customerEmail)\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"gm.customerEmail\"");

WriteLiteral(" name=\"search\"");

WriteLiteral(" class=\"form-control bottom-textbox\"");

WriteLiteral(" placeholder=\"Enter your email\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"currentPage\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"blog-search-btn\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Shared\_MainFooter.cshtml"
                                                       Write(LT("Footer.Button.SignUp", "Sign Up"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </form>\r\n                    </div>\r\n\r\n       " +
"             ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger newsletteralert\"");

WriteLiteral(" ng-show=\"gm.emailinvalid\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 116 "..\..\Views\Shared\_MainFooter.cshtml"
                               Write(LT("Footer.Label.EnterValidEmail", "Enter a valid email address."));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div ng" +
"-cloak");

WriteLiteral(" class=\"alert alert-success newslettersuccess\"");

WriteLiteral(" ng-show=\"gm.subssuccess\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 119 "..\..\Views\Shared\_MainFooter.cshtml"
                               Write(LT("Footer.Label.SubscribeSuccess", "Subscribed successfully."));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div ng" +
"-cloak");

WriteLiteral(" class=\"alert alert-danger newsletteralready\"");

WriteLiteral(" ng-show=\"gm.alreadySubscribed\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 122 "..\..\Views\Shared\_MainFooter.cshtml"
                               Write(LT("Footer.Label.AlreadySubscribed", "It seems this email is already registered with us. You can use a different email to subscribe for the newsletter."));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </p>\r\n     " +
"                   </div>\r\n                    </div>\r\n                </div>\r\n " +
"           </div>\r\n");

            
            #line 129 "..\..\Views\Shared\_MainFooter.cshtml"
            
            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Shared\_MainFooter.cshtml"
              /*End Footer email subscription form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
