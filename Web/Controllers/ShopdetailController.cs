using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopdetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
