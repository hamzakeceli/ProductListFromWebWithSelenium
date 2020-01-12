namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertdataanatotion : DbMigration
    {
        public override void Up()
        {
            AddColumn("eCommerce.Malls", "MallUrl", c => c.String(nullable: false));
            AlterColumn("eCommerce.Products", "ProductName", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("eCommerce.Products", "KeyValue", c => c.String(nullable: false, maxLength: 70));
            DropColumn("eCommerce.Malls", "MallDescription");
        }
        
        public override void Down()
        {
            AddColumn("eCommerce.Malls", "MallDescription", c => c.String());
            AlterColumn("eCommerce.Products", "KeyValue", c => c.String());
            AlterColumn("eCommerce.Products", "ProductName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("eCommerce.Malls", "MallUrl");
        }
    }
}
