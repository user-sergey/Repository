using Microsoft.AspNetCore.Mvc;
using Web.Logic.Countries;
using Web.Models;
using Web.Storage.Entitiess;

namespace Web.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryManager _manager;

        public CountryController(ICountryManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var countries = await _manager.GetAll();
            return View(countries);
        }

        [HttpGet]
        [Route("countries")]
        public Task<IList<Country>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("countries")]
        public Task Create([FromBody] CreateCountryRequest request) => _manager.Create(request.Name);

        [HttpDelete]
        [Route("countries/{id}")]
        public Task Delete(int id) => _manager.Delete(id);
    }
}