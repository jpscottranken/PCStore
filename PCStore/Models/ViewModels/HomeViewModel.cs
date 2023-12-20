using PCStore.Models.DomainModels;

namespace PCStore.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product>? ProductsOnSale { get; set; }
    }
}
