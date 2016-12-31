namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVetTotalCostToAnimal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "VettingTotalDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "VettingTotalDecimal");
        }
    }
}
