using Microsoft.AspNetCore.Mvc;
using Web.Logic.NewsNamespace;
using Web.Models;
using Web.Storage.Entitiess;

namespace Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsManager _manager;

        public NewsController(INewsManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var news = await _manager.GetAll();
            return View(news);
        }

        [HttpGet]
        [Route("newsnamespace")]
        public Task<IList<News>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("newsnamespace")]
        public Task Create([FromBody] CreateNewsRequest request) => _manager.Create(request.Name, request.Content, request.categoryId, request.countryId, request.publisherId, request.sourceId);

        [HttpDelete]
        [Route("newsnamespace/{id}")]
        public Task Delete(int id) => _manager.Delete(id);
    }
}
