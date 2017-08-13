using AspNetCoreApplication.Data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreApplication.Data.Mapping
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ProductId);
            entityBuilder.Property(t => t.Name);
        }
    }
}
