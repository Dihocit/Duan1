using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ActicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
