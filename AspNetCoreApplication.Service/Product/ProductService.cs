using System.Threading.Tasks;
using AspNetCoreApplication.VM.Product.Out;
using AspNetCoreApplication.Data.Entities.Product.Out;
using AspNetCoreApplication.Helper.Mapper;
using AspNetCoreApplication.Repository;

namespace AspNetCoreApplication.Service.Product
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
    }
}
