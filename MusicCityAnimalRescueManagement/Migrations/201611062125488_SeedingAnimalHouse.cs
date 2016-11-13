namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingAnimalHouse : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Locations", "isShowLast", c => c.Boolean(nullable: false));

            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] ON
INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation], [Address], [Notes], [Cats], [Dogs], [isBasicVaxLocation], [isRabiesVaxLocation], [isShowLast]) VALUES (19, N'Animal House', 1, 0, 0, N'Largo Dr.', N'Standard Vet', 1, 1, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Locations] OFF");
        }
        
        public override void Down()
        {
           // DropColumn("dbo.Locations", "isShowLast");

        }
    }
}
