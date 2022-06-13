namespace Web.Logic.Sources
{
    public interface ISourceManager
    {
        Task<IList<Source>> GetAll();
        Task Create(string name, string address);
        Task Delete(int id);
    }
}
