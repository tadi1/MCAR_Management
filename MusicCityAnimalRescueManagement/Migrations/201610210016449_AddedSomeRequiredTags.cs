namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSomeRequiredTags : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Animals", "colors", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "colors", c => c.String());
            AlterColumn("dbo.Animals", "name", c => c.String());
        }
    }
}
