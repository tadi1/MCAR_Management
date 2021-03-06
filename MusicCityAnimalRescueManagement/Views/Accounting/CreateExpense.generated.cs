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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Accounting/CreateExpense.cshtml")]
    public partial class _Views_Accounting_CreateExpense_cshtml : System.Web.Mvc.WebViewPage<MusicCityAnimalRescueManagement.Models.AccountEntries.ExpenseEntry>
    {
        public _Views_Accounting_CreateExpense_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Accounting\CreateExpense.cshtml"
  
    ViewBag.Title = "Add Expense";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Add an Expense Entry</h2>\r\n\r\n");

            
            #line 10 "..\..\Views\Accounting\CreateExpense.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Accounting\CreateExpense.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Accounting\CreateExpense.cshtml"
                            


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <h4>All entries added on this page will automatically be saved as <b>n" +
"egative</b> dollar amounts regardless of the sign entered here.</h4>\r\n        <h" +
"r />\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\Accounting\CreateExpense.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.AccountTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.DropDownList("AccountTypeID", null, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.AccountTypeID, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.SuppliesDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.SuppliesDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.SuppliesDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.SuppliesComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.SuppliesComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.SuppliesComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.VetBillsDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.VetBillsDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.VetBillsDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.VetBillsComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.VetBillsComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.VetBillsComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.MedicineDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 61 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.MedicineDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.MedicineDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 67 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.MedicineComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.MedicineComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 70 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.MedicineComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 75 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.InsurancePremiumsDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 77 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.InsurancePremiumsDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 78 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.InsurancePremiumsDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 83 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.InsurancePremiumsComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 85 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.InsurancePremiumsComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 86 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.InsurancePremiumsComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 91 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.FosterReimbursementDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 93 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.FosterReimbursementDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 94 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.FosterReimbursementDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 99 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.FosterReimbursementComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 101 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.FosterReimbursementComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 102 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.FosterReimbursementComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 107 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.MiscellaneousExpenseDecimal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 109 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.MiscellaneousExpenseDecimal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 110 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.MiscellaneousExpenseDecimal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 115 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.MiscellaneousExpenseComment, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 117 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.MiscellaneousExpenseComment, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 118 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.MiscellaneousExpenseComment, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 123 "..\..\Views\Accounting\CreateExpense.cshtml"
       Write(Html.LabelFor(model => model.EffectiveDate, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 125 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.EditorFor(model => model.EffectiveDate, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 126 "..\..\Views\Accounting\CreateExpense.cshtml"
           Write(Html.ValidationMessageFor(model => model.EffectiveDate, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Add Entry\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 136 "..\..\Views\Accounting\CreateExpense.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 139 "..\..\Views\Accounting\CreateExpense.cshtml"
Write(Html.ActionLink("Back to List", "ListExpenses"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 144 "..\..\Views\Accounting\CreateExpense.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
