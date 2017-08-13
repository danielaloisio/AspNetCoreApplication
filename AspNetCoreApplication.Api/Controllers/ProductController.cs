using AspNetCoreApplication.Service.Product;
using AspNetCoreApplication.VM.Product.Out;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _iProductService;

        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }

        [HttpGet("GetProducts")]
        public async Task<ProductOutVM> GetProducts()
        {
            ProductOutVM products = await _iProductService.GetProducts();

            return products;
        }
    }
}
