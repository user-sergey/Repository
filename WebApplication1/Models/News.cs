using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Category { get; set; }
        public string Commentary { get; set; }
        public string Country { get; set; }
        public string Publisher { get; set; }
        public string Source { get; set; }


    }
}
