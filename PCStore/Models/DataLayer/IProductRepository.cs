using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductsOnSale { get; }
        Product GetProductById(int productId);
    }
}
