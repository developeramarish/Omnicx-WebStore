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
    
    #line 13 "..\..\Views\Shared\_Register.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\Shared\_Register.cshtml"
    using Omnicx.WebStore.Models.Commerce;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Register.cshtml")]
    public partial class _Views_Shared__Register_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<UserModel>
    {
        public _Views_Shared__Register_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Register.cshtml"
  
/*
    Name: Registration Modal 
    Purpose: Show Registration Modal
    Structure: /Views/Shared/_SearchBox.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/_LayoutFooter.cshtml        (Link in Footer)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Shared\_Register.cshtml"
  
    var userForm = Html.Angular().ModelFor("gm.model");

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"modal fade modal-absolute\"");

WriteLiteral(" id=\"register-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"register\"");

WriteLiteral(" aria-hidden=\"false\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"Login\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\_Register.cshtml"
                                               Write(LT("Header.Text.UserLogin", "User Registration"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral("  ng-click=\"gm.formReset(registrationForm);gm.model.registerViewModel.email=null;" +
"gm.model.registerViewModel.password =null;gm.model.registerViewModel.confirmPass" +
"word=null\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" name=\"registrationForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" ng-submit=\"gm.registration(gm.model.registerViewModel)\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"gm.errorMessage != null\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" ng-repeat=\"err in gm.errorMessage track by $index\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>&nbsp;<span");

WriteLiteral(" ng-bind=\"err\"");

WriteLiteral("></span>\r\n                            </div>\r\n                        </div>\r\n   " +
"                 </div>                                        \r\n               " +
"     <p");

WriteLiteral(" class=\"login-text\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Shared\_Register.cshtml"
                                     Write(LT("MyAccount.Text.RegisterBenifits", ""));

            
            #line default
            #line hidden
WriteLiteral("</p>                    \r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Views\Shared\_Register.cshtml"
                   Write(userForm.FormGroupFor(x => x.RegisterViewModel.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 40 "..\..\Views\Shared\_Register.cshtml"
                   Write(userForm.FormGroupFor(x => x.RegisterViewModel.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding form-group margin-bottom-sm checkoutForm\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Views\Shared\_Register.cshtml"
                   Write(userForm.FormGroupFor(x => x.RegisterViewModel.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding checkout-button\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 46 "..\..\Views\Shared\_Register.cshtml"
                                                                                                       Write(LT("Global.Buttons.Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding checkout-button\"");

WriteAttribute("ng-if", Tuple.Create(" ng-if=\"", 2967), Tuple.Create("\"", 3053)
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create("\'", 2975), true)
            
            #line 48 "..\..\Views\Shared\_Register.cshtml"
        , Tuple.Create(Tuple.Create("", 2976), Tuple.Create<System.Object, System.Int32>(ViewBag.isB2BEnable
            
            #line default
            #line hidden
, 2976), false)
, Tuple.Create(Tuple.Create("", 2996), Tuple.Create("\'", 2996), true)
, Tuple.Create(Tuple.Create(" ", 2997), Tuple.Create("==", 2998), true)
, Tuple.Create(Tuple.Create(" ", 3000), Tuple.Create("\'True\'", 3001), true)
, Tuple.Create(Tuple.Create(" ", 3007), Tuple.Create("&&", 3008), true)
, Tuple.Create(Tuple.Create(" ", 3010), Tuple.Create("\'", 3011), true)
            
            #line 48 "..\..\Views\Shared\_Register.cshtml"
                                            , Tuple.Create(Tuple.Create("", 3012), Tuple.Create<System.Object, System.Int32>(ViewBag.isRegistrationAllowed
            
            #line default
            #line hidden
, 3012), false)
, Tuple.Create(Tuple.Create("", 3042), Tuple.Create("\'", 3042), true)
, Tuple.Create(Tuple.Create(" ", 3043), Tuple.Create("==", 3044), true)
, Tuple.Create(Tuple.Create(" ", 3046), Tuple.Create("\'True\'", 3047), true)
);

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" ng-click=\"gm.showCompanyForm()\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 49 "..\..\Views\Shared\_Register.cshtml"
                                                                                                                                       Write(LT("Global.Buttons.CompanyAccountRequest", "Request for Company Account"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                    </div>                   \r\n                </form>" +
"\r\n                <p");

WriteLiteral(" class=\"text-center text-muted\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Shared\_Register.cshtml"
                                             Write(LT("Footer.Text.NoAccount", "Already Register?"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <p");

WriteLiteral(" class=\"text-center text-muted\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#login-modal\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" ng-click=\"gm.model={}\"");

WriteLiteral(" class=\"text-black\"");

WriteLiteral("><strong>");

            
            #line 53 "..\..\Views\Shared\_Register.cshtml"
                                                                                                                                                                                                  Write(LT("Footer.Text.RegisterNow", "Login now"));

            
            #line default
            #line hidden
WriteLiteral("</strong></a></p>\r\n            </div> \r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>           \r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
