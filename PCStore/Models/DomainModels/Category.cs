﻿using System.ComponentModel.DataAnnotations;

namespace PCStore.Models.DomainModels
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "You must enter a category name.")]
        public string CategoryName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a category description.")]
        public string CategoryDescription { get; set; } = string.Empty;
    }
}
