using Microsoft.EntityFrameworkCore;
using Web.Storage.Data;

namespace Web.Logic.Admins
{
    public class AdminManager : IAdminManager
    {
        private readonly AppDbContext _context;

        public AdminManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(string name, string lastname)
        {
            var admin = new Admin { Name = name, LastName = lastname };
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Id == id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Admin>> GetAll() => await _context.Admins.ToListAsync();
    }
}