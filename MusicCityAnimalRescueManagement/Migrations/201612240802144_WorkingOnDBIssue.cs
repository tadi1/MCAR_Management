namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkingOnDBIssue : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Animals", "SexId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
        }
    }
}
