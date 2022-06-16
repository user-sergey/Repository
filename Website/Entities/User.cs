﻿namespace Web.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? countryId { get; set; }

        [ForeignKey(nameof(countryId))]
        public virtual Country? Country { get; set; }
    }
}
