﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Barkeeper2.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public bool Liquid { get; set; }
        public string Name { get; set; }

        public string CreatedById { get; set; }

        [ForeignKey("CreatedById")]
        public ApplicationUser CreatedBy { get; set; }

    }
}
