using System;

namespace PromotionEngineExample
{

    public class PromotionEngine
    {
        public ActivePromotion ActivePromotion { get; }
        public PromotionEngine(ActivePromotion activePromotion)
        {
            ActivePromotion = activePromotion;
        }

        public int checkout(Cart cart)
        {
            int totalCost = 0;
            int totalDiscount = 0;
            foreach(var item in cart.Items)
            {
                totalCost += item.Price * item.Quantity;
            }

            foreach(var activePromotion in ActivePromotion._promotions)
            {
                totalDiscount += activePromotion.ApplyPromotion(cart.Items);
            }

            return totalCost - totalDiscount; 
        }
    }
}
