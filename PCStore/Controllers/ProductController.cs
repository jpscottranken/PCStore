﻿using Microsoft.AspNetCore.Mvc;
using PCStore.Models.DataLayer;
using PCStore.Models.DomainModels;
using PCStore.Models.ViewModels;

namespace PCStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository? _productRepository;
        private readonly ICategoryRepository? _categoryRepository;

        public ProductController(IProductRepository? productRepository, ICategoryRepository? categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Product>? products;
            string? currentCategory = "";

            if(string.IsNullOrEmpty(category))
            {
                products = _productRepository?.GetAllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                products = _productRepository?.GetAllProducts.Where(c => c?.Category?.CategoryName == category);
                currentCategory = _categoryRepository?.GetCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository?.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
