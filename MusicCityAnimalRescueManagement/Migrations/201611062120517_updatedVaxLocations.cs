namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedVaxLocations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "isBasicVaxLocation", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locations", "isRabiesVaxLocation", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locations", "isVettingLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "isVettingLocation", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locations", "isRabiesVaxLocation");
            DropColumn("dbo.Locations", "isBasicVaxLocation");
        }
    }
}
