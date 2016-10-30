namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkingOnIntake : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Animals", name: "CurrentFoster_id", newName: "StrLocation_id");
            RenameIndex(table: "dbo.Animals", name: "IX_CurrentFoster_id", newName: "IX_StrLocation_id");
            AddColumn("dbo.Animals", "CurrentFosterID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "CurrentFosterID");
            RenameIndex(table: "dbo.Animals", name: "IX_StrLocation_id", newName: "IX_CurrentFoster_id");
            RenameColumn(table: "dbo.Animals", name: "StrLocation_id", newName: "CurrentFoster_id");
        }
    }
}
