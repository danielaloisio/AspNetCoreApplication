using AspNetCoreApplication.VM.Product.Out;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Service.Product
{
    public interface IProductService
    {
        Task<ProductOutVM> GetProducts();
    }
}
