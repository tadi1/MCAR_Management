namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCatsAndDogsToLocations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Cats", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locations", "Dogs", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Dogs");
            DropColumn("dbo.Locations", "Cats");
        }
    }
}
