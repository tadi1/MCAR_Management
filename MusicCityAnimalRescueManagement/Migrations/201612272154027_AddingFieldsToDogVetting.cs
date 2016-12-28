namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFieldsToDogVetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "AddtlVetting", c => c.Boolean(nullable: false));
            AddColumn("dbo.DogVettings", "VetDiagnosis", c => c.String());
            AddColumn("dbo.DogVettings", "VetDiagnosisDate", c => c.DateTime());
            AddColumn("dbo.DogVettings", "MedicationsGiven", c => c.String());
            AddColumn("dbo.DogVettings", "NextVet", c => c.DateTime());
            AddColumn("dbo.DogVettings", "VettingCompleted", c => c.DateTime());
            AddColumn("dbo.DogVettings", "VettingTotalDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DogVettings", "TempVettingDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DogVettings", "ReasonForVisit", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DogVettings", "ReasonForVisit");
            DropColumn("dbo.DogVettings", "TempVettingDecimal");
            DropColumn("dbo.DogVettings", "VettingTotalDecimal");
            DropColumn("dbo.DogVettings", "VettingCompleted");
            DropColumn("dbo.DogVettings", "NextVet");
            DropColumn("dbo.DogVettings", "MedicationsGiven");
            DropColumn("dbo.DogVettings", "VetDiagnosisDate");
            DropColumn("dbo.DogVettings", "VetDiagnosis");
            DropColumn("dbo.DogVettings", "AddtlVetting");
        }
    }
}
