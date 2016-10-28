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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Accounting/_ListExpenses.cshtml")]
    public partial class _Views_Accounting__ListExpenses_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<MusicCityAnimalRescueManagement.Models.AccountEntries.ExpenseEntry>>
    {
        public _Views_Accounting__ListExpenses_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Accounting\_ListExpenses.cshtml"
Write(Styles.Render("~/Content/dataTables"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<h2>Expense Entries</h2>\r\n\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Accounting\_ListExpenses.cshtml"
Write(Html.ActionLink("Create New Expense Entry", "CreateExpense"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");

WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table\"");

WriteLiteral(" id=\"ExpenseEntries\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.EffectiveDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.StrAccountType.AccountTypeName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.SuppliesDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.SuppliesComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.VetBillsDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.VetBillsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.MedicineDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.MedicineComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.InsurancePremiumsDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.InsurancePremiumsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.FosterReimbursementDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.FosterReimbursementComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 52 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.MiscellaneousExpenseDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n");

WriteLiteral("                ");

            
            #line 55 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.DisplayNameFor(model => model.MiscellaneousExpenseComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Action\r\n            </th>\r" +
"\n            ");

WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tfoot>\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"9\"");

WriteLiteral(" style=\"text-align:right\"");

WriteLiteral(">Total:</th>\r\n            <th></th>\r\n        </tr>\r\n    </tfoot>\r\n    <tbody>\r\n");

            
            #line 70 "..\..\Views\Accounting\_ListExpenses.cshtml"
        
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Accounting\_ListExpenses.cshtml"
         foreach (var item in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

WriteLiteral("                ");

            
            #line 73 "..\..\Views\Accounting\_ListExpenses.cshtml"
           Write(Html.HiddenFor(modelItem => item.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 75 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.EffectiveDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 78 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.StrAccountType.AccountTypeName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.SuppliesDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.SuppliesComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.VetBillsDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 90 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.VetBillsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.MedicineDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 96 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.MedicineComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 99 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.InsurancePremiumsDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 102 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.InsurancePremiumsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 105 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.FosterReimbursementDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.FosterReimbursementComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 111 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.MiscellaneousExpenseDecimal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 114 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.DisplayFor(modelItem => item.MiscellaneousExpenseComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 117 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.ActionLink("Edit", "EditExpense", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("                    ");

            
            #line 118 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.ActionLink("Details", "DetailsExpense", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("                    ");

            
            #line 119 "..\..\Views\Accounting\_ListExpenses.cshtml"
               Write(Html.ActionLink("Delete", "DeleteExpense", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 122 "..\..\Views\Accounting\_ListExpenses.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 130 "..\..\Views\Accounting\_ListExpenses.cshtml"
Write(Scripts.Render("~/bundles/dataTables"));

            
            #line default
            #line hidden
WriteLiteral(@"

    <script>
        $('#ExpenseEntries').DataTable({
            drawCallback: function () {
                var api = this.api();
                $(api.table().footer()).html(
                  api.column(4, { page: 'current' }).data().sum()
                );
            }
        });
    </script>
");

});

WriteLiteral("\r\n    ");

WriteLiteral("\r\n}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
