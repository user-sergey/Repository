namespace Web.Logic.Categories
{
    public interface ICategoryManager
    {
        Task<IList<Category>> GetAll();
        Task Create(string name);
        Task Delete(string id);
    }
}
