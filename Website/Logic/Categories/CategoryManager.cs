using Microsoft.EntityFrameworkCore;
using Website.Data;

namespace Web.Logic.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly AppDbContext _context;

        //public CategoryManager()  // Старый конструктор, вызывает ошибку
        //{
        //    _context = new AppDbContext();
        //}

        public CategoryManager(AppDbContext context) // Новый конструктор, подставляем контекст, а не создаем новый. Пишет, что ошибки больше нет.
        {
            _context = context;
        }
        public async Task Create(string name)
        {
            var category = new Category { Name = name };
            
            _context.Categories.Add(category);
            await _context.SaveChangesAsync(); // Физическое добавление результата предыдущей строки в БД
        }

        public async Task Delete(int id)
        {
           var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Category>> GetAll() => await _context.Categories.ToListAsync();
    }
}
