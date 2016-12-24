namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotSureWhatChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CatVettings", "VettingTotalDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CatVettings", "TempVettingDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CatVettings", "ReasonForVisit", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CatVettings", "ReasonForVisit");
            DropColumn("dbo.CatVettings", "TempVettingDecimal");
            DropColumn("dbo.CatVettings", "VettingTotalDecimal");
        }
    }
}
