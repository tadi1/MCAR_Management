namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkingOnDBIssuePart2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "SexId");
        }
    }
}
