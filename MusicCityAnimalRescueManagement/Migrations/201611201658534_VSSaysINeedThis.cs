namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VSSaysINeedThis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Sex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Sex");
        }
    }
}
