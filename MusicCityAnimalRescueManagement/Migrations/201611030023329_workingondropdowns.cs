namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workingondropdowns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Animals", "CurrentFosterName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "CurrentFosterName", c => c.String(nullable: false));
        }
    }
}
