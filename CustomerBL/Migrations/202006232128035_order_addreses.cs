namespace CustomerBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order_addreses : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "AddressID", newName: "BillingAddID");
            RenameIndex(table: "dbo.Orders", name: "IX_AddressID", newName: "IX_BillingAddID");
            AddColumn("dbo.Orders", "DeliveryAddID", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "DeliveryAddID");
            AddForeignKey("dbo.Orders", "DeliveryAddID", "dbo.Addresses", "AddressID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DeliveryAddID", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "DeliveryAddID" });
            DropColumn("dbo.Orders", "DeliveryAddID");
            RenameIndex(table: "dbo.Orders", name: "IX_BillingAddID", newName: "IX_AddressID");
            RenameColumn(table: "dbo.Orders", name: "BillingAddID", newName: "AddressID");
        }
    }
}
