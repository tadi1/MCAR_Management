namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeID = c.Byte(nullable: false),
                        AccountTypeName = c.String(),
                    })
                .PrimaryKey(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        type = c.String(),
                        prefix = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ExpenseEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountTypeID = c.Byte(nullable: false),
                        SuppliesDecimal = c.Decimal(precision: 18, scale: 2),
                        SuppliesComment = c.String(),
                        VetBillsDecimal = c.Decimal(precision: 18, scale: 2),
                        VetBillsComment = c.String(),
                        MedicineDecimal = c.Decimal(precision: 18, scale: 2),
                        MedicineComment = c.String(),
                        InsurancePremiumsDecimal = c.Decimal(precision: 18, scale: 2),
                        InsurancePremiumsComment = c.String(),
                        FosterReimbursementDecimal = c.Decimal(precision: 18, scale: 2),
                        FosterReimbursementComment = c.String(),
                        MiscellaneousExpenseDecimal = c.Decimal(precision: 18, scale: 2),
                        MiscellaneousExpenseComment = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeID, cascadeDelete: true)
                .Index(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        description = c.String(),
                        ItemNumber = c.Int(nullable: false),
                        location_id = c.Short(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Locations", t => t.location_id)
                .Index(t => t.location_id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations");
            DropForeignKey("dbo.ExpenseEntries", "AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.InventoryItems", new[] { "location_id" });
            DropIndex("dbo.ExpenseEntries", new[] { "AccountTypeID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Locations");
            DropTable("dbo.InventoryItems");
            DropTable("dbo.ExpenseEntries");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.AccountTypes");
        }
    }
}
