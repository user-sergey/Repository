using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Storage.Models
{
    public class Commentary
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public int user { get; set; }
        public int news { get; set; }
         
        [ForeignKey(nameof(user))]
        public virtual User User { get; set; }

        [ForeignKey(nameof(news))]
        public virtual News News { get; set; }
    }
}
