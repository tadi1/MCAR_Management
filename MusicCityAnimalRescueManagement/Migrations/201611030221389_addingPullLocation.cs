namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingPullLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "isPullLocation", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "isPullLocation");
        }
    }
}
