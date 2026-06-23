using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SofumerMarble.Data;
using SofumerMarble.Models;

namespace SofumerMarble.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList  = _db.Category.ToList();
            return View(objList);
        }
    }
}