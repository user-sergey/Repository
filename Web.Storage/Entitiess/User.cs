namespace Web.Storage.Entitiess
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? country { get; set; }

        [ForeignKey(nameof(country))]
        public virtual Country? Country { get; set; }
    }
}
