namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PreparingForAnimalTracking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        colors = c.String(),
                        description = c.String(),
                        housetraining = c.Boolean(nullable: false),
                        Location_id = c.Short(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Locations", t => t.Location_id)
                .Index(t => t.Location_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Location_id", "dbo.Locations");
            DropIndex("dbo.Animals", new[] { "Location_id" });
            DropTable("dbo.Animals");
        }
    }
}
