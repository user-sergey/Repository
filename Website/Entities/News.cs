namespace Web.Entities
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public int? categoryId { get; set; }
        public int? countryId { get; set; }
        public int? publisherId { get; set; }
        public int? sourceId { get; set; }

        [ForeignKey(nameof(categoryId))]
        public virtual Category? Category { get; set; }

        [ForeignKey(nameof(countryId))]
        public virtual Country? Country { get; set; }

        [ForeignKey(nameof(publisherId))]
        public virtual Publisher? Publisher { get; set; }

        [ForeignKey(nameof(sourceId))]
        public virtual Source? Source { get; set; }
    }
}
