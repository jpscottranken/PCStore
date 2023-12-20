namespace PCStore.Models.DomainModels
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string? ShoppingCartId { get; set; }
        public Product? Product { get; set; } = null;
        public int Amount { get; set; } = 0;
    }
}
