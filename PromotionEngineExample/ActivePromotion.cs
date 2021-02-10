using System.Collections.Generic;

namespace PromotionEngineExample
{
    public class ActivePromotion
    {
        public List<IPromotion> _promotions;

        public ActivePromotion()
        {
            _promotions = new List<IPromotion>();
        }

        public void AddPromotion(IPromotion promotion)
        {
            _promotions.Add(promotion);
        }
    }
}
