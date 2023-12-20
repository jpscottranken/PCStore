using PCStore.Models.DomainModels;

namespace PCStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product>? Products { get; set; } = null;

        //  JPS ADDED LINE BELOW
		public int ProductId { get; set; } = 0;
		public IEnumerable<Category>? Categories { get; set; }
        public string? CurrentCategory { get; set; } = string.Empty;
    }
}
