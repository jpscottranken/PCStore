﻿using PCStore.Models.DomainModels;

namespace PCStore.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart? ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
