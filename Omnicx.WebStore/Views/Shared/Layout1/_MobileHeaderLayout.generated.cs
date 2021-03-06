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
    
    #line 13 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_MobileHeaderLayout.cshtml")]
    public partial class _Views_Shared_Layout1__MobileHeaderLayout_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared_Layout1__MobileHeaderLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
  
    /*
        Name: Mobile Header
        Purpose: Mobile Site Header UI
        Structure: /Views/Shared/Layout1/_MobileHeaderLayout.cshtml
        Contains (Partial Views Used):

        Contained In (Where we Use this View):
            a-/Views/Shared/Layout1/_LayoutHeader.cshtml
        */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
  

    var checkoutUrl = Url.Action("OnePageCheckout", "Checkout");
    if (ConfigKeys.OnePageCheckout == false)
    {
        checkoutUrl = Url.Action("StandardCheckout", "Checkout");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding visible-xs mobile-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-xs-9\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-xs-9 pull-right text-right no-padding\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
       Write(Html.Action("SiteLogo", "Home", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"col-xs-3 no-padding\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"navbar-buttons text-right\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"right-header\"");

WriteLiteral(">\r\n                <ul>\r\n                    <li");

WriteLiteral(" class=\"shopping-cart cartopen\"");

WriteLiteral(" id=\"shoppingCart\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(" ng-click=\"gm.isShow=!gm.isShow;gm.showBasket(gm.isShow);\"");

WriteLiteral(" title=\"Cart\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-shopping-bag mobile-shopping-bag\"");

WriteLiteral("></i>\r\n                            <span");

WriteLiteral(" class=\"fa fa-shopping-bag-full dot-inline\"");

WriteLiteral(" ng-if=\"gm.basketResponse.lineItems.length > 0\"");

WriteLiteral("></span>\r\n                        </a>\r\n                        <ul");

WriteLiteral(" class=\"submenu-mainmenu cart-group-1\"");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                            <li");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                <ul");

WriteLiteral(" id=\"cartdropdown\"");

WriteLiteral(">\r\n                                    <li");

WriteLiteral(" class=\"single-cart-item clearfix\"");

WriteLiteral(" ng-repeat=\"items in gm.basketResponse.lineItems track by $index\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" ng-if=\"items.parentProductId == gm.emptyGuid\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"cart-img no-border\"");

WriteLiteral(">\r\n                                                    <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                                        <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                    </a>\r\n                    " +
"                            </span>\r\n                                           " +
" </div>\r\n                                            <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"trash-cart\"");

WriteLiteral(">\r\n                                                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"remove\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,0,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i></a>\r\n                                                </span>\r\n             " +
"                                   <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                                    <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                                                    <button");

WriteLiteral(" class=\"btn-cart\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,-1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-minus\"");

WriteLiteral("></i></button>\r\n                                                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" value=\"{{items.qty}}\"");

WriteLiteral(" class=\"cart-text form-control\"");

WriteLiteral(" numbers-Only");

WriteLiteral(" ng-disabled=\"true\"");

WriteLiteral(">\r\n                                                    <button");

WriteLiteral(" class=\"btn-cart\"");

WriteLiteral(" ng-click=\"gm.addToBasket(items.productId,1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral("></i></button>\r\n                                                    <span");

WriteLiteral(" class=\"text-right pull-right\"");

WriteLiteral(@">
                                                        {{items.qty}} x <span>{{items.price.formatted.withTax}}</span>
                                                    </span>
                                                </span>
                                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 padding-sm\"");

WriteLiteral(">\r\n                                                        <strong");

WriteLiteral(" class=\"text-orange\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 4453), Tuple.Create("\"", 4536)
, Tuple.Create(Tuple.Create("", 4463), Tuple.Create("items.displayInBasket", 4463), true)
, Tuple.Create(Tuple.Create(" ", 4484), Tuple.Create("&&", 4485), true)
, Tuple.Create(Tuple.Create(" ", 4487), Tuple.Create("items.itemType", 4488), true)
, Tuple.Create(Tuple.Create(" ", 4502), Tuple.Create("==", 4503), true)
            
            #line 69 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 4505), Tuple.Create<System.Object, System.Int32>(ItemTypes.Bundle.GetHashCode()
            
            #line default
            #line hidden
, 4505), false)
);

