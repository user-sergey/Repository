namespace Web.Storage.Entitiess
{
    public class Commentary
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int? userId { get; set; }
        public int? newsId { get; set; }

        [ForeignKey(nameof(userId))]
        public virtual User? User { get; set; }

        [ForeignKey(nameof(newsId))]
        public virtual News? News { get; set; }
    }
}
