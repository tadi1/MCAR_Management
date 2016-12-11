namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingSex1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "SexId", c => c.String(nullable: false));
        }
    }
}
