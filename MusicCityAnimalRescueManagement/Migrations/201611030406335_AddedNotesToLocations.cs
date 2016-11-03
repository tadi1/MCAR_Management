namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNotesToLocations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Notes");
        }
    }
}
