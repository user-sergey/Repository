﻿namespace Web.Storage.Entitiess
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
