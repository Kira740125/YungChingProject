﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YungChing.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
    }
}
