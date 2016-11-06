namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isVettingLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "isVettingLocation", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "isVettingLocation");
        }
    }
}
