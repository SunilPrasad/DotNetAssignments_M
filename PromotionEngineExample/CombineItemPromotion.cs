using System.Collections.Generic;

namespace PromotionEngineExample
{
    public class CombineItemPromotion : IPromotion
    {
        public CombineItemPromotion(string sKU1, string sKU2, int totalCost)
        {
            SKU1 = sKU1;
            SKU2 = sKU2;
            TotalCost = totalCost;
        }

        public string SKU1 { get; }
        public string SKU2 { get; }
        public int TotalCost { get; }

        public int ApplyPromotion(List<CartItem> cartItems)
        {
            CartItem itemOne = cartItems.Find(x => x.SKU == SKU1);
            CartItem itemTwo = cartItems.Find(x => x.SKU == SKU2);
            int discount = 0;
            if(itemOne!=null && itemTwo!= null)
            {
                int totalCostWithoutDiscount = itemOne.Price + itemTwo.Price;

                discount = totalCostWithoutDiscount - TotalCost;
            }

            return discount;
        }
    }
}
