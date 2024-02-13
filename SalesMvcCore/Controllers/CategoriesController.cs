using Microsoft.AspNetCore.Mvc;
using SalesMvcCore.Models;

namespace SalesMvcCore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly SalesDbContext _context;

        public CategoriesController(SalesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        //[NonAction]
        public JsonResult GetCategories()
        {
            var categories = _context.Categories.ToList();
            return Json(categories);
        }
        [HttpPost]
        public JsonResult PostCategories(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return Json("Saved");
            }
            else
            {
                return Json(category);
            }
        }
    }
}
