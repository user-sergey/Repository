using Microsoft.AspNetCore.Mvc;
using Web.Logic.Categories;
using Web.Models;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryManager _manager;

        public CategoryController(ICategoryManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index() 
        {
            var categories = await _manager.GetAll();
            return View(categories);
        }

        [HttpGet]
        [Route("categories")]
        public Task<IList<Category>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("categories")]
        public Task Create([FromBody] CreateCategoryRequest request) => _manager.Create(request.Name);
        // Препод назвал строку 23 "тестовым примером" (11 лекция; 2 видео; 38:20)

        [HttpDelete]
        [Route("categories/{id}")]
        public Task Delete(int id) => _manager.Delete(id);
    }
}
