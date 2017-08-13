using AspNetCoreApplication.Data;
using AspNetCoreApplication.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreApplication.Data.Entities.Product.Out;
using System.Threading.Tasks;
using AspNetCoreApplication.Helper.Helper;
using System.Linq;
using AspNetCoreApplication.Data.Entities.Product.Model;

namespace AspNetCoreApplication.Repository
{
    public class ProductRepository : RepositoryGeneric<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        :base(context)
        {
            _context = context;
        }

        public async Task<ProductOut> GetProducts()
        {
            return await AsyncHelper.AsyncFunction<ProductOut>(() =>
            {
                ProductOut productOut = new ProductOut();

                productOut.Products = _context.Products.Select(x => new ProductModel
                {
                    ProductId = x.ProductId,
                    Name = x.Name,

                }).ToList();

                return productOut;
            });
        }
    }
}
