namespace Web.Logic.Countries
{
    public interface ICountryManager
    {
        Task<IList<Country>> GetAll();
        Task Create(string name);
        Task Delete(int id);
    }
}
