namespace app2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Tel = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClientId)
                .ForeignKey("dbo.Produtos", t => t.ProductId)
                .ForeignKey("dbo.Vendedores", t => t.SellerId)
                .Index(t => t.ProductId)
                .Index(t => t.SellerId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        Cpf = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "SellerId", "dbo.Vendedores");
            DropForeignKey("dbo.Venda", "ProductId", "dbo.Produtos");
            DropForeignKey("dbo.Venda", "ClientId", "dbo.Clientes");
            DropIndex("dbo.Venda", new[] { "ClientId" });
            DropIndex("dbo.Venda", new[] { "SellerId" });
            DropIndex("dbo.Venda", new[] { "ProductId" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Venda");
            DropTable("dbo.Produtos");
            DropTable("dbo.Clientes");
        }
    }
}
