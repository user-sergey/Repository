namespace Web.Models
{
    public class CreateNewsRequest
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int categoryId { get; set; }
        public int countryId { get; set; }
        public int publisherId { get; set; }
        public int sourceId { get; set; }
    }
}
