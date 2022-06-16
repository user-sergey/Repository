using Microsoft.EntityFrameworkCore;
using Website.Data;

namespace Web.Logic.Countries
{
    public class CountryManager : ICountryManager
    {
        private readonly AppDbContext _context;

        public CountryManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(string name)
        {
            var country = new Country { Name = name };
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var country = _context.Countries.FirstOrDefault(c => c.Id == id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Country>> GetAll() => await _context.Countries.ToListAsync();
    }
}