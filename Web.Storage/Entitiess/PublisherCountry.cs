namespace Web.Storage.Entitiess
{
    public class PublisherCountry
    {
        [Key]
        public int Id { get; set; }
        public int? publisher { get; set; }
        public int? country { get; set; }

        [ForeignKey(nameof(publisher))]
        public virtual Publisher? Publisher { get; set; }

        [ForeignKey(nameof(country))]
        public virtual Country? Country { get; set; }

    }
}
