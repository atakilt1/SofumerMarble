using Microsoft.AspNetCore.Mvc;

namespace SofumerMarble.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}