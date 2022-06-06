using Microsoft.EntityFrameworkCore;
using Web.Storage.Entitiess;

namespace Web.Storage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublisherCountry> PublisherCountries { get; set; } 
        public DbSet<Source> Sources { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
