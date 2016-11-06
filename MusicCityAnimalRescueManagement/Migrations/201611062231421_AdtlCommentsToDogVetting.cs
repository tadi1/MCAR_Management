namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdtlCommentsToDogVetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "AdtlComments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DogVettings", "AdtlComments");
        }
    }
}
