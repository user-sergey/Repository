namespace Web.Logic.Admins
{
    public interface IAdminManager
    {
        Task<IList<Admin>> GetAll();
        Task Create(string name, string lastname);
        Task Delete(int id);
    }
}
