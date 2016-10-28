namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAnimalTypesNameToType : DbMigration
    {
        public override void Up()
        {
            Sql("sp_rename 'dbo.animaltypes.Name', 'dbo.animaltypes.Type', 'COLUMN'");

        }

        public override void Down()
        {
        }
    }
}
