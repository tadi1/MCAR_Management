namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIDtoNewAnimalVM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewAnimalViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Animal_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animals", t => t.Animal_id)
                .Index(t => t.Animal_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewAnimalViewModels", "Animal_id", "dbo.Animals");
            DropIndex("dbo.NewAnimalViewModels", new[] { "Animal_id" });
            DropTable("dbo.NewAnimalViewModels");
        }
    }
}
