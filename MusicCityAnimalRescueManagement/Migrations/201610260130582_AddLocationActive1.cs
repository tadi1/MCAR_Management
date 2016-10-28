namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationActive1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "isActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locations", "active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "active", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locations", "isActive");
        }
    }
}
