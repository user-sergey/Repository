using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Storage.Data;

namespace Web.Logic.Sources
{
    public class SourceManager : ISourceManager
    {
        private readonly AppDbContext _context;

        public SourceManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(string name, string address)
        {
            var source = new Source { Name = name, Address = address };
            _context.Sources.Add(source);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var source = _context.Sources.FirstOrDefault(c => c.Id == id);
            if (source != null)
            {
                _context.Sources.Remove(source);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Source>> GetAll() => await _context.Sources.ToListAsync();
    }
}

