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
    
    #line 1 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_HeaderLoginInfo.cshtml")]
    public partial class _Views_Shared_Layout1__HeaderLoginInfo_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Shared_Layout1__HeaderLoginInfo_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
 if (SessionContext.CurrentUser != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteLiteral(" class=\"margin-top-md\"");

WriteLiteral(">\r\n\r\n");

            
            #line 8 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
         if (SessionContext.CurrentUser.FirstName != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteLiteral(" class=\"userControls__linkSeperator\"");

WriteLiteral(">Hi! </span>\r\n");

WriteLiteral("            <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 389), Tuple.Create("\"", 431)
            
            #line 11 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Url.Action("MyAccount", "Account")
            
            #line default
            #line hidden
, 396), false)
);

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
                                                                                        Write(SessionContext.CurrentUser.FirstName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 12 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 561), Tuple.Create("\"", 603)
            
            #line 15 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
, Tuple.Create(Tuple.Create("", 568), Tuple.Create<System.Object, System.Int32>(Url.Action("MyAccount", "Account")
            
            #line default
            #line hidden
, 568), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
                                                                                        Write(LT("MyAccount.Text.Name", "My Account"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 16 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"userControls__linkSeperator\"");

WriteLiteral(">/</span>\r\n        <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 767), Tuple.Create("\"", 806)
            
            #line 18 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
, Tuple.Create(Tuple.Create("", 774), Tuple.Create<System.Object, System.Int32>(Url.Action("Logout", "Account")
            
            #line default
            #line hidden
, 774), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
                                                                                 Write(LT("Global.Buttons.Logout", "Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n");

            
            #line 20 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteLiteral(" class=\"margin-top-md\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"userControls__linkSeperator\"");

WriteLiteral("></span>\r\n        <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1011), Tuple.Create("\"", 1050)
            
            #line 25 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
, Tuple.Create(Tuple.Create("", 1018), Tuple.Create<System.Object, System.Int32>(Url.Action("SignIn", "Account")
            
            #line default
            #line hidden
, 1018), false)
);

WriteLiteral(">Login</a>\r\n        <span");

WriteLiteral(" class=\"userControls__linkSeperator\"");

WriteLiteral(">or</span>\r\n        <a");

WriteLiteral(" class=\"userControls__accountLinks\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1169), Tuple.Create("\"", 1208)
            
            #line 27 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
, Tuple.Create(Tuple.Create("", 1176), Tuple.Create<System.Object, System.Int32>(Url.Action("SignUp", "Account")
            
            #line default
            #line hidden
, 1176), false)
);

WriteLiteral(">Signup</a>\r\n    </li>\r\n");

            
            #line 29 "..\..\Views\Shared\Layout1\_HeaderLoginInfo.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
