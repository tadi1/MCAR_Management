namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class settinguppartialview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountingViewModels", "ExpenseEntry_Id", c => c.Int());
            AddColumn("dbo.AccountingViewModels", "IncomeEntry_Id", c => c.Int());
            CreateIndex("dbo.AccountingViewModels", "ExpenseEntry_Id");
            CreateIndex("dbo.AccountingViewModels", "IncomeEntry_Id");
            AddForeignKey("dbo.AccountingViewModels", "ExpenseEntry_Id", "dbo.ExpenseEntries", "Id");
            AddForeignKey("dbo.AccountingViewModels", "IncomeEntry_Id", "dbo.IncomeEntries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountingViewModels", "IncomeEntry_Id", "dbo.IncomeEntries");
            DropForeignKey("dbo.AccountingViewModels", "ExpenseEntry_Id", "dbo.ExpenseEntries");
            DropIndex("dbo.AccountingViewModels", new[] { "IncomeEntry_Id" });
            DropIndex("dbo.AccountingViewModels", new[] { "ExpenseEntry_Id" });
            DropColumn("dbo.AccountingViewModels", "IncomeEntry_Id");
            DropColumn("dbo.AccountingViewModels", "ExpenseEntry_Id");
        }
    }
}
