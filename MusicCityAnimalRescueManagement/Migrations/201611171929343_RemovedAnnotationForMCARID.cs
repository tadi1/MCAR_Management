namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAnnotationForMCARID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "MCARId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "MCARId", c => c.String(nullable: false));
        }
    }
}
