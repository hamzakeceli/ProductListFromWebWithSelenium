using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("Products", "eCommerce");
            Property(i => i.ProductName).IsRequired().HasMaxLength(70);
            Property(i => i.ProductPrice).IsRequired();
            Property(i => i.KeyValue).IsRequired().HasMaxLength(70);

        }
    }
}
