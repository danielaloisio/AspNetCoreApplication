using AspNetCoreApplication.Data.Entities.Product.Out;
using System.Threading.Tasks;
using AspNetCoreApplication.Data.Model;

namespace AspNetCoreApplication.Repository
{
    public interface IProductRepository : IRepositoryGeneric<Product>
    {
        Task<ProductOut> GetProducts();
    }
}
