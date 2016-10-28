namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToAnimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "breed", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "breed", c => c.String());
        }
    }
}
