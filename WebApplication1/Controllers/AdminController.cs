using Microsoft.AspNetCore.Mvc;
using Web.Logic.Admins;
using Web.Models;
using Web.Storage.Entitiess;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _manager;

        public AdminController(IAdminManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var admins = await _manager.GetAll();
            return View(admins);
        }

        [HttpGet]
        [Route("admins")]
        public Task<IList<Admin>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("admins")]
        public Task Create([FromBody] CreateAdminRequest request) => _manager.Create(request.Name, request.LastName);

        [HttpDelete]
        [Route("admins/{id}")]
        public Task Delete(int id) => _manager.Delete(id);
    }
}