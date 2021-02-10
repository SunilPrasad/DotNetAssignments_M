namespace PromotionEngineExample
{
    public class CartItem
    {
        public CartItem(int price , string SKU , int quantity)
        {
            this.Price = price;
            this.SKU = SKU;
            this.Quantity = quantity;
        }
        public int Price { get;}
        public string SKU { get; }
        public int Quantity { get; }
    }
}
