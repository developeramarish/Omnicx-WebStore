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
    
    #line 12 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
    
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
    using Omnicx.WebStore.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 13 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/Layout1/_ShippingAddress.cshtml")]
    public partial class _Views_Checkout_Layout1__ShippingAddress_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Commerce.AddressModel>
    {
        public _Views_Checkout_Layout1__ShippingAddress_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
  
/*
    Name: Shipping Address
    Purpose: Shipping Address Form
    Structure: /Views/Checkout/Layout1/_ShippingAddress.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Checkout/Layout1/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
  
    var addressForm = Html.Angular().ModelFor("ck.model.checkout.shippingAddress");
    var userRole = SessionContext.CurrentUserRole;

            
            #line default
            #line hidden
WriteLiteral("\r\n<form");

WriteLiteral(" name=\"shippingForm\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(" novalidate>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(" ng-hide=\"ck.hideShippingAddress\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                <h5");

WriteLiteral(" class=\"margin-top-sm margin-bottom-sm checkout-h5\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
                                                                  Write(LT("Checkout.Label.DeliveryAddress", "Delivery Address"));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-2\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-class=\"vm.getValidationClass()\"");

WriteLiteral(" form-group-validation=\"Title\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"control-label ng-scope\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
                                                                     Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        <select");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" tabindex=\"1\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-label=\"Title\"");

WriteLiteral(" ng-model=\"ck.model.checkout.shippingAddress.title\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                            <option");

WriteLiteral(" ng-selected=\"ck.model.checkout.shippingAddress.title == null\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
                                                                                                      Write(LT("MyAccount.Text.Title", "Title"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                            <option");

WriteLiteral(" value=\"Miss\"");

WriteLiteral(">Miss</option>\r\n                            <option");

WriteLiteral(" value=\"Mr\"");

WriteLiteral(">Mr</option>\r\n                            <option");

WriteLiteral(" value=\"Mrs\"");

WriteLiteral(">Mrs</option>\r\n                        </select>\r\n                    </div>\r\n   " +
"             </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 57 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.row " +
"-->\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 71 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.Address1));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 76 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.Address2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.row " +
"-->\r\n\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 85 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.City));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 90 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.PostCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 95 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6 col-md-3\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 110 "..\..\Views\Checkout\Layout1\_ShippingAddress.cshtml"
               Write(addressForm.FormGroupFor(x => x.PhoneNo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.r" +
"ow -->\r\n    </div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
