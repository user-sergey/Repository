﻿using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
    }
}
