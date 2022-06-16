using Microsoft.AspNetCore.Mvc;
using Web.Logic.Commentaries;
using Web.Models;

namespace Web.Controllers
{
    public class CommentaryController : Controller
    {
        private readonly ICommentaryManager _manager;

        public CommentaryController(ICommentaryManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var commentaries = await _manager.GetAll();
            return View(commentaries);
        }

        [HttpGet]
        [Route("commentaries")]
        public Task<IList<Commentary>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("commentaries")]
        public Task Create([FromBody] CreateCommentaryRequest request) => _manager.Create(request.Content, request.userId, request.newsId);

        [HttpDelete]
        [Route("commentaries/{id}")]
        public Task Delete(int id) => _manager.Delete(id);
    }
}