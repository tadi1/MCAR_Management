namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAcctTypeToVM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountingViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StrAccountType = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountingViewModels");
        }
    }
}
