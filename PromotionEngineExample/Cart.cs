using System.Collections.Generic;

namespace PromotionEngineExample
{
    public class Cart
    {
        public List<CartItem> Items { get; }
        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            Items.Add(item);
        }

    }
}
