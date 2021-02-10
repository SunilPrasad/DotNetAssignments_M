using System.Collections.Generic;

namespace PromotionEngineExample
{
    public interface IPromotion
    {
        int ApplyPromotion(List<CartItem> cartItems);
    }
}
