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
    
    #line 18 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
    using Omnicx.API.SDK.Models;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 19 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_LayoutAccount.cshtml")]
    public partial class _Views_Shared_Layout1__LayoutAccount_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared_Layout1__LayoutAccount_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
  
/*
    Name: Account Layout
    Purpose: Layout for using for Account Section
    Structure: /Views/Shared/Layout1/_LayoutAccount.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_LayoutHeadTag.cshtml
        b-/Views/Shared/Layout1/_LayoutHeader.cshtml
        c-/Views/Blog/Layout1/_BlogNav.cshtml
        d-/Views/Shared/Layout1/_LayoutFooterAccount.cshtml

    Contained In (Where we Use this View):
        a-/Views/Account/Layout1/PasswordChange.cshtml
        b-/Views/Account/Layout1/SignIn.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n");

WriteLiteral("<html");

WriteLiteral(" ng-app=\"btApp\"");

WriteLiteral(" ng-controller=\"globalCtrl as gm\"");

WriteLiteral(" id=\"sidebarFix\"");

WriteLiteral(">\r\n\r\n");

            
            #line 25 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
Write(Html.Partial("~/Views/Shared/Layout1/_LayoutHeadTag.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<body>\r\n    <header");

WriteLiteral(" class=\"siteHeader\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
   Write(Html.Partial("~/Views/Shared/Layout1/_LayoutHeader.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" id=\"all\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
               Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 37 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
          /*Search popup for Mobile View*/
            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"globalSearch\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-dialog modal-xl\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-header text-center\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1646), Tuple.Create("\"", 1692)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/logo-small.png")
, 1652), false)
);

WriteLiteral(" alt=\"OCX Store logo\"");

WriteLiteral(" style=\"margin-top: -10px; margin-left: 15px;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                                                                                                                                                                    Write(LT("Header.Text.GoHome", "OCX Store - go to homepage"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close search-close-btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                                                                                                                                                    Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"modal-body no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                       Write(Html.Partial("~/Views/Shared/Layout1/_SearchBox.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>        \r\n    " +
"</header>\r\n    <div");

WriteLiteral(" class=\"dvloader\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"global-loader\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2595), Tuple.Create("\"", 2637)
, Tuple.Create(Tuple.Create("", 2601), Tuple.Create<System.Object, System.Int32>(Href("~/assets/theme/ocx/images/loader.svg")
, 2601), false)
);

WriteLiteral(" />\r\n        </span>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 62 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
Write(Html.Partial("~/Views/Shared/Layout1/_LayoutFooterAccount.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n               \r\n");

DefineSection("scripts", () => {

            
            #line 64 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
    
            
            #line default
            #line hidden
});

WriteLiteral("    ");

            
            #line 65 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <script>\r\n        var setContactForm = \'");

            
            #line 67 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                          Write(Html.BuildUrlFromExpression<CommonController>(c => c.ContactForm(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getBasketUrl = \'");

            
            #line 68 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                        Write(Html.BuildUrlFromExpression<BasketController>(c => c.GetBasketData()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToBasket = \'");

            
            #line 69 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                       Write(Html.BuildUrlFromExpression<BasketController>(c => c.AddtoBasket(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var signIn = \'");

            
            #line 70 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.SignIn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var register = \'");

            
            #line 71 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                    Write(Html.BuildUrlFromExpression<AccountController>(c => c.Registration(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getShippingMethods = \'");

            
            #line 72 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                              Write(Html.BuildUrlFromExpression<BasketController>(c => c.GetShippingMethods("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var updateShipping = \'");

            
            #line 73 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c => c.UpdateShipping(null,null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var applyPromoCode = \'");

            
            #line 74 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c => c.ApplyPromoCode(null,null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var currencySettingUrl = \'");

            
            #line 75 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                              Write(Html.BuildUrlFromExpression<HomeController>(c => c.UpdateCurrencySetting()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var paymentMethodsUrl = \'");

            
            #line 76 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                             Write(Html.BuildUrlFromExpression<CheckoutController>(c => c.GetPaymentMethods()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var newsLetterSubscription = \'");

            
            #line 77 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.NewsletterSubscription(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var removePromoCode = \'");

            
            #line 78 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                           Write(Html.BuildUrlFromExpression<BasketController>(c => c.RemovePromoCode("","")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var forgotPassword = \'");

            
            #line 79 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                          Write(Html.BuildUrlFromExpression<AccountController>(c => c.ForgotPassword(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var bulkAddproduct = \'");

            
            #line 80 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                          Write(Html.BuildUrlFromExpression<BasketController>(c=> c.BulkAddProduct(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var companyRegisterUrl = \'");

            
            #line 81 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                              Write(Html.BuildUrlFromExpression<B2BController>(c => c.CreateRequest(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getBillingCountriesUrl = \'");

            
            #line 82 "..\..\Views\Shared\Layout1\_LayoutAccount.cshtml"
                                  Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetBillingCountries()));

            
            #line default
            #line hidden
WriteLiteral(@"';
        window.app.constant('globalConfig', {
            setContactForm: setContactForm,
            getBasketUrl: getBasketUrl,
            addToBasket: addToBasket,
            signIn: signIn,
            register: register,
            getShippingMethods: getShippingMethods,
            updateShipping: updateShipping,
            applyPromoCode: applyPromoCode,
            currencySettingUrl: currencySettingUrl,
            paymentMethodsUrl: paymentMethodsUrl,
            newsLetterSubscription: newsLetterSubscription,
            removePromoCode: removePromoCode,
            forgotPassword: forgotPassword,
            bulkAddproduct: bulkAddproduct,
            companyRegisterUrl: companyRegisterUrl,
            getBillingCountriesUrl: getBillingCountriesUrl
        });
    </script>
</body>
</html>
");

        }
    }
}
#pragma warning restore 1591