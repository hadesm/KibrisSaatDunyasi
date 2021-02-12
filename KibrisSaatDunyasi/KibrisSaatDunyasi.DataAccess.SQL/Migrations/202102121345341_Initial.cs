namespace KibrisSaatDunyasi.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCats",
                c => new
                    {
                        catid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.catid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productid = c.String(nullable: false, maxLength: 128),
                        productname = c.String(),
                        catid = c.String(),
                        descript = c.String(),
                        img = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        brand = c.String(),
                        Kadın = c.Boolean(nullable: false),
                        Erkek = c.Boolean(nullable: false),
                        Unisex = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.productid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductCats");
        }
    }
}
