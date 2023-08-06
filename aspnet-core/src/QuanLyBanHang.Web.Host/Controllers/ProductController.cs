using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Controllers;

namespace QuanLyBanHang.Web.Host.Controllers
{
    [Route("api/services/app/ThanhToan")]
    [ApiController]
    public class ProductController : QuanLyBanHangControllerBase
    {
        private readonly ProductAppService _productAppService;

        public ProductController(ProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
    }
}
