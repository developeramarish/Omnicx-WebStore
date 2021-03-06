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
    
    #line 12 "..\..\Views\Product\_ProductReviewLogin.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Product\_ProductReviewLogin.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_ProductReviewLogin.cshtml")]
    public partial class _Views_Product__ProductReviewLogin_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<ProductReviewLoginModel>
    {
        public _Views_Product__ProductReviewLogin_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\_ProductReviewLogin.cshtml"
  
/*
    Name: Login Form for Review
    Purpose: Login Form for Review
    Structure: /Views/Product/_ProductReviewLogin.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Product/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Product\_ProductReviewLogin.cshtml"
  
    var userForm = Html.Angular().ModelFor("pm.model");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- Modal -->\r\n<div");

WriteLiteral(" id=\"productReviewLogin\"");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog review-login-dialog\"");

WriteLiteral(">\r\n        <!-- Modal content-->\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                <h4");

WriteLiteral(" class=\"modal-title text-bold\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Login</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n                            <h5>");

            
            #line 31 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                           Write(LT("ProductReview.Label.ExistingCustomer", "Existing Customer"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p>");

            
            #line 32 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                          Write(LT("ProductReview.Label.AlreadyRegistered", "Already registered with us? Enter your email and password below"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <form");

WriteLiteral(" ng-submit=\"pm.userLogin(pm.model.login)\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" ng-show=\"pm.loginErrors\"");

WriteLiteral(">\r\n                                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"pm.errorMessage != null\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" ng-repeat=\"err in pm.errorMessage track by $index\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                        </div>\r\n                       " +
"             </div>\r\n                                </div>\r\n                   " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" novalidate>\r\n");

WriteLiteral("                                    ");

            
            #line 42 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                               Write(userForm.FormGroupFor(x => x.Login.Username));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 45 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                               Write(userForm.FormGroupFor(x => x.Login.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div>\r\n" +
"                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 49 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                                   Write(LT("ProductReview.Label.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </button>\r\n                                " +
"</div>\r\n                            </form>\r\n                        </div>\r\n   " +
"                     <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n                            <h5>");

            
            #line 55 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                           Write(LT("ProductReview.Label.Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p>");

            
            #line 56 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                          Write(LT("ProductReview.Label.NoAccount", "Do not have an account? Register with us."));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <form");

WriteLiteral(" ng-submit=\"pm.registration(pm.model.register)\"");

WriteLiteral(" novalidate>\r\n                                <div");

WriteLiteral(" ng-show=\"pm.registerErrors\"");

WriteLiteral(">\r\n                                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"pm.errorMessage != null\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" ng-repeat=\"err in pm.errorMessage track by $index\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                        </div>\r\n                       " +
"             </div>\r\n                                </div>\r\n                   " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 66 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                               Write(userForm.FormGroupFor(x => x.Register.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 69 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                               Write(userForm.FormGroupFor(x => x.Register.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 72 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                               Write(userForm.FormGroupFor(x => x.Register.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                    <label>\r\n                                 " +
"       <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keep\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> ");

            
            #line 76 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                                                                                   Write(LT("ProductReview.Label.SendPromotions", "Yes, please send me money-off discounts & promotions"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </label>\r\n                                <" +
"/div>\r\n                                <div>\r\n                                  " +
"  <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 81 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                                   Write(LT("ProductReview.Label.Registration", "Registration"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </button>\r\n                                " +
"</div>\r\n                            </form>\r\n                        </div>\r\n   " +
"                     <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n                            <h5>");

            
            #line 87 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                           Write(LT("ProductReview.Label.ReviewAsGuest", "Review as a Guest"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p>");

            
            #line 88 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                          Write(LT("ProductReview.Label.WriteReviewAsGuest", "Write a review as a guest, no login required."));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <hr />\r\n                            <p>");

            
            #line 90 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                          Write(LT("ProductReview.Message.Note", "Please note - reviews won't be saved against your account, so you won't be eligible for any prize draws."));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <button");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(" ng-click=\"pm.writeReview = true;pm.reviewAsGuest();\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">");

            
            #line 91 "..\..\Views\Product\_ProductReviewLogin.cshtml"
                                                                                                                                     Write(LT("ProductReview.Label.ReviewAsGuest", "Review As Guest"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
