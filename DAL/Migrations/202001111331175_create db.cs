namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "eCommerce.Malls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MallName = c.String(),
                        MallDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "eCommerce.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Productname = c.Int(nullable: false),
                        ProductPrice = c.Double(nullable: false),
                        ListingDate = c.DateTime(nullable: false),
                        KeyValue = c.String(),
                        MallId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("eCommerce.Malls", t => t.MallId, cascadeDelete: true)
                .Index(t => t.MallId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("eCommerce.Products", "MallId", "eCommerce.Malls");
            DropIndex("eCommerce.Products", new[] { "MallId" });
            DropTable("eCommerce.Products");
            DropTable("eCommerce.Malls");
        }
    }
}
