namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingPullLocation2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "PullLocationID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "PullLocationID");
        }
    }
}
