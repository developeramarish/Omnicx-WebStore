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
    
    #line 11 "..\..\Views\Checkout\_BillingAddress.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_BillingAddress.cshtml")]
    public partial class _Views_Checkout__BillingAddress_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.AddressModel>
    {
        public _Views_Checkout__BillingAddress_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_BillingAddress.cshtml"
  
/*
    Name: Billing Address
    Purpose: Show Billing Address Form
    Structure: /Views/Checkout/_BillingAddress.cshtml
    Contains (Partial Views Used):
    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Checkout\_BillingAddress.cshtml"
  
    var addressForm = Html.Angular().ModelFor("ck.model.checkout.billingAddress" + ViewData["prefix"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n<form");

WriteLiteral(" role=\"form\"");

WriteAttribute("name", Tuple.Create(" name=\"", 561), Tuple.Create("\"", 600)
, Tuple.Create(Tuple.Create("", 568), Tuple.Create("billingForm", 568), true)
            
            #line 16 "..\..\Views\Checkout\_BillingAddress.cshtml"
, Tuple.Create(Tuple.Create("", 579), Tuple.Create<System.Object, System.Int32>(ViewData["prefix"]
            
            #line default
            #line hidden
, 579), false)
);

WriteLiteral(" novalidate>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 22 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(LT("Checkout.Label.SameAs", "Billing Address Same As"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Checkout\_BillingAddress.cshtml"
                                                                           Write(LT("Checkout.Label.BillingAdd", "Delivery Address"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <input");

WriteAttribute("id", Tuple.Create(" id=\"", 986), Tuple.Create("\"", 1019)
, Tuple.Create(Tuple.Create("", 991), Tuple.Create("billing", 991), true)
            
            #line 23 "..\..\Views\Checkout\_BillingAddress.cshtml"
, Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(ViewData["prefix"]
            
            #line default
            #line hidden
, 998), false)
);

WriteLiteral(" name=\"billing\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"ck.sameAsBillAddress\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-click=\"ck.setShipAddress(ck.sameAsBillAddress)\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                    </label>\r\n                </div>\r\n            </div>" +
"\r\n        </div>\r\n        <div");

WriteLiteral(" ng-show=\"!ck.sameAsBillAddress\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-class=\"vm.getValidationClass()\"");

WriteLiteral(" form-group-validation=\"Title\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"control-label ng-scope\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Checkout\_BillingAddress.cshtml"
                                                                         Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <select");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.billingAddress.title\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                                <option");

WriteLiteral(" ng-selected=\"ck.model.checkout.billingAddress.title == null\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Checkout\_BillingAddress.cshtml"
                                                                                                         Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                <option");

WriteLiteral(" value=\"Miss\"");

WriteLiteral(">Miss</option>\r\n                                <option");

WriteLiteral(" value=\"Mr\"");

WriteLiteral(">Mr</option>\r\n                                <option");

WriteLiteral(" value=\"Mrs\"");

WriteLiteral(">Mrs</option>\r\n                            </select>\r\n                        </d" +
"iv>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n   " +
"         <!-- /.row -->\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 51 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 56 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
"     <!-- /.row -->\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.Address1));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 70 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.Address2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
"     <!-- /.row -->\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.City));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 84 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.PostCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 89 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">Country</label>\r\n                        <select");

WriteLiteral(" name=\"title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.billingAddress.countryCode\"");

WriteLiteral(">\r\n                            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">");

            
            #line 96 "..\..\Views\Checkout\_BillingAddress.cshtml"
                                        Write(LT("Common.Label.Select", "Select"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 96 "..\..\Views\Checkout\_BillingAddress.cshtml"
                                                                             Write(LT("Checkout.Label.State", "County"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                            <option");

WriteLiteral(" ng-repeat=\"countries in ck.model.billingCountries\"");

WriteLiteral(" value=\"{{countries.twoLetterIsoCode}}\"");

WriteLiteral(" ng-bind=\"countries.name\"");

WriteLiteral("></option>\r\n                        </select>\r\n                    </div>\r\n      " +
"          </div>\r\n\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 104 "..\..\Views\Checkout\_BillingAddress.cshtml"
                   Write(addressForm.FormGroupFor(x => x.PhoneNo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
"     <!-- /.row -->\r\n        </div>\r\n    </div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
