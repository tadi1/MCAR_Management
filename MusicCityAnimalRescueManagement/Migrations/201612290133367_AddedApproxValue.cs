namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedApproxValue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EquipmentItems", "ApproxValueDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EquipmentItems", "ApproxValueDecimal");
        }
    }
}
