namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingCrates : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[InventoryItems] ON
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (1, N'24x18 Green/Camo Wire Crate', 1001, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (2, N'24x18 Black Wire Crate', 1002, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (3, N'24x18 Black Wire Crate', 1003, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (4, N'48x30 Black Wire Crate', 1004, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (5, N'42x27 Black Wire Crate', 1005, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (6, N'42x27 Black Wire Crate', 1006, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (7, N'20x12 Black Wire Crate', 1007, 29)


SET IDENTITY_INSERT [dbo].[InventoryItems] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
