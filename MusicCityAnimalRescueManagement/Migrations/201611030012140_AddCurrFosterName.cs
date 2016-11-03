namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCurrFosterName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "CurrentFosterName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "CurrentFosterName");
        }
    }
}
