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
    
    #line 15 "..\..\Views\Account\Layout1\SignIn.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 16 "..\..\Views\Account\Layout1\SignIn.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Account\Layout1\SignIn.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Account\Layout1\SignIn.cshtml"
    using Omnicx.WebStore.Models.B2B;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Account\Layout1\SignIn.cshtml"
    using Omnicx.WebStore.Models.Commerce;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/SignIn.cshtml")]
    public partial class _Views_Account_Layout1_SignIn_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<UserModel>
    {
        public _Views_Account_Layout1_SignIn_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\SignIn.cshtml"
  
/*
    Name: SignIn or New Customer Registration
    Purpose: SignIn or New Customer Registration
    Structure: /Views/Account/Layout1/Wishlist.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_LayoutAccount.cshtml.cshtml    (For base Structure)
        b-/Views/B2B/Layout1/_Register.cshtml                   (Company Registration Form)

    Contained In (Where we Use this View):
        a-/Views/Shared/Layout1/_HeaderLayout.cshtml        (Link in Top Header Bar)
        b-/Views/Shared/Layout1/_MobileHeaderLayout.cshtml  (Link in Mobile Header)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Account\Layout1\SignIn.cshtml"
  
    var userForm = Html.Angular().ModelFor("gm.model");
    ViewBag.Title = "SignIn";
    Layout = "~/Views/Shared/Layout1/_LayoutAccount.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container dataContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Account\Layout1\SignIn.cshtml"
                           Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li");

WriteLiteral(" ng-if=\"gm.createAccount==false\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                               Write(LT("MyAccount.Text.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" ng-if=\"gm.createAccount==true\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                              Write(LT("Login.Text.NewAccount", "New User Registration"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"checkoutStepLogin\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <section");

WriteLiteral(" class=\"checkout-accordion\"");

WriteAttribute("ng-init", Tuple.Create(" ng-init=\"", 1712), Tuple.Create("\"", 1812)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create("gm.loginAccount=\'", 1722), true)
            
            #line 44 "..\..\Views\Account\Layout1\SignIn.cshtml"
, Tuple.Create(Tuple.Create("", 1739), Tuple.Create<System.Object, System.Int32>(Model.isLogin
            
            #line default
            #line hidden
, 1739), false)
, Tuple.Create(Tuple.Create("", 1753), Tuple.Create("\';gm.createAccount=!\'", 1753), true)
            
            #line 44 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                 , Tuple.Create(Tuple.Create("", 1774), Tuple.Create<System.Object, System.Int32>(Model.isLogin
            
            #line default
            #line hidden
, 1774), false)
, Tuple.Create(Tuple.Create("", 1788), Tuple.Create("\';gm.getSocialSettings()", 1788), true)
);

WriteLiteral(">\r\n");

            
            #line 45 "..\..\Views\Account\Layout1\SignIn.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Account\Layout1\SignIn.cshtml"
                      /*Registration Form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div>\r\n                        <input");

WriteLiteral(" id=\"ac-2\"");

WriteLiteral(" name=\"accordion-1\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" class=\"visible-xs\"");

WriteLiteral(" />\r\n                        <label");

WriteLiteral(" class=\"label-ac visible-xs\"");

WriteLiteral(" for=\"ac-2\"");

WriteLiteral(" ng-click=\"gm.loginAccount=false;gm.createAccount=true;\"");

WriteLiteral("> Create an account</label>\r\n                        <article");

WriteLiteral(" class=\"ac-large\"");

WriteLiteral(" ng-hide=\"gm.createAccount==false\"");

WriteLiteral(">\r\n                            <form");

WriteLiteral(" name=\"registrationForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"gm.registration(gm.model.registerViewModel)\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n                                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" ng-repeat=\"err in gm.errorMessage track by $index\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                        </div>\r\n                       " +
"             </div>\r\n                                </div>\r\n                   " +
"             <h2");

WriteLiteral(" class=\"checkout-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                             Write(LT("Checkout.Text.Login", "Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral("><strong>");

            
            #line 59 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                   Write(LT("MyAccount.Text.NotRegister", "Not our registered customer yet?"));

            
            #line default
            #line hidden
WriteLiteral("</strong></p>\r\n                                <p>");

            
            #line 60 "..\..\Views\Account\Layout1\SignIn.cshtml"
                              Write(LT("MyAccount.Text.RegisterBenifits", "Registration with us will introduce to a world of fashion, fantastic discounts and much more! Registration will take only a couple of minutes!"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                 Write(LT("MyAccount.Text.FeelFree", "If you have any questions, please feel free to "));

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                                                                                              Write(LT("MyAccount.Text.ContactUs", "Contact Us"));

            
            #line default
            #line hidden
WriteLiteral(",</a> ");

            
            #line 61 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                                                                                                                                                 Write(LT("MyAccount.Text.Support", " , our customer service center is working for you 24/7."));

            
            #line default
            #line hidden
WriteLiteral(".</p>\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 63 "..\..\Views\Account\Layout1\SignIn.cshtml"
                               Write(userForm.FormGroupFor(x => x.RegisterViewModel.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 66 "..\..\Views\Account\Layout1\SignIn.cshtml"
                               Write(userForm.FormGroupFor(x => x.RegisterViewModel.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 69 "..\..\Views\Account\Layout1\SignIn.cshtml"
                               Write(userForm.FormGroupFor(x => x.RegisterViewModel.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-center no-padding checkout-button\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 72 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                                                           Write(LT("Global.Buttons.Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                    <a");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" ng-click=\"gm.loginAccount=true;gm.createAccount=false;gm.errorMessage=null;\"");

WriteLiteral(">Login Here</a>\r\n                                </div>\r\n                        " +
"        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-center no-padding checkout-button\"");

WriteAttribute("ng-if", Tuple.Create(" ng-if=\"", 5003), Tuple.Create("\"", 5089)
, Tuple.Create(Tuple.Create("", 5011), Tuple.Create("\'", 5011), true)
            
            #line 75 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                , Tuple.Create(Tuple.Create("", 5012), Tuple.Create<System.Object, System.Int32>(ViewBag.isB2BEnable
            
            #line default
            #line hidden
, 5012), false)
, Tuple.Create(Tuple.Create("", 5032), Tuple.Create("\'", 5032), true)
, Tuple.Create(Tuple.Create(" ", 5033), Tuple.Create("==", 5034), true)
, Tuple.Create(Tuple.Create(" ", 5036), Tuple.Create("\'True\'", 5037), true)
, Tuple.Create(Tuple.Create(" ", 5043), Tuple.Create("&&", 5044), true)
, Tuple.Create(Tuple.Create(" ", 5046), Tuple.Create("\'", 5047), true)
            
            #line 75 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 5048), Tuple.Create<System.Object, System.Int32>(ViewBag.isRegistrationAllowed
            
            #line default
            #line hidden
, 5048), false)
, Tuple.Create(Tuple.Create("", 5078), Tuple.Create("\'", 5078), true)
, Tuple.Create(Tuple.Create(" ", 5079), Tuple.Create("==", 5080), true)
, Tuple.Create(Tuple.Create(" ", 5082), Tuple.Create("\'True\'", 5083), true)
);

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" ng-click=\"gm.showCompanyForm()\"");

WriteLiteral(" class=\"animate btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 76 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                                                                                           Write(LT("Global.Buttons.CompanyAccountRequest", "Request for Company Account"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                </div>\r\n                            </" +
"form>\r\n                        </article>\r\n                    </div>\r\n");

            
            #line 81 "..\..\Views\Account\Layout1\SignIn.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Account\Layout1\SignIn.cshtml"
                      /*Login Form*/
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div>\r\n                        <input");

WriteLiteral(" id=\"ac-1\"");

WriteLiteral(" name=\"accordion-1\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" checked");

WriteLiteral(" class=\"visible-xs\"");

WriteLiteral(" />\r\n                        <label");

WriteLiteral(" class=\"label-ac visible-xs\"");

WriteLiteral(" for=\"ac-1\"");

WriteLiteral(" ng-click=\"gm.loginAccount=true;gm.createAccount=false;\"");

WriteLiteral("> Login. <span>Already a customer?</span></label>\r\n                        <artic" +
"le");

WriteLiteral(" class=\"ac-large\"");

WriteLiteral(" ng-show=\"gm.createAccount==false\"");

WriteLiteral(">\r\n                            <form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"gm.login(gm.model.loginViewModel)\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" novalidate>\r\n                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" ng-repeat=\"err in gm.errorMessage track by $index\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                                    </div>\r\n                           " +
"     </div>\r\n                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.isValiduser\"");

WriteLiteral(">\r\n                                    <div>\r\n                                   " +
"     <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span>");

            
            #line 94 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                           Write(LT("Login.Message.InvalidUser", "Invalid User!"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" ng-show=\"gm.isValid\"");

WriteLiteral(">\r\n                                    <div>\r\n                                   " +
"     <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span>");

            
            #line 99 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                           Write(LT("Login.Message.ResetPassword", "Link to reset your password sent"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    </div>\r\n                            " +
"    </div>\r\n                                <h2");

WriteLiteral(" class=\"checkout-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 102 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                             Write(LT("Checkout.Text.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                <p");

WriteLiteral(" class=\"lead hidden-xs\"");

WriteLiteral(">");

            
            #line 103 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                     Write(LT("MyAccount.Text.ExistingCustomer", "Already our customer?"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 106 "..\..\Views\Account\Layout1\SignIn.cshtml"
                               Write(userForm.FormGroupFor(x => x.LoginViewModel.Username));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 109 "..\..\Views\Account\Layout1\SignIn.cshtml"
                               Write(userForm.FormGroupFor(x => x.LoginViewModel.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"checkout-label\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keep\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> <span>Keep me signed in</span>\r\n                                    </label>\r" +
"\n                                </div>\r\n                                <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding\"");

WriteLiteral(">\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8355), Tuple.Create("\"", 8402)
            
            #line 117 "..\..\Views\Account\Layout1\SignIn.cshtml"
, Tuple.Create(Tuple.Create("", 8362), Tuple.Create<System.Object, System.Int32>(Url.Action("forgotpassword", "account")
            
            #line default
            #line hidden
, 8362), false)
);

WriteLiteral(" class=\"checkout-link\"");

WriteLiteral(">Forgot Password</a>\r\n                                </div>\r\n                   " +
"             <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-center no-padding checkout-button\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">");

            
            #line 120 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                                                                 Write(LT("Global.Buttons.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></button>\r\n                                    <a");

WriteLiteral(" class=\"animate btn-default\"");

WriteLiteral(" ng-click=\"gm.loginAccount=false;gm.createAccount=true;gm.errorMessage=null;\"");

WriteLiteral(">Create an Account</a>\r\n                                </div>\r\n                 " +
"               <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding group-divider hidden-xs margin-bottom-sm\"");

WriteLiteral(" ng-show=\"gm.model.socialSettings.GooglePlusEnabled || gm.model.socialSettings.Fa" +
"cebookEnabled || gm.model.socialSettings.TwitterEnabled\"");

WriteLiteral(">\r\n                                    <span>Or Login With</span>\r\n              " +
"                  </div>\r\n                                <div");

WriteLiteral(" class=\"col-xs-4 no-padding margin-bottom-sm\"");

WriteLiteral(" ng-show=\"gm.model.socialSettings.FacebookEnabled\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-fb\"");

WriteLiteral(" ng-click=\"gm.socialSignIn(\'Facebook\')\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i>Facebook</button>\r\n                                </div>\r\n                 " +
"               <div");

WriteLiteral(" class=\"col-xs-4 no-padding\"");

WriteLiteral(" ng-show=\"gm.model.socialSettings.TwitterEnabled\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-twitter\"");

WriteLiteral(" ng-click=\"gm.socialSignIn(\'Twitter\')\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i>Twitter</button>\r\n                                </div>\r\n                  " +
"              <div");

WriteLiteral(" class=\"col-xs-4 no-padding\"");

WriteLiteral(" ng-show=\"gm.model.socialSettings.GooglePlusEnabled\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-google\"");

WriteLiteral(" ng-click=\"gm.socialSignIn(\'Google\')\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-google\"");

WriteLiteral("></i>Google</button>\r\n                                </div>\r\n                   " +
"         </form>\r\n                        </article>\r\n                    </div>" +
"\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</" +
"div>\r\n");

            
            #line 143 "..\..\Views\Account\Layout1\SignIn.cshtml"
Write(Html.Partial("~/Views/B2B/Layout1/_Register.cshtml", new CompanyRegisterModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var signIn = \'");

            
            #line 147 "..\..\Views\Account\Layout1\SignIn.cshtml"
                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var register = \'");

            
            #line 148 "..\..\Views\Account\Layout1\SignIn.cshtml"
                    Write(Html.BuildUrlFromExpression<AccountController>(c => c.Registration(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        window.app.constant(\'accountConfig\', {\r\n            signIn: signIn,\r\n" +
"            register: register,\r\n        });\r\n        window.app.constant(\'model" +
"\', ");

            
            #line 153 "..\..\Views\Account\Layout1\SignIn.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
