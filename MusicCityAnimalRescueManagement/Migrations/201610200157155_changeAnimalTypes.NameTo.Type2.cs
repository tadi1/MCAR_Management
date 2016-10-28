namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAnimalTypesNameToType2 : DbMigration
    {
        public override void Up()
        {
            Sql("sp_rename '[dbo].[AnimalTypes].[dbo.animaltypes.Type]', 'Type', 'COLUMN'");

        }

        public override void Down()
        {
        }
    }
}
