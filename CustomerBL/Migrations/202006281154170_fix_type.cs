namespace CustomerBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Discount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
