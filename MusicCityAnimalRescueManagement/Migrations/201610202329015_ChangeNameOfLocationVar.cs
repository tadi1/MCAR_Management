namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameOfLocationVar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "LocationID", c => c.Int(nullable: false));
            DropColumn("dbo.Animals", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Location", c => c.Int(nullable: false));
            DropColumn("dbo.Animals", "LocationID");
        }
    }
}
