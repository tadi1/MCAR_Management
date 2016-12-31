namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableAdoptionEntries : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IncomeEntries", "NumCatAdoptions", c => c.Int());
            AlterColumn("dbo.IncomeEntries", "NumDogAdoptions", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IncomeEntries", "NumDogAdoptions", c => c.Int(nullable: false));
            AlterColumn("dbo.IncomeEntries", "NumCatAdoptions", c => c.Int(nullable: false));
        }
    }
}
