using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Commentary
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string User { get; set; }
        public string News { get; set; }
    }
}
