using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
