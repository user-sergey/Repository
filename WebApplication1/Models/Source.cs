using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Source
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string News { get; set; }
    }
}
