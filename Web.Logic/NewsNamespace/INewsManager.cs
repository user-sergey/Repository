namespace Web.Logic.NewsNamespace
{
    public interface INewsManager
    {
        Task<IList<News>> GetAll();
        Task Create(string? name, string? content, int? categoryid, int? countryid, int? publisherid, int? sourceid);
        Task Delete(int id);
    }
}
