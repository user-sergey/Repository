using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string News { get; set; }
        public string Category { get; set; }
    }
}
