namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingIntsToNullableForDogVetting : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DogVettings", "SterilizationLocation", c => c.Int());
            AlterColumn("dbo.DogVettings", "BordetellaLocation", c => c.Int());
            AlterColumn("dbo.DogVettings", "RabiesLocation", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR1Location", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR2Location", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR3Location", c => c.Int());
            AlterColumn("dbo.DogVettings", "HeartwormLocation", c => c.Int());
            AlterColumn("dbo.DogVettings", "DewormerLocation", c => c.Int());
            AlterColumn("dbo.DogVettings", "FleaTickLocation", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DogVettings", "FleaTickLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DewormerLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "HeartwormLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR3Location", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR2Location", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR1Location", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "RabiesLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "BordetellaLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "SterilizationLocation", c => c.Int(nullable: false));
        }
    }
}
