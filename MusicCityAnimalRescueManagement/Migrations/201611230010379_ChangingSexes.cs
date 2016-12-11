namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingSexes : DbMigration
    {
        public override void Up()
        {
           AddColumn("dbo.Animals", "Sex", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Sex", c => c.Int(nullable: false));
        }
    }
}
