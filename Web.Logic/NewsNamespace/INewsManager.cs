namespace Web.Logic.NewsNamespace
{
    public interface INewsManager
    {
        Task<IList<News>> GetAll();
        Task Create(string? name, int? categoryid, int? countryid, int? publisherid, int? sourceid);
        Task Delete(int id);
    }
}