﻿namespace Web.Storage.Entitiess
{
    public class Source
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}