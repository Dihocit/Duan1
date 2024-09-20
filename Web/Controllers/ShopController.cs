using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models.EF;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly FoodContext _dbContext;
        public ShopController(FoodContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetIsComming()
        {
            var items = from p in _dbContext.Products
                        where p.IsComming == true
                        orderby p.CreatedBy descending
                        select p;
            return Ok(await items.Take(5).Select(i => new { i.Id,i.Title, i.Picture, i.Intro }).ToListAsync());
        }
        public IActionResult Kid()
        {
            return View();
        }
        public IActionResult Women()
        {
            return View();
        }
        public IActionResult Men()
        {
            return View();
        }
        public IActionResult Blazer()
        {
            return View();
        }
        public IActionResult Jumpsuits()
        {
            return View();
        }
        public IActionResult Shose()
        {
            return View();
        }
        public IActionResult Watch()
        {
            return View();
        }
        public IActionResult Tecnology()
        {
            return View();
        }
    }
}
