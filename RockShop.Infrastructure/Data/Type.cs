﻿using System.ComponentModel.DataAnnotations;

namespace RockShop.Infrastructure.Data
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; } = null!;
    }
}