WriteLiteral(">");

            
            #line 69 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                                                   Write(LT("YourBag.Text.IncludeComponents", "Included Components:"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                                                        <div");

WriteLiteral(" class=\"row component-row\"");

WriteLiteral(" ng-repeat=\"bundle in gm.basketResponse.lineItems track by $index\"");

WriteLiteral(" ng-if=\"bundle.parentProductId == items.productId\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n                                                            <div");

WriteLiteral(" class=\"col-sm-8 col-xs-8 no-padding\"");

WriteLiteral(">\r\n                                                                <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{bundle.slug}}\"");

WriteLiteral(" ng-bind=\"bundle.name\"");

WriteLiteral("></a>\r\n                                                            </div>\r\n      " +
"                                                      <div");

WriteLiteral(" class=\"col-sm-4 col-xs-4 no-padding-left text-right\"");

WriteLiteral(">\r\n                                                                <strong>");

            
            #line 75 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                   Write(LT("YourBag.Text.Qty", "Qty:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><span");

WriteLiteral(" ng-bind=\"bundle.qty\"");

WriteLiteral(@"></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div");

WriteLiteral(" ng-if=\"items.parentProductId != gm.emptyGuid\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                                                        <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                                            <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                        </a>\r\n                " +
"                                    </span>\r\n                                   " +
"             </div>\r\n                                                <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                                        <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                                                        <span");

WriteLiteral(" class=\"pull-right text-right\"");

WriteLiteral(">");

            
            #line 94 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                       Write(LT("YourBag.Text.Free", "FREE"));

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </li>
                            <li");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                <select");

WriteLiteral(" id=\"deliverydrpdwn\"");

WriteLiteral(" ng-model=\"selectedid\"");

WriteLiteral(" ng-change=\"gm.updateShipping(selectedid)\"");

WriteLiteral(">\r\n                                    <option");

WriteLiteral(" ng-repeat=\"methods in gm.basketResponse.shippingMethods track by $index\"");

WriteLiteral(" ng-selected=\"methods.id == gm.basketResponse.shippingMethodId\"");

WriteLiteral(" ng-model=\"methods.id\"");

WriteLiteral(" id=\"{{methods.id}}\"");

WriteLiteral(" ng-value=\"methods.id\"");

WriteLiteral(" ng-bind=\"methods.displayName +\' \' + \'(\' + methods.price.formatted.withTax + \')\'\"" +
"");

WriteLiteral("></option>\r\n                                </select>\r\n                          " +
"  </li>\r\n                            <li");

WriteLiteral(" class=\"total-amount sub_total_price\"");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 margin-top-sm " +
"no-padding\"");

WriteLiteral(">\r\n                                    <form");

WriteLiteral(" ng-submit=\"gm.applyPromoCode(gm.basketResponse.id,promoCode)\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"input-group basket-coupon-width\"");

WriteLiteral(">\r\n                                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"promoCode\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 8471), Tuple.Create("\"", 8555)
            
            #line 111 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                      , Tuple.Create(Tuple.Create("", 8485), Tuple.Create<System.Object, System.Int32>(LT("YourBag.Text.PlaceHolder.Enterpromotioncode", "Enter Promo Code")
            
            #line default
            #line hidden
, 8485), false)
);

WriteLiteral(" style=\"width: 99%;\"");

WriteLiteral(" />\r\n                                            <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                                                <button");

WriteLiteral(" class=\"btn btn-checkout no-margin\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" ng-click=\"gm.applyPromoCode(gm.basketResponse.id,promoCode)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-gift\"");

WriteLiteral("></i></button>\r\n                                            </span>\r\n            " +
"                                <span ng-cloak");

WriteLiteral(" class=\"alert alert-danger promo pull-left col-lg-12\"");

WriteLiteral(" ng-show=\"gm.invalidpromo\"");

WriteLiteral(">");

            
            #line 115 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                     Write(LT("Checkout.Text.InValidPromoMessage", "PromoCode Invalid!"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                            <span ng-cloak");

WriteLiteral(" class=\"alert alert-success promovalid pull-left col-lg-12\"");

WriteLiteral(" ng-show=\"gm.validpromo\"");

WriteLiteral(">");

            
            #line 116 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                         Write(LT("Checkout.Text.ValidPromoMessage", "Successfully Applied"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                            <span ng-cloak");

