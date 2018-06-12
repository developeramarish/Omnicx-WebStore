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
    
    #line 13 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
    using Omnicx.API.SDK.Models.Common;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
    using Omnicx.API.SDK.Payments.Entities;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/Layout1/_CheckoutPaymentMethod.cshtml")]
    public partial class _Views_Checkout_Layout1__CheckoutPaymentMethod_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<CheckoutViewModel>
    {
        public _Views_Checkout_Layout1__CheckoutPaymentMethod_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
  
/*
    Name: Standard Checkout Payment Method
    Purpose: Show All Payment Methods
    Structure: /Views/Checkout/Layout1/_CheckoutPaymentMethod.cshtml
    Contains (Partial Views Used):
        b-/Views/Checkout/Layout1/_CheckoutBillingAddress.cshtml   (Select Delivery Address)

    Contained In (Where we Use this View):
        a-/Views/Basket/Layout1/StandardCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
  
    var masterCard = Model.Checkout.PaymentOptions.FirstOrDefault(x => x.SystemName == PaymentMethodTypes.MasterCard.ToString());
    if (masterCard != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteAttribute("src", Tuple.Create(" src=\"", 763), Tuple.Create("\"", 890)
, Tuple.Create(Tuple.Create("", 769), Tuple.Create("https://secure.eu.tnspayments.com/form/version/", 769), true)
            
            #line 20 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
, Tuple.Create(Tuple.Create("", 816), Tuple.Create<System.Object, System.Int32>(masterCard.Version
            
            #line default
            #line hidden
, 816), false)
, Tuple.Create(Tuple.Create("", 835), Tuple.Create("/merchant/", 835), true)
            
            #line 20 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                  , Tuple.Create(Tuple.Create("", 845), Tuple.Create<System.Object, System.Int32>(masterCard.AccountCode
            
            #line default
            #line hidden
, 845), false)
, Tuple.Create(Tuple.Create("", 868), Tuple.Create("/session.js?debug=true", 868), true)
);

WriteLiteral("></script>\r\n");

            
            #line 21 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-show=\"ck.showPaymentOption\"");

WriteLiteral(" ng-init=\"ck.showPaymentOption=false\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"checkout-h2\"");

WriteLiteral(">Select a payment method</h2>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepDelivery\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row equal-height-thumbnailAcco\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(" ng-repeat=\"paymentMethod in ck.model.checkout.paymentOptions\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkout-method\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"control control--radio\"");

WriteLiteral(">\r\n                                    <strong");

WriteLiteral(" ng-bind=\"paymentMethod.displayName\"");

WriteLiteral("></strong>\r\n                                    <span");

WriteLiteral(" class=\"label-span-desc\"");

WriteLiteral(" ng-bind=\"paymentMethod.description\"");

WriteLiteral("></span>\r\n                                    <input");

WriteLiteral(" id=\"payment\"");

WriteLiteral(" name=\"payment\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"{{paymentMethod.slug}}\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-click=\"ck.errors=false;ck.payment(paymentMethod);\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                                </label>\r\n                            </" +
"div>\r\n                        </div>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"ck.errors\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 46 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                       Write(LT("Checkout.Text.SelectPayment", "Select a Payment Method"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 49 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                      
                        foreach (var payment in Model.Checkout.PaymentOptions)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12 img-rounded\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 2750), Tuple.Create("\"", 2827)
, Tuple.Create(Tuple.Create("", 2760), Tuple.Create("ck.model.checkout.selectedPayment.systemName==\'", 2760), true)
            
            #line 52 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                                , Tuple.Create(Tuple.Create("", 2807), Tuple.Create<System.Object, System.Int32>(payment.SystemName
            
            #line default
            #line hidden
, 2807), false)
, Tuple.Create(Tuple.Create("", 2826), Tuple.Create("\'", 2826), true)
);

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                 if (payment.SystemName == PaymentMethodTypes.MasterCard.ToString())
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <form");

WriteLiteral(" name=\"paymetForm\"");

WriteLiteral(" class=\"payment-box\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                <label");

WriteLiteral(" class=\"mastercard-label\"");

WriteLiteral(">Card Number</label>\r\n                                                <span");

WriteLiteral(" class=\"icon-credit-card icon-abso\"");

WriteLiteral("></span>\r\n                                                <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"card-number\"");

WriteLiteral(" class=\"form-control mastercard-textbox\"");

WriteLiteral(" onkeyup=\"removeClass(this)\"");

WriteLiteral(" placeholder=\"Card Number\"");

WriteLiteral(" value=\" \"");

WriteLiteral(" readonly required />\r\n                                                <span");

WriteLiteral(" id=\"card-numberError\"");

WriteLiteral(" style=\"margin-top:-10px; display:none;\"");

WriteLiteral(" class=\"help-block for-validated-control has-error margin-bottom-sm\"");

WriteLiteral(">Required</span>\r\n                                            </div>\r\n           " +
"                             </div>\r\n                                        <di" +
"v");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding-left\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                <label");

WriteLiteral(" class=\"mastercard-label\"");

WriteLiteral(">Expiry Month</label>\r\n                                                <span");

WriteLiteral(" class=\"icon-calendar icon-abso\"");

WriteLiteral("></span>\r\n                                                <select");

WriteLiteral(" class=\"mastercard-textbox form-control\"");

WriteLiteral(" name=\"expiry-month\"");

WriteLiteral(" id=\"expiry-month\"");

WriteLiteral(" onchange=\"removeClass(this)\"");

WriteLiteral(">\r\n                                                    <option");

WriteLiteral(" value=\"00\"");

WriteLiteral(">MM</option>\r\n                                                    <option");

WriteLiteral(" value=\"01\"");

WriteLiteral(">01</option>\r\n                                                    <option");

WriteLiteral(" value=\"02\"");

WriteLiteral(">02</option>\r\n                                                    <option");

WriteLiteral(" value=\"03\"");

WriteLiteral(">03</option>\r\n                                                    <option");

WriteLiteral(" value=\"04\"");

WriteLiteral(">04</option>\r\n                                                    <option");

WriteLiteral(" value=\"05\"");

WriteLiteral(">05</option>\r\n                                                    <option");

WriteLiteral(" value=\"06\"");

WriteLiteral(">06</option>\r\n                                                    <option");

WriteLiteral(" value=\"07\"");

WriteLiteral(">07</option>\r\n                                                    <option");

WriteLiteral(" value=\"08\"");

WriteLiteral(">08</option>\r\n                                                    <option");

WriteLiteral(" value=\"09\"");

WriteLiteral(">09</option>\r\n                                                    <option");

WriteLiteral(" value=\"10\"");

WriteLiteral(">10</option>\r\n                                                    <option");

WriteLiteral(" value=\"11\"");

WriteLiteral(">11</option>\r\n                                                    <option");

WriteLiteral(" value=\"12\"");

WriteLiteral(">12</option>\r\n                                                </select>\r\n        " +
"                                        <span");

WriteLiteral(" id=\"expiry-monthError\"");

WriteLiteral(" style=\"margin-top:-5px; display:none;\"");

WriteLiteral(" class=\"help-block for-validated-control has-error margin-bottom-sm\"");

WriteLiteral(">Required</span>\r\n                                            </div>\r\n           " +
"                             </div>\r\n                                        <di" +
"v");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding-right\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                <label");

WriteLiteral(" class=\"mastercard-label\"");

WriteLiteral(">Expiry Year</label>\r\n                                                <span");

WriteLiteral(" class=\"icon-calendar icon-abso\"");

WriteLiteral("></span>\r\n                                                <select");

WriteLiteral(" name=\"expiry-year\"");

WriteLiteral(" id=\"expiry-year\"");

WriteLiteral(" class=\"col-xs-12 form-control\"");

WriteLiteral(" onchange=\"removeClass(this)\"");

WriteLiteral("></select>\r\n                                                <span");

WriteLiteral(" id=\"expiry-yearError\"");

WriteLiteral(" style=\"margin-top: -5px; display:none;float: left;width: 100%;;\"");

WriteLiteral(" class=\"help-block for-validated-control has-error margin-bottom-sm\"");

WriteLiteral(">Required</span>\r\n                                            </div>\r\n           " +
"                             </div>\r\n                                        <di" +
"v");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" id=\"inputCvv\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                <label");

WriteLiteral(" class=\"mastercard-label\"");

WriteLiteral(">CVV Number</label>\r\n                                                <span");

WriteLiteral(" class=\"icon-credit-card icon-abso\"");

WriteLiteral("></span>\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"security-code\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" maxlength=\"3\"");

WriteLiteral(" max=\"3\"");

WriteLiteral(" onkeyup=\"removeClass(this)\"");

WriteLiteral(" placeholder=\"CVV\"");

WriteLiteral(" readonly required />\r\n                                                <span");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(" class=\"help-block for-validated-control has-error\"");

WriteLiteral(">Invalid or missing</span>\r\n                                            </div>\r\n " +
"                                           <span");

WriteLiteral(" class=\"cvv-span\"");

WriteLiteral(">Find this on the back of your card on the signature strip.</span>\r\n             " +
"                           </div>\r\n                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" id=\"inputCvv\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"icon-user icon-abso\"");

WriteLiteral("></span>\r\n                                                <label");

WriteLiteral(" class=\"mastercard-label\"");

WriteLiteral(">Cardholder Name</label>\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"name-on-card\"");

WriteLiteral(" class=\"form-control \"");

WriteLiteral(" onkeyup=\"removeClass(this)\"");

WriteLiteral(" placeholder=\"Cardholder Name\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" required />\r\n                                                <input");

WriteLiteral(" id=\"save-token\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked=\"checked\"");

WriteLiteral(" />\r\n                                                <span");

WriteLiteral(" id=\"name-on-cardError\"");

WriteLiteral(" style=\"margin-top:-5px; display:none;\"");

WriteLiteral(" class=\"help-block for-validated-control has-error\"");

WriteLiteral(">Required</span>\r\n                                            </div>\r\n           " +
"                             </div>\r\n                                    </form>" +
"\r\n");

            
            #line 113 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                ");

            
            #line 114 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                 if (payment.SystemName == PaymentMethodTypes.Givex.ToString())
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 default-border\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-lg-12 no-padding no-margin\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                                <h5>Please enter your Gift Car" +
"d details</h5>\r\n                                                <hr>\r\n          " +
"                                      <div");

WriteLiteral(" class=\"col-xs-12 col-lg-6\"");

WriteLiteral(">\r\n                                                    <form");

WriteLiteral(" class=\"form-inline margin-bottom-sm ng-pristine ng-valid\"");

WriteLiteral(" ng-init=\"givex.amount=basket.remaingAmt\"");

WriteLiteral(">\r\n                                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                                            <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n                                                                <div");

WriteLiteral(" class=\"input-group-addon border-radius-none\"");

WriteLiteral(">");

            
            #line 125 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                                                                                             Write(payment.AccountCode);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                                                <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control border-radius-none ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"ck.givexCardNo\"");

WriteAttribute("ng-blur", Tuple.Create(" ng-blur=\"", 10031), Tuple.Create("\"", 10130)
, Tuple.Create(Tuple.Create("", 10041), Tuple.Create("ck.model.checkout.selectedPayment.cardInfo.cardNo=\'", 10041), true)
            
            #line 126 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 10092), Tuple.Create<System.Object, System.Int32>(payment.AccountCode
            
            #line default
            #line hidden
, 10092), false)
, Tuple.Create(Tuple.Create("", 10112), Tuple.Create("\'", 10112), true)
, Tuple.Create(Tuple.Create(" ", 10113), Tuple.Create("+", 10114), true)
, Tuple.Create(Tuple.Create(" ", 10115), Tuple.Create("ck.givexCardNo", 10116), true)
);

WriteLiteral(" placeholder=\"CardNo\"");

WriteLiteral("></div>\r\n                                                            </div>\r\n    " +
"                                                        <div");

WriteLiteral(" class=\"input-group margin-top-sm\"");

WriteLiteral(">\r\n                                                                <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control border-radius-none ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"ck.model.checkout.selectedPayment.cardInfo.securityCode\"");

WriteLiteral(" placeholder=\"Security Code\"");

WriteLiteral("></div>\r\n                                                            </div>\r\n    " +
"                                                        <div");

WriteLiteral(" class=\"input-group margin-top-sm\"");

WriteLiteral(">\r\n                                                                <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control border-radius-none ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"ck.model.checkout.selectedPayment.cardInfo.amount\"");

WriteLiteral(" placeholder=\"Amount\"");

WriteLiteral(" only-digits=\"\"");

WriteLiteral(@"></div>
                                                            </div>
                                                        </div>
                                                    </form>

                                                </div>
                                                <div");

WriteLiteral(" class=\"col-xs-12 col-lg-6\"");

WriteLiteral(">\r\n                                                    <div><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"gift-card-back\"");

WriteLiteral("></a></div>\r\n                                                </div>\r\n            " +
"                                </div>\r\n                                        " +
"</div>\r\n                                    </div>\r\n");

            
            #line 144 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"

                                }

            
            #line default
            #line hidden
WriteLiteral("                                <div ng-cloak");

WriteLiteral(" class=\"alert alert-success successBlock\"");

WriteLiteral(" ng-show=\"ck.messageSuccess\"");

WriteLiteral(">\r\n                                    Partial payment of <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.balanceAmount.raw.withTax\"");

WriteLiteral("></span> has been done. You can choose to complete your remaining payment using a" +
"ny other mode.\r\n                                </div>\r\n                        " +
"    </div>\r\n");

            
            #line 150 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <!-- /.row -->\r\n\r\n\r\n\r\n            </div" +
">\r\n\r\n            <!-- /.content -->\r\n            <div");

WriteLiteral(" ng-show=\"ck.hideBillingAddress\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 161 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
           Write(Html.Partial("/Views/Checkout/Layout1/_CheckoutBillingAddress.cshtml", @Model.Checkout.BillingAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"box-footer\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pull-right col-sm-3 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" ng-click=\"ck.viewOrderDetail(ck.billingAddress)\"");

WriteLiteral(" class=\"btn btn-checkout width-full\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 169 "..\..\Views\Checkout\Layout1\_CheckoutPaymentMethod.cshtml"
                   Write(LT("Checkout.Label.OrderSummary", "Continue"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r" +
"\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591