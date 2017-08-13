using AspNetCoreApplication.VM.Common;
using AspNetCoreApplication.VM.Product.In;
using AspNetCoreApplication.VM.Product.Out;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Service
{
    public interface IProductService
    {
        Task<ProductOutVM> GetProducts();
        Task<ResultServiceVM> CreateProduct(ProductInVM productInVM);
    }
}