WriteLiteral(" class=\"alert alert-danger promonull pull-left col-lg-12\"");

WriteLiteral(" ng-show=\"gm.promonull\"");

WriteLiteral(">");

            
            #line 117 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                      Write(LT("Checkout.Text.NullPromoMessage", "Please enter promo code!"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        </div>\r\n                        " +
"            </form>\r\n                                </div>\r\n                   " +
"             <div");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(" id=\"PromoApplied5\"");

WriteLiteral(" ng-show=\"gm.basketResponse.promotionsApplied.length>0\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                                        <p");

WriteLiteral(" class=\"basket-price\"");

WriteLiteral(">Promotion Applied</p>\r\n                                    </div>\r\n             " +
"                       <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                                        <ul>\r\n                                " +
"            <li");

WriteLiteral(" class=\"no-padding\"");

WriteLiteral(" ng-repeat=\"promotion in gm.basketResponse.promotionsApplied track by $index\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"promoApply\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"gm.removePromoCode(gm.basketResponse.id,promotion.promoCode)\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" ng-bind=\"promotion.name\"");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("></span>\r\n                                                    <i");

WriteLiteral(" class=\"fa fa-remove pull-right promoRemove\"");

WriteLiteral(@"></i>
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <div");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                    <p");

WriteLiteral(" class=\"basket-price\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 138 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                   Write(LT("YourBag.Text.Discount", "Discount"));

            
            #line default
            #line hidden
WriteLiteral(": <span");

WriteLiteral(" class=\"money\"");

WriteLiteral(" data-currency-usd=\"$48.00\"");

WriteLiteral(" data-currency-eur=\"&amp;euro;45.42\"");

WriteLiteral(" data-currency=\"EUR\"");

WriteLiteral(" ng-bind=\"gm.basketResponse.discount.formatted.withTax\"");

WriteLiteral("></span>\r\n                                    </p>\r\n                             " +
"   </div>\r\n                                <div");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                    <p");

WriteLiteral(" class=\"basket-price\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 143 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                   Write(LT("YourBag.Text.GrandTotal", "Order Total"));

            
            #line default
            #line hidden
WriteLiteral(": <span");

WriteLiteral(" class=\"money\"");

WriteLiteral(" data-currency-usd=\"$48.00\"");

WriteLiteral(" data-currency-eur=\"&amp;euro;45.42\"");

WriteLiteral(" data-currency=\"EUR\"");

WriteLiteral(" ng-bind=\"gm.basketResponse.grandTotal.formatted.withTax\"");

WriteLiteral("></span>\r\n                                    </p>\r\n                             " +
"   </div>\r\n\r\n                                <div");

WriteLiteral(" ng-show=\"gm.basketResponse.lineItems.length>0\"");

WriteLiteral(" class=\"sub-total-cart amount shopping-cart__total total col-lg-12 no-padding\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6 no-padding-left\"");

WriteLiteral(">\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 12371), Tuple.Create("\"", 12408)
            
            #line 149 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 12378), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Basket")
            
            #line default
            #line hidden
, 12378), false)
);

WriteLiteral(" class=\"animate btn-bordered\"");

WriteLiteral(">");

            
            #line 149 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                         Write(LT("Header.Link.ViewCart", "View Cart"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                                    </div>\r\n                          " +
"          <div");

WriteLiteral(" class=\"col-sm-6 col-xs-6\"");

WriteLiteral(">\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 12674), Tuple.Create("\"", 12719)
            
            #line 152 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 12681), Tuple.Create<System.Object, System.Int32>(checkoutUrl
            
            #line default
            #line hidden
, 12681), false)
, Tuple.Create(Tuple.Create("", 12693), Tuple.Create("//{{gm.basketResponse.id}}", 12693), true)
);

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(">");

            
            #line 152 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                Write(LT("Checkout.Title.Checkout", "Checkout"));

            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral("></i></a>\r\n                                    </div>\r\n                          " +
"      </div>\r\n                            </li>\r\n                            <li" +
"");

WriteLiteral(" ng-hide=\"gm.basketResponse.lineItems.length > 0\"");

WriteLiteral(">\r\n                                <p");

WriteLiteral(" class=\"no-item\"");

