using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PCStoreContext _context;

        public CategoryRepository(PCStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories => _context.Categories;
    }
}
