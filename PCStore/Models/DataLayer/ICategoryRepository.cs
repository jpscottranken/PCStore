using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
