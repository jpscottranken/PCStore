using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PCStoreContext? _context;
        private readonly ShoppingCart? _shoppingCart;

        public OrderRepository(PCStoreContext? context, ShoppingCart? shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _context.Orders.Add(order);
            _context.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach(var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = item.Amount,
                    Price = item.Product.ProductPrice,
                    ProductId = item.Product.ProductId,
                    OrderId = order.OrderId
                };

                _context.OrderDetails.Add(orderDetail);
            }

            _context.SaveChanges();
        }
    }
}
