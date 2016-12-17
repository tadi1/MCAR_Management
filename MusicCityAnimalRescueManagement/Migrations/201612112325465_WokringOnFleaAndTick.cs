namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WokringOnFleaAndTick : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "FleaTickId", c => c.Int());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.DogVettings", "FleaTickId");
        }
    }
}
