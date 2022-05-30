using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int CompanyId { get; set; }
    }
}
