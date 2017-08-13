using AspNetCoreApplication.VM.Common;
using AspNetCoreApplication.VM.Product.Model;
using System.Collections.Generic;

namespace AspNetCoreApplication.VM.Product.Out
{
    public class ProductOutVM : ResultServiceVM
    {
        public ProductOutVM()
        {
            Products = new List<ProductVM>();
        }

        public List<ProductVM> Products { get; set; }
    }
}