WriteLiteral(">Your Bag is empty.</p>\r\n                            </li>\r\n                     " +
"   </ul>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n" +
"            <div");

WriteLiteral(" class=\"right-header\"");

WriteLiteral(">\r\n                <ul>\r\n                    <li");

WriteLiteral(" class=\"shopping-cart\"");

WriteLiteral(" id=\"accountDrop\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(" ng-click=\"gm.isShowAccount=!gm.isShowAccount;gm.showAccount(gm.isShowAccount);\"");

WriteLiteral(" title=\"Account\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-user mobile-shopping-bag\"");

WriteLiteral("></i>\r\n                        </a>\r\n                        <span");

WriteLiteral(" class=\"arrow-top\"");

WriteLiteral("></span>\r\n                        <ul");

WriteLiteral(" class=\"submenu-mainmenu cart-group-1 accountDropRight\"");

WriteLiteral(" id=\"accountList\"");

WriteLiteral(">\r\n");

            
            #line 171 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 171 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                             if (SessionContext.CurrentUser != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i> <span");

WriteLiteral(" class=\"text-capitalize mincharName\"");

WriteLiteral("> ");

            
            #line 175 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                         Write(SessionContext.CurrentUser.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 175 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                               Write(SessionContext.CurrentUser.LastName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    </a>\r\n                              " +
"  </li>\r\n");

            
            #line 178 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 179 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                             if (SessionContext.CurrentUser != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 14425), Tuple.Create("\"", 14466)
            
            #line 181 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 14432), Tuple.Create<System.Object, System.Int32>(Url.Action("Wishlist", "Account")
            
            #line default
            #line hidden
, 14432), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i> Wishlist</a></li>\r\n");

WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 14553), Tuple.Create("\"", 14598)
            
            #line 182 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 14560), Tuple.Create<System.Object, System.Int32>(Url.Action("OrderHistory", "Account")
            
            #line default
            #line hidden
, 14560), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-basket\"");

WriteLiteral("></i> Orders</a></li>\r\n");

WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 14693), Tuple.Create("\"", 14735)
            
            #line 183 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 14700), Tuple.Create<System.Object, System.Int32>(Url.Action("MyAccount", "Account")
            
            #line default
            #line hidden
, 14700), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-gear\"");

WriteLiteral("></i> Account</a></li>\r\n");

WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 14820), Tuple.Create("\"", 14859)
            
            #line 184 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 14827), Tuple.Create<System.Object, System.Int32>(Url.Action("Logout", "Account")
            
            #line default
            #line hidden
, 14827), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-out\"");

WriteLiteral("></i> Logout</a></li>\r\n");

            
            #line 185 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 15043), Tuple.Create("\"", 15082)
            
            #line 188 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
, Tuple.Create(Tuple.Create("", 15050), Tuple.Create<System.Object, System.Int32>(Url.Action("SignIn", "Account")
            
            #line default
            #line hidden
, 15050), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-in\"");

WriteLiteral("></i> Sign in</a></li>\r\n");

            
            #line 189 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n                </ul>" +
"\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"right-header\"");

WriteLiteral(">\r\n                <ul>\r\n                    <li");

WriteLiteral(" class=\"shopping-cart\"");

WriteLiteral(" id=\"accountDrop\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#globalSearch-xs\"");

WriteLiteral(" class=\"pos-rel-search font-size13\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-search mobile-shopping-bag\"");

WriteLiteral("></i>\r\n                        </a>\r\n                    </li>\r\n                <" +
"/ul>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal fade in\"");

WriteLiteral(" id=\"globalSearch-xs\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-dialog modal-search\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"modal-header text-center\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">\r\n                                <h3");

WriteLiteral(" class=\"heading-h3\"");

WriteLiteral(">Search</h3>\r\n                            </a>\r\n                            <butt" +
"on");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close search-close-btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 211 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                                                                                                                                                        Write(LT("Checkout.Button.Close", "Close"));

            
            #line default
            #line hidden
WriteLiteral("</span></button>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 216 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
                               Write(Html.Partial("~/Views/Shared/Layout1/_SearchBox.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n   " +
"                     </div>\r\n                        <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n" +
"        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 227 "..\..\Views\Shared\Layout1\_MobileHeaderLayout.cshtml"
Write(Html.Action("GetMobileNav", "Home"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
