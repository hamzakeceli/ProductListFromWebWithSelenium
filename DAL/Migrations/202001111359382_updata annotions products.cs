namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updataannotionsproducts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("eCommerce.Products", "ProductName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("eCommerce.Products", "ProductName", c => c.Int(nullable: false));
        }
    }
}
