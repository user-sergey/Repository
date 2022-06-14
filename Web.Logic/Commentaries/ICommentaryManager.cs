namespace Web.Logic.Commentaries
{
    public interface ICommentaryManager
    {
        Task<IList<Commentary>> GetAll();
        Task Create(string content, int? userid, int? newsid);
        Task Delete(int id);
    }
}
