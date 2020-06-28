namespace CustomerBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            DropColumn("dbo.Products", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "MyProperty", c => c.Decimal(nullable: false, storeType: "money"));
            DropColumn("dbo.Products", "Price");
        }
    }
}
