namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdoptedFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "adopted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "adopted");
        }
    }
}
