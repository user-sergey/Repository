using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string News { get; set; }
        public string Source { get; set; }
        public string Country { get; set; }
    }
}
