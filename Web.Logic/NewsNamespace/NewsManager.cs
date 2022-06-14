using Microsoft.EntityFrameworkCore;
using Web.Storage.Data;

namespace Web.Logic.NewsNamespace
{
    public class NewsManager : INewsManager
    {
        private readonly AppDbContext _context;

        public NewsManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(string? name, string? content, int? categoryid, int? countryid, int? publisherid, int? sourceid)
        {
            var news = new News { Name = name, categoryId = categoryid, countryId = countryid, publisherId = publisherid, sourceId = sourceid};
            _context.NewsNamespace.Add(news);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var news = _context.NewsNamespace.FirstOrDefault(n => n.Id == id);
            if (news != null)
            {
                _context.NewsNamespace.Remove(news);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<News>> GetAll() => await _context.NewsNamespace.ToListAsync();
    }
}
