using Microsoft.EntityFrameworkCore;
using PCStore.Models.DataLayer;

namespace PCStore.Models.DomainModels
{
    public class ShoppingCart
    {
        private readonly PCStoreContext _context;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }

        public ShoppingCart(PCStoreContext context) => _context = context;

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            var context = services.GetService<PCStoreContext>();
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int amount)
        {
            // Check to see if there is already one or more of product in shopping cart
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault
                         (s => s.Product.ProductId == product.ProductId 
                            && s.ShoppingCartId    == ShoppingCartId);

            // If the above was false, add the new product to the cart.
            // Otherwise, increase the amount of the existing product
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = amount
                };

                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault
                        (s => s.Product.ProductId == product.ProductId 
                         &&   s.ShoppingCartId    == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                // If product was found but has more than one in cart, reduce amount by one.
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    // Remove product from cart if there was only one item
                    //  JPS ADDED _context at beginning of next line
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where
                                    (p => p.ShoppingCartId == ShoppingCartId)
                                           .Include(s => s.Product).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems.Where
                             (c => c.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public double GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where
                         (c => c.ShoppingCartId == ShoppingCartId)
                                .Select(c => c.Product.ProductPrice * c.Amount).Sum();

            return total;
        }
    }
}
