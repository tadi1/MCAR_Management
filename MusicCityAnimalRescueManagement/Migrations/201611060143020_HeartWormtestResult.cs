namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeartWormtestResult : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "HeartwormTestResult", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DogVettings", "HeartwormTestResult");
        }
    }
}
