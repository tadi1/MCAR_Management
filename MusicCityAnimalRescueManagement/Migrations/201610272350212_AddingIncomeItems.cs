namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIncomeItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomeEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountTypeID = c.Byte(nullable: false),
                        AdoptionsDecimal = c.Decimal(precision: 18, scale: 2),
                        NumCatAdoptions = c.Int(nullable: false),
                        NumDogAdoptions = c.Int(nullable: false),
                        AdoptionsComment = c.String(),
                        DonationsDecimal = c.Decimal(precision: 18, scale: 2),
                        DonationsComment = c.String(),
                        MiscellaneousIncomeDecimal = c.Decimal(precision: 18, scale: 2),
                        MiscellaneousIncomeComment = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeID, cascadeDelete: true)
                .Index(t => t.AccountTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncomeEntries", "AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.IncomeEntries", new[] { "AccountTypeID" });
            DropTable("dbo.IncomeEntries");
        }
    }
}
