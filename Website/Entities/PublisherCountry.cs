namespace Web.Entities
{
    public class PublisherCountry
    {
        [Key]
        public int Id { get; set; }
        public int? publisherId { get; set; }
        public int? countryId { get; set; }

        [ForeignKey(nameof(publisherId))]
        public virtual Publisher? Publisher { get; set; }

        [ForeignKey(nameof(countryId))]
        public virtual Country? Country { get; set; }

    }
}
