using System.ComponentModel.DataAnnotations;

namespace PCStore.Models.DomainModels
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "You must enter a product name.")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a product description.")]
        public string ProductDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a product price.")]
        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than 0.")]
        public double ProductPrice { get; set; }

        public string ProductImageURL { get; set; } = string.Empty;
        public string ProductImageThumbnailURL { get; set; } = string.Empty;
        public bool IsProductOnSale { get; set; } = false;
        public bool IsProductInStock { get; set; } = true;

        public int CategoryID { get; set; } // Foreign Key
        public Category? Category { get; set; } // Navigation Property

    }
}
