using AspNetCoreApplication.Data.Entities.Product.Model;
using System.Collections.Generic;

namespace AspNetCoreApplication.Data.Entities.Product.Out
{
    public class ProductOut
    {
        public ProductOut()
        {
            Products = new List<ProductModel>();
        }

        public List<ProductModel> Products { get; set; }
    }
}
