using Microsoft.AspNetCore.Mvc;
using Web.Logic.Categories;
using Web.Storage.Data;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryManager _manager;

        public CategoryController(ICategoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var categories = _manager.GetAll;
            return View(categories);
        }
        [HttpPost]
        public IActionResult DeleteCategory(int categoryId) 
        {
            _manager.Delete(categoryId);
            return RedirectToAction("Index");
        }
    }
}
