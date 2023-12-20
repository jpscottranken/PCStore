using Microsoft.AspNetCore.Mvc;
using PCStore.Models.DataLayer;
using PCStore.Models.DomainModels;

namespace PCStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Cart is Empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);

                _shoppingCart.ClearCart();

                RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
