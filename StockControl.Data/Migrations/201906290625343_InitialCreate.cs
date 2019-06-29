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
                        Name = c.String(nullable: false, maxLength: 30),
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
                        Memory = c.String(nullable: false),
                        OperatingSystem = c.String(nullable: false),
                        Ram = c.String(nullable: false),
                        Camera = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
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
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Personels", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Shipments", t => t.ShipmentId, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.StockId, cascadeDelete: true)
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
                        Phone = c.String(),
                        Email = c.String(),
                        Adress = c.String(),
                        City = c.String(),
                        Region = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        AuthorityLevel = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Adress = c.String(),
                        Phone = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        StockEntryDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Personel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personels", t => t.Personel_Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.Personel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stocks", "Personel_Id", "dbo.Personels");
            DropForeignKey("dbo.Sales", "ShipmentId", "dbo.Shipments");
            DropForeignKey("dbo.Sales", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Sales", "PersonelId", "dbo.Personels");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "Personel_Id" });
            DropIndex("dbo.Stocks", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "ShipmentId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "StockId" });
            DropIndex("dbo.Sales", new[] { "ProductId" });
            DropIndex("dbo.Sales", new[] { "PersonelId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Shipments");
            DropTable("dbo.Personels");
            DropTable("dbo.Customers");
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
