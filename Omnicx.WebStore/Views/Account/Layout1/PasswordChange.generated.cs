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
    
    #line 16 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 17 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/PasswordChange.cshtml")]
    public partial class _Views_Account_Layout1_PasswordChange_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.CustomerProfileModel>
    {
        public _Views_Account_Layout1_PasswordChange_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
  
/*
    Name: Change Password
    Purpose: Change Password View
    Structure: /Views/Account/Layout1/PasswordChange.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_LayoutAccount.cshtml.cshtml    (For base Structure)
        b-/Views/B2B/Layout1/_Register.cshtml                   (Company Registration Form)
        c-/Views/Account/Layout1/_AccountAlert.cshtml           (Show Validation Messages)

    Contained In (Where we Use this View):
        a-/Views/Shared/Layout1/_HeaderLayout.cshtml        (Link in Top Header Bar)
        b-/Views/Shared/Layout1/_MobileHeaderLayout.cshtml  (Link in Mobile Header)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
  
    var customerAccountForm = Html.Angular().ModelFor("am.model");
    ViewBag.Title = "Change Password";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    var userRole = SessionContext.CurrentUserRole;


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<section");

WriteLiteral(" class=\"container dataContainer\"");

WriteLiteral(" ng-controller=\"accountCtrl as am\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                           Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li>");

            
            #line 37 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
               Write(LT("MyAccount.Text.ChangePassword", "Change Password"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    \r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-xs-12 visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n");

WriteLiteral("           ");

            
            #line 44 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
      Write(Html.Partial("~/Views/Account/Layout1/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("           \r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
       Write(Html.Partial("~/Views/Account/Layout1/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(" id=\"customer-account\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"panel-h2\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                                    Write(LT("MyAccount.Text.ChangePassword", "Change Password"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" name=\"changePasswordForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"am.changePassword(am.model.changePasswordViewModel,changePasswordForm" +
")\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" novalidate>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(" ng-show=\"changepass\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 59 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                       Write(Html.Partial("~/Views/Account/Layout1/_AccountAlert.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 65 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                           Write(customerAccountForm.FormGroupFor(x => x.ChangePasswordViewModel.OldPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 72 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                           Write(customerAccountForm.FormGroupFor(x => x.ChangePasswordViewModel.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 77 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                           Write(customerAccountForm.FormGroupFor(x => x.ChangePasswordViewModel.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                    <!-- /.row -->\r\n\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-right\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>");

            
            #line 85 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                                                                                                   Write(LT("MyAccount.Button.SetPassword", " Save new password"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </form>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r" +
"\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var passwordChangeUrl = \'");

            
            #line 99 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                             Write(Html.BuildUrlFromExpression<AccountController>(c => c.ChangePassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        window.app.constant(\'accountConfig\', {\r\n            passwordChangeUrl" +
" : passwordChangeUrl\r\n        });\r\n        window.app.constant(\'model\', ");

            
            #line 103 "..\..\Views\Account\Layout1\PasswordChange.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
