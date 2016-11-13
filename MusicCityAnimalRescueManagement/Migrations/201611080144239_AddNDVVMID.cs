namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNDVVMID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewDogVettingViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Animal_id = c.Int(),
                        DogVetting_id = c.Short(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animals", t => t.Animal_id)
                .ForeignKey("dbo.DogVettings", t => t.DogVetting_id)
                .Index(t => t.Animal_id)
                .Index(t => t.DogVetting_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewDogVettingViewModels", "DogVetting_id", "dbo.DogVettings");
            DropForeignKey("dbo.NewDogVettingViewModels", "Animal_id", "dbo.Animals");
            DropIndex("dbo.NewDogVettingViewModels", new[] { "DogVetting_id" });
            DropIndex("dbo.NewDogVettingViewModels", new[] { "Animal_id" });
            DropTable("dbo.NewDogVettingViewModels");
        }
    }
}
