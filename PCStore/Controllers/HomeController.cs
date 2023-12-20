using Microsoft.AspNetCore.Mvc;
using PCStore.Models.DataLayer;
using PCStore.Models.ViewModels;

namespace PCStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository? _productRepository;

        public HomeController(IProductRepository productRepository) => _productRepository = productRepository;

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOnSale = _productRepository?.GetProductsOnSale
            };

            return View(homeViewModel);
        }
    }
}
