namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowingSomeFieldsToBeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "AgeY", c => c.String());
            AlterColumn("dbo.Animals", "AgeM", c => c.String());
            AlterColumn("dbo.Animals", "Temperament", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Temperament", c => c.String(nullable: false));
            AlterColumn("dbo.Animals", "AgeM", c => c.String(nullable: false));
            AlterColumn("dbo.Animals", "AgeY", c => c.String(nullable: false));
        }
    }
}
