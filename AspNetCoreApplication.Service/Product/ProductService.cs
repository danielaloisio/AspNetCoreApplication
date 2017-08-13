using System.Threading.Tasks;
using AspNetCoreApplication.VM.Product.Out;
using AspNetCoreApplication.Data.Entities.Product.Out;
using AspNetCoreApplication.Helper.Mapper;
using AspNetCoreApplication.Repository;
using AspNetCoreApplication.VM.Common;
using AspNetCoreApplication.VM.Product.In;
using System;
using AspNetCoreApplication.Data.Model;
using AspNetCoreApplication.Data.Common;
using AspNetCoreApplication.Data;

namespace AspNetCoreApplication.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _iProductRepository;

        public ProductService(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        public async Task<ProductOutVM> GetProducts()
        {
            ProductOut products = await _iProductRepository.GetProducts();

            return Mapper.Map<ProductOutVM>(products);
        }

        public async Task<ResultServiceVM> CreateProduct(ProductInVM productInVM)
        {
            Product product = Mapper.Map<Product>(productInVM);

            ResultService resultService = new ResultService(new ProductValidation().Validate(product));

            if (resultService.Success)
            {
                await _iProductRepository.InsertAsync(product);
            }

            return Mapper.Map<ResultServiceVM>(resultService);
        }
    }
}
