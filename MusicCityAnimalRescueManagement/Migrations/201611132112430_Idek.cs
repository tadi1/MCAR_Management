namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Idek : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocationId" });
            DropIndex("dbo.DogVettings", new[] { "BordetellaLocationId" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3LocationId" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DewormerLocationId" });
            DropIndex("dbo.DogVettings", new[] { "FleaTickLocationId" });
            AlterColumn("dbo.DogVettings", "SterilizationLocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "BordetellaLocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "RabiesLocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR1LocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR2LocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "DA2PPR3LocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "HeartwormLocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "DewormerLocationId", c => c.Int());
            AlterColumn("dbo.DogVettings", "FleaTickLocationId", c => c.Int());
            CreateIndex("dbo.DogVettings", "SterilizationLocationId");
            CreateIndex("dbo.DogVettings", "BordetellaLocationId");
            CreateIndex("dbo.DogVettings", "RabiesLocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR1LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR2LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR3LocationId");
            CreateIndex("dbo.DogVettings", "HeartwormLocationId");
            CreateIndex("dbo.DogVettings", "DewormerLocationId");
            CreateIndex("dbo.DogVettings", "FleaTickLocationId");
            AddForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "FleaTickLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DewormerLocationId" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1LocationId" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocationId" });
            DropIndex("dbo.DogVettings", new[] { "BordetellaLocationId" });
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocationId" });
            AlterColumn("dbo.DogVettings", "FleaTickLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DewormerLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "HeartwormLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR3LocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR2LocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR1LocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "RabiesLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "BordetellaLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "SterilizationLocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.DogVettings", "FleaTickLocationId");
            CreateIndex("dbo.DogVettings", "DewormerLocationId");
            CreateIndex("dbo.DogVettings", "HeartwormLocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR3LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR2LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR1LocationId");
            CreateIndex("dbo.DogVettings", "RabiesLocationId");
            CreateIndex("dbo.DogVettings", "BordetellaLocationId");
            CreateIndex("dbo.DogVettings", "SterilizationLocationId");
            AddForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations", "id", cascadeDelete: true);
        }
    }
}
