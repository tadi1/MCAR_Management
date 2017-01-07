namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCityToLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "City");
        }
    }
}
