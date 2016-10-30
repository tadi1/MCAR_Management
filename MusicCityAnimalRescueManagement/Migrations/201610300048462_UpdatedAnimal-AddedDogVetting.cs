namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAnimalAddedDogVetting : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Animals", name: "Location_id", newName: "CurrentFoster_id");
            RenameIndex(table: "dbo.Animals", name: "IX_Location_id", newName: "IX_CurrentFoster_id");
            AddColumn("dbo.Animals", "MCARId", c => c.String(nullable: false));
            AddColumn("dbo.Animals", "AgeY", c => c.String(nullable: false));
            AddColumn("dbo.Animals", "AgeM", c => c.String(nullable: false));
            AddColumn("dbo.Animals", "IntakeDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Animals", "ReadyForAdoption", c => c.Boolean(nullable: false));
            AddColumn("dbo.Animals", "MicrochipNumber", c => c.Long(nullable: false));
            AddColumn("dbo.Animals", "PullFee", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Animals", "AdoptionFee", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Locations", "isFoster", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "isFoster");
            DropColumn("dbo.Animals", "AdoptionFee");
            DropColumn("dbo.Animals", "PullFee");
            DropColumn("dbo.Animals", "MicrochipNumber");
            DropColumn("dbo.Animals", "ReadyForAdoption");
            DropColumn("dbo.Animals", "IntakeDate");
            DropColumn("dbo.Animals", "AgeM");
            DropColumn("dbo.Animals", "AgeY");
            DropColumn("dbo.Animals", "MCARId");
            RenameIndex(table: "dbo.Animals", name: "IX_CurrentFoster_id", newName: "IX_Location_id");
            RenameColumn(table: "dbo.Animals", name: "CurrentFoster_id", newName: "Location_id");
        }
    }
}
