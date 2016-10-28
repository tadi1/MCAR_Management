namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "active");
        }
    }
}
