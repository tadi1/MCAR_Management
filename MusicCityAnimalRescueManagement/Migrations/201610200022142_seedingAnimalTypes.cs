namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingAnimalTypes : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[AnimalTypes] ON
                    INSERT INTO [dbo].[AnimalTypes] ([id], [Name]) VALUES (1, N'Dog')
                    INSERT INTO [dbo].[AnimalTypes] ([id], [Name]) VALUES (2, N'Cat')
                    INSERT INTO [dbo].[AnimalTypes] ([id], [Name]) VALUES (3, N'Other')
                    SET IDENTITY_INSERT [dbo].[AnimalTypes] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
