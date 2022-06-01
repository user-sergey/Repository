namespace Web.Storage.Entitiess
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? category { get; set; }
        public int? country { get; set; }
        public int? publisher { get; set; }
        public int? source { get; set; }

        [ForeignKey(nameof(category))]
        public virtual Category? Category { get; set; }

        [ForeignKey(nameof(country))]
        public virtual Country? Country { get; set; }

        [ForeignKey(nameof(publisher))]
        public virtual Publisher? Publisher { get; set; }

        [ForeignKey(nameof(source))]
        public virtual Source? Source { get; set; }
    }
}
