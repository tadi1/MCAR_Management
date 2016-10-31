namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewAnimalViewModels", "StrAnimalType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewAnimalViewModels", "StrAnimalType");
        }
    }
}
