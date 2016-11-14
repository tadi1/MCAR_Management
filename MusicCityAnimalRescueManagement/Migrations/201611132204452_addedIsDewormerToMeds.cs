namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIsDewormerToMeds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medications", "isDewormer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medications", "isDewormer");
        }
    }
}
