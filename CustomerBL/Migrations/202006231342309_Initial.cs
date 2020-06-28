namespace CustomerBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Zip = c.String(nullable: false, maxLength: 10),
                        CountryID = c.String(nullable: false, maxLength: 2),
                        AddressID = c.Int(nullable: false, identity: true),
                        Street = c.String(maxLength: 100),
                        StreetNr = c.String(maxLength: 20),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Cities", t => new { t.Zip, t.CountryID })
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => new { t.Zip, t.CountryID })
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Zip = c.String(nullable: false, maxLength: 10),
                        CountryID = c.String(nullable: false, maxLength: 2),
                        LocalName = c.String(maxLength: 100),
                        IntName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.Zip, t.CountryID })
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.String(nullable: false, maxLength: 2),
                        LocalName = c.String(maxLength: 100),
                        IntName = c.String(maxLength: 100),
                        ShortName = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FName = c.String(maxLength: 100),
                        LName = c.String(maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Created = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Title = c.String(maxLength: 20),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GenderID = c.String(nullable: false, maxLength: 1),
                        CurrencyID = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Currencies", t => t.CurrencyID)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .Index(t => t.GenderID)
                .Index(t => t.CurrencyID);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyID = c.String(nullable: false, maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 100),
                        CurrencySymbol = c.String(),
                    })
                .PrimaryKey(t => t.CurrencyID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CustomerID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Discount = c.Single(nullable: false),
                        CurrencyID = c.String(nullable: false, maxLength: 3),
                        IsPartial = c.Boolean(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Addresses", t => t.AddressID)
                .ForeignKey("dbo.Currencies", t => t.CurrencyID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID)
                .Index(t => t.CurrencyID)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ItemNumber = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Discount = c.Single(nullable: false),
                        IsPartial = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ItemNumber })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.OrderItemAmounts",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        OrderItemNumber = c.Int(nullable: false),
                        AmountID = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AmountID)
                .ForeignKey("dbo.OrderItems", t => new { t.OrderID, t.OrderItemNumber }, cascadeDelete: true)
                .ForeignKey("dbo.OrderStatus", t => t.StatusID)
                .Index(t => new { t.OrderID, t.OrderItemNumber })
                .Index(t => t.StatusID);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Note = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        MyProperty = c.Decimal(nullable: false, storeType: "money"),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.String(nullable: false, maxLength: 1),
                        Titel = c.String(nullable: false),
                        Notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.GenderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Customers", "CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.OrderItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderItemAmounts", "StatusID", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderItemAmounts", new[] { "OrderID", "OrderItemNumber" }, "dbo.OrderItems");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.Orders", "AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", new[] { "Zip", "CountryID" }, "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryID", "dbo.Countries");
            DropIndex("dbo.OrderItemAmounts", new[] { "StatusID" });
            DropIndex("dbo.OrderItemAmounts", new[] { "OrderID", "OrderItemNumber" });
            DropIndex("dbo.OrderItems", new[] { "ProductID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "AddressID" });
            DropIndex("dbo.Orders", new[] { "CurrencyID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "CurrencyID" });
            DropIndex("dbo.Customers", new[] { "GenderID" });
            DropIndex("dbo.Cities", new[] { "CountryID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropIndex("dbo.Addresses", new[] { "Zip", "CountryID" });
            DropTable("dbo.Genders");
            DropTable("dbo.Products");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.OrderItemAmounts");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Currencies");
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
