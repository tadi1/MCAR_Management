namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryingDynamic : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AccountingViewModels", name: "ExpenseEntry_Id", newName: "ExpenseEntryObj_Id");
            RenameColumn(table: "dbo.AccountingViewModels", name: "IncomeEntry_Id", newName: "IncomeEntryObj_Id");
            RenameIndex(table: "dbo.AccountingViewModels", name: "IX_ExpenseEntry_Id", newName: "IX_ExpenseEntryObj_Id");
            RenameIndex(table: "dbo.AccountingViewModels", name: "IX_IncomeEntry_Id", newName: "IX_IncomeEntryObj_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AccountingViewModels", name: "IX_IncomeEntryObj_Id", newName: "IX_IncomeEntry_Id");
            RenameIndex(table: "dbo.AccountingViewModels", name: "IX_ExpenseEntryObj_Id", newName: "IX_ExpenseEntry_Id");
            RenameColumn(table: "dbo.AccountingViewModels", name: "IncomeEntryObj_Id", newName: "IncomeEntry_Id");
            RenameColumn(table: "dbo.AccountingViewModels", name: "ExpenseEntryObj_Id", newName: "ExpenseEntry_Id");
        }
    }
}
