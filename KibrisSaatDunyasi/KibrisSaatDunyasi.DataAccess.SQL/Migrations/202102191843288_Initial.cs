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
                        Id = c.String(nullable: false, maxLength: 128),
                        catname = c.String(),
                        createdat = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        productname = c.String(),
                        catname = c.String(),
                        descript = c.String(),
                        img = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        brand = c.String(),
                        Kadın = c.Boolean(nullable: false),
                        Erkek = c.Boolean(nullable: false),
                        Unisex = c.Boolean(nullable: false),
                        createdat = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductCats");
        }
    }
}
