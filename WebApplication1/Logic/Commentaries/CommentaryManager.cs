using Microsoft.EntityFrameworkCore;
using Web.Storage.Data;

namespace Web.Logic.Commentaries
{
    public class CommentaryManager : ICommentaryManager
    {
        private readonly AppDbContext _context;

        public CommentaryManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(string content, int? userid, int? newsid)
        {
            var commentary = new Commentary { Content = content, userId = userid, newsId = newsid };
            _context.Commentaries.Add(commentary);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var commentary = _context.Commentaries.FirstOrDefault(c => c.Id == id);
            if (commentary != null)
            {
                _context.Commentaries.Remove(commentary);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Commentary>> GetAll() => await _context.Commentaries.ToListAsync();
    }
}