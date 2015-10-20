namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cloud213223 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillingAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        OrganisationName = c.String(),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Postal = c.String(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DeliveryAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        OrganisationName = c.String(),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Postal = c.String(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Thread = c.String(nullable: false),
                        Level = c.String(nullable: false),
                        Logger = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        Exception = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductsCount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillingAddress_ID = c.Int(),
                        DeliveryAddress_ID = c.Int(),
                        PaymentInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BillingAddress", t => t.BillingAddress_ID)
                .ForeignKey("dbo.DeliveryAddress", t => t.DeliveryAddress_ID)
                .ForeignKey("dbo.PaymentInformation", t => t.PaymentInformation_ID)
                .Index(t => t.BillingAddress_ID)
                .Index(t => t.DeliveryAddress_ID)
                .Index(t => t.PaymentInformation_ID);
            
            CreateTable(
                "dbo.PaymentInformation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreditCartOwner = c.String(nullable: false),
                        CreditCardNumber = c.String(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Created = c.DateTime(nullable: false),
                        ProductImage = c.String(),
                        StockCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductOrder",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Order_ID })
                .ForeignKey("dbo.Order", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Order_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.Order_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrder", "Order_ID", "dbo.Product");
            DropForeignKey("dbo.ProductOrder", "Product_ID", "dbo.Order");
            DropForeignKey("dbo.Order", "PaymentInformation_ID", "dbo.PaymentInformation");
            DropForeignKey("dbo.Order", "DeliveryAddress_ID", "dbo.DeliveryAddress");
            DropForeignKey("dbo.Order", "BillingAddress_ID", "dbo.BillingAddress");
            DropIndex("dbo.ProductOrder", new[] { "Order_ID" });
            DropIndex("dbo.ProductOrder", new[] { "Product_ID" });
            DropIndex("dbo.Order", new[] { "PaymentInformation_ID" });
            DropIndex("dbo.Order", new[] { "DeliveryAddress_ID" });
            DropIndex("dbo.Order", new[] { "BillingAddress_ID" });
            DropTable("dbo.ProductOrder");
            DropTable("dbo.Product");
            DropTable("dbo.PaymentInformation");
            DropTable("dbo.Order");
            DropTable("dbo.Log");
            DropTable("dbo.DeliveryAddress");
            DropTable("dbo.BillingAddress");
        }
    }
}
