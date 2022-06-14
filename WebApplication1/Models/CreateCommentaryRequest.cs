namespace Web.Models
{
    public class CreateCommentaryRequest
    {
        public string Content { get; set; }
        public int userId { get; set; }
        public int newsId { get; set; }
    }
}
