namespace StockControl.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        TradeMark = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Memory = c.String(nullable: false, maxLength: 50),
                        OperatingSystem = c.String(nullable: false, maxLength: 50),
                        Ram = c.String(),
                        Camera = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShipmentId = c.Int(nullable: false),
                        SellingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Personels", t => t.PersonelId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.Shipments", t => t.ShipmentId)
                .ForeignKey("dbo.Stocks", t => t.StockId)
                .Index(t => t.PersonelId)
                .Index(t => t.ProductId)
                .Index(t => t.StockId)
                .Index(t => t.CustomerId)
                .Index(t => t.ShipmentId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Phone = c.String(maxLength: 11),
                        Email = c.String(maxLength: 50),
                        Adress = c.String(maxLength: 100),
                        City = c.String(maxLength: 50),
                        Region = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentityNumber = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        AuthorityLevel = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.String(maxLength: 11),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        StockEntryDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personels", t => t.PersonelId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Adress = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Sales", "ShipmentId", "dbo.Shipments");
            DropForeignKey("dbo.Sales", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stocks", "PersonelId", "dbo.Personels");
            DropForeignKey("dbo.Sales", "PersonelId", "dbo.Personels");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "PersonelId" });
            DropIndex("dbo.Stocks", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "ShipmentId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "StockId" });
            DropIndex("dbo.Sales", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "PersonelId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Shipments");
            DropTable("dbo.Stocks");
            DropTable("dbo.Personels");
            DropTable("dbo.Customers");
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
