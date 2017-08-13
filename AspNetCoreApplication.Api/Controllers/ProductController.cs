using AspNetCoreApplication.Service;
using AspNetCoreApplication.VM.Common;
using AspNetCoreApplication.VM.Product.In;
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
           return await _iProductService.GetProducts();
        }

        [HttpPost("CreateProduct")]
        public async Task<ResultServiceVM> CreateProduct([FromBody]ProductInVM productInVM)
        {
            return await _iProductService.CreateProduct(productInVM);
        }
    }
}
