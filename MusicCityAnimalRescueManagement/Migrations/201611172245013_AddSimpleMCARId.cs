namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSimpleMCARId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "SimpleMCARId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "SimpleMCARId");
        }
    }
}
