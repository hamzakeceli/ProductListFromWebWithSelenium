namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertdiiscountpriceprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("eCommerce.Products", "DiscountedPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("eCommerce.Products", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("eCommerce.Products", "ProductPrice", c => c.Double(nullable: false));
            DropColumn("eCommerce.Products", "DiscountedPrice");
        }
    }
}
