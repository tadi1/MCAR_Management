namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingNullableDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DogVettings", "SterilizationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DogVettings", "SterilizationDate", c => c.DateTime(nullable: false));
        }
    }
}
