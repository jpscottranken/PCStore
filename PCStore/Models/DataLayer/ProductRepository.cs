using Microsoft.EntityFrameworkCore;
using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public class ProductRepository : IProductRepository
    {
        private readonly PCStoreContext _context;

        public ProductRepository(PCStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts
        {
            get { return _context.Products.Include(c => c.Category); }
        }

        public IEnumerable<Product> GetProductsOnSale
        {
            get { return _context.Products.Include(c => c.Category).Where(p => p.IsProductOnSale); }
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}