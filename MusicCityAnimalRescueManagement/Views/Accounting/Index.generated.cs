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
    using MusicCityAnimalRescueManagement;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Accounting/Index.cshtml")]
    public partial class _Views_Accounting_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<MusicCityAnimalRescueManagement.Models.AccountEntries.ExpenseEntry>>
    {
        public _Views_Accounting_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Accounting\Index.cshtml"
  
    ViewBag.Title = "Accounting Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n\r\n<h2>Accounting Home</h2>\r\n\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Accounting\Index.cshtml"
Write(Html.ActionLink("Work in Progress: Show Incomes and Expenses", "Entries"));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Accounting\Index.cshtml"
Write(Html.ActionLink("List Expense Entries", "ListExpenses"));

            
            #line default
            #line hidden
WriteLiteral(" <br/>\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Accounting\Index.cshtml"
Write(Html.ActionLink("Create New Expense Entry", "CreateExpense"));

            
            #line default
            #line hidden
WriteLiteral("<br /><br />\r\n    \r\n    <b>The below actions are not yet implemented!</b><br/>\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Views\Accounting\Index.cshtml"
Write(Html.ActionLink("List Income Entries", "ListIncomes"));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("    ");

            
            #line 21 "..\..\Views\Accounting\Index.cshtml"
Write(Html.ActionLink("Create New Income Entry", "IntakeIncomes"));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591
