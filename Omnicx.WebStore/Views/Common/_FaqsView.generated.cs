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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Common/_FaqsView.cshtml")]
    public partial class _Views_Common__FaqsView_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.ProductDetailModel>
    {
        public _Views_Common__FaqsView_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Common\_FaqsView.cshtml"
  
/*
    Name: FAQ Or Product Detail Accordion Panel
    Purpose: Use in PDP Screen Accordion Details
    Structure: /Views/Common/_FaqsView.cshtml
    Contains (Partial Views Used):
        
    Contained In (Where we Use this View):
        a-/Views/Product/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Common\_FaqsView.cshtml"
  
    var activeTab = @Model.FaqsCategory[0].Value;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel-group no-margin\"");

WriteLiteral(" id=\"description\"");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(" aria-multiselectable=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(">\r\n            <h4");

WriteLiteral(" class=\"panel-title heading-h4\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-parent=\"#description\"");

WriteLiteral(" href=\"#Data\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(" aria-controls=\"Data\"");

WriteLiteral(">Description</a>\r\n            </h4>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"Data\"");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"description\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-body no-padding no-border\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                        <p");

WriteLiteral(" class=\"faq-ques\"");

WriteLiteral(" ng-show=\"pm.model.shortDescription!=\'\' && pm.model.shortDescription!=null\"");

WriteLiteral("><strong>");

            
            #line 27 "..\..\Views\Common\_FaqsView.cshtml"
                                                                                                                          Write(LT("ProductDetail.Links.PRODUCTDESCRIPTION", "Product Description"));

            
            #line default
            #line hidden
WriteLiteral("</strong></p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"pm.model.shortDescription\"");

WriteLiteral("></span></p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.brand!=\'\' && pm.model.brand!=null\"");

WriteLiteral(">\r\n                            <strong>");

            
            #line 30 "..\..\Views\Common\_FaqsView.cshtml"
                               Write(LT("ProductListing.FacetHeading.Brand", "Brand"));

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                            <span");

WriteLiteral(" ng-bind=\"pm.model.brand\"");

WriteLiteral("></span>\r\n                        </p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.subBrand!=\'\' && pm.model.subBrand!=null\"");

WriteLiteral(">\r\n                            <strong>");

            
            #line 34 "..\..\Views\Common\_FaqsView.cshtml"
                               Write(LT("Product.Label.Subbrand", "Sub-brand"));

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                            <span");

WriteLiteral(" ng-bind=\"pm.model.subBrand\"");

WriteLiteral("></span>\r\n                        </p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.uomValue!=\'\' && pm.model.uomValue!=null && pm.model.uomValue>0" +
"\"");

WriteLiteral(">\r\n                            <strong> ");

            
            #line 38 "..\..\Views\Common\_FaqsView.cshtml"
                                Write(LT("Product.Label.Volume", "Volume"));

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                            <span");

WriteLiteral(" ng-bind=\"pm.model.uomValue\"");

WriteLiteral("></span> <span");

WriteLiteral(" ng-bind=\"pm.model.uom\"");

WriteLiteral("></span>\r\n                        </p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.stockCode!=\'\' && pm.model.stockCode!=null\"");

WriteLiteral(">\r\n                            <strong> ");

            
            #line 42 "..\..\Views\Common\_FaqsView.cshtml"
                                Write(LT("ProductDetail.Label.StockCode", "Stock Code"));

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                            <span");

WriteLiteral(" ng-bind=\"pm.model.stockCode\"");

WriteLiteral("></span>\r\n                        </p>\r\n                        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.currentStock!=\'\' && pm.model.currentStock!=null\"");

WriteLiteral(">\r\n                            <strong> ");

            
            #line 46 "..\..\Views\Common\_FaqsView.cshtml"
                                Write(LT("Product.Label.CurrentStock", "Current Stock"));

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                            <span");

WriteLiteral(" ng-bind=\"pm.model.currentStock\"");

WriteLiteral("></span>\r\n                        </p>\r\n");

            
            #line 49 "..\..\Views\Common\_FaqsView.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Common\_FaqsView.cshtml"
                          
                            var attributes = Model.Attributes.Where(x => x.DisplayInProductDetail == true).ToList();
                            if (attributes != null)
                            {
                                foreach (var items in attributes)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(">\r\n                                        <strong> ");

            
            #line 56 "..\..\Views\Common\_FaqsView.cshtml"
                                            Write(items.Display);

            
            #line default
            #line hidden
WriteLiteral(": </strong>\r\n                                        <span>");

            
            #line 57 "..\..\Views\Common\_FaqsView.cshtml"
                                         Write(items.Value);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    </p>\r\n");

            
            #line 59 "..\..\Views\Common\_FaqsView.cshtml"
                                }
                            }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
" </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"accordion\"");

WriteLiteral(" class=\"panel-group\"");

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Views\Common\_FaqsView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Common\_FaqsView.cshtml"
     foreach (var items in @Model.FaqsCategory)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteAttribute("ng-if", Tuple.Create(" ng-if=\"", 3954), Tuple.Create("\"", 3975)
            
            #line 72 "..\..\Views\Common\_FaqsView.cshtml"
, Tuple.Create(Tuple.Create("", 3962), Tuple.Create<System.Object, System.Int32>(items.Key
            
            #line default
            #line hidden
, 3962), false)
, Tuple.Create(Tuple.Create("", 3972), Tuple.Create("!=0", 3972), true)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(">\r\n                <h4");

WriteLiteral(" class=\"panel-title heading-h4\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-parent=\"#accordion\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4168), Tuple.Create("\"", 4204)
, Tuple.Create(Tuple.Create("", 4175), Tuple.Create("#", 4175), true)
            
            #line 75 "..\..\Views\Common\_FaqsView.cshtml"
            , Tuple.Create(Tuple.Create("", 4176), Tuple.Create<System.Object, System.Int32>(items.Value.Replace(" ","")
            
            #line default
            #line hidden
, 4176), false)
);

WriteLiteral(" aria-expanded=\"true\"");

WriteAttribute("aria-controls", Tuple.Create(" aria-controls=\"", 4226), Tuple.Create("\"", 4270)
            
            #line 75 "..\..\Views\Common\_FaqsView.cshtml"
                                                                              , Tuple.Create(Tuple.Create("", 4242), Tuple.Create<System.Object, System.Int32>(items.Value.Replace(" ","")
            
            #line default
            #line hidden
, 4242), false)
);

WriteLiteral(">");

            
            #line 75 "..\..\Views\Common\_FaqsView.cshtml"
                                                                                                                                                                                       Write(items.Value);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </h4>\r\n            </div>            \r\n            <div");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteAttribute("id", Tuple.Create(" id=\"", 4396), Tuple.Create("\"", 4429)
            
            #line 78 "..\..\Views\Common\_FaqsView.cshtml"
, Tuple.Create(Tuple.Create("", 4401), Tuple.Create<System.Object, System.Int32>(items.Value.Replace(" ","")
            
            #line default
            #line hidden
, 4401), false)
);

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-body no-padding no-border\"");

WriteLiteral(">\r\n");

            
            #line 80 "..\..\Views\Common\_FaqsView.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\Common\_FaqsView.cshtml"
                     foreach (var subfaqs in @Model.FaqsSubCategory)
                    {
                        if (subfaqs.CategoryId == items.Key)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <p>");

            
            #line 84 "..\..\Views\Common\_FaqsView.cshtml"
                          Write(subfaqs.Question);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                            <span>");

            
            #line 85 "..\..\Views\Common\_FaqsView.cshtml"
                             Write(Html.Raw(@subfaqs.Answer));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 86 "..\..\Views\Common\_FaqsView.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 91 "..\..\Views\Common\_FaqsView.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
