using System.Collections.Generic;

namespace PromotionEngineExample
{
    public class BulkItemPromotion : IPromotion
    {
        public BulkItemPromotion(string SKU, int itemNumber, int discountedPrice)
        {
            this.SKU = SKU;
            this.itemNumber = itemNumber;
            this.DiscountedCost = discountedPrice;
        }

        public string SKU { get; }
        public int itemNumber { get; }
        public int DiscountedCost { get; }

        public int ApplyPromotion(List<CartItem> cartItems)
        {
            int discountAmount = 0;
            CartItem cartItemAppliocableForDiscount = cartItems.Find(x => x.SKU == SKU);

            if(cartItemAppliocableForDiscount!=null)
            {
                int totalCostWithoutDiscount = cartItemAppliocableForDiscount.Quantity * cartItemAppliocableForDiscount.Price;

                if (itemNumber <= cartItemAppliocableForDiscount.Quantity)
                {
                    int groupedItemInBulk = cartItemAppliocableForDiscount.Quantity / itemNumber;

                    int remainingItem = cartItemAppliocableForDiscount.Quantity % itemNumber;

                    discountAmount = totalCostWithoutDiscount - ((groupedItemInBulk * DiscountedCost) + (remainingItem * cartItemAppliocableForDiscount.Price));
                }
            }

            return discountAmount;
        }
    }
}
