using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngineExample.Tests
{
    [TestClass]
    public class PromotionExampleTests
    {
        [TestMethod]
        public void VerifyBulkItemPromotionWithOneItem()
        {
            ActivePromotion activePromotion = new ActivePromotion();

            BulkItemPromotion bulkItemPromotion = new BulkItemPromotion("A", 3, 130);
            

            activePromotion.AddPromotion(bulkItemPromotion);

            CartItem cartItem = new CartItem(50, "A", 5);

            Cart cart = new Cart();
            cart.AddItem(cartItem);

            PromotionEngine promotionEngine = new PromotionEngine(activePromotion);

            int totalCost = promotionEngine.checkout(cart);

            Assert.AreEqual(230, totalCost);

        }

        [TestMethod]
        public void VerifyBulkItemPromotionWithTwoItem()
        {
            ActivePromotion activePromotion = new ActivePromotion();

            BulkItemPromotion bulkItemPromotionA = new BulkItemPromotion("A", 3, 130);
            BulkItemPromotion bulkItemPromotionB = new BulkItemPromotion("B", 2, 45);


            activePromotion.AddPromotion(bulkItemPromotionA);
            activePromotion.AddPromotion(bulkItemPromotionB);

            CartItem cartItemA = new CartItem(50, "A", 5);
            CartItem cartItemB = new CartItem(30, "B", 3);


            Cart cart = new Cart();
            cart.AddItem(cartItemA);
            cart.AddItem(cartItemB);

            PromotionEngine promotionEngine = new PromotionEngine(activePromotion);

            int totalCost = promotionEngine.checkout(cart);

            Assert.AreEqual(305, totalCost);

        }

        [TestMethod]
        public void VerifyMultiplePromotion()
        {
            ActivePromotion activePromotion = new ActivePromotion();

            BulkItemPromotion bulkItemPromotionA = new BulkItemPromotion("A", 3, 130);
            BulkItemPromotion bulkItemPromotionB = new BulkItemPromotion("B", 2, 45);
            CombineItemPromotion combineItemPromotionC = new CombineItemPromotion("C", "D", 30);


            activePromotion.AddPromotion(bulkItemPromotionA);
            activePromotion.AddPromotion(bulkItemPromotionB);
            activePromotion.AddPromotion(combineItemPromotionC);


            CartItem cartItemA = new CartItem(50, "A", 1);
            CartItem cartItemB = new CartItem(30, "B", 1);
            CartItem cartItemC = new CartItem(20, "C", 1);


            Cart cart = new Cart();
            cart.AddItem(cartItemA);
            cart.AddItem(cartItemB);
            cart.AddItem(cartItemC);

            PromotionEngine promotionEngine = new PromotionEngine(activePromotion);

            int totalCost = promotionEngine.checkout(cart);

            Assert.AreEqual(100, totalCost);

        }

        [TestMethod]
        public void VerifyMultiplePromotion_Scenerio_1()
        {
            ActivePromotion activePromotion = new ActivePromotion();

            BulkItemPromotion bulkItemPromotionA = new BulkItemPromotion("A", 3, 130);
            BulkItemPromotion bulkItemPromotionB = new BulkItemPromotion("B", 2, 45);
            CombineItemPromotion combineItemPromotionC = new CombineItemPromotion("C", "D", 30);


            activePromotion.AddPromotion(bulkItemPromotionA);
            activePromotion.AddPromotion(bulkItemPromotionB);
            activePromotion.AddPromotion(combineItemPromotionC);


            CartItem cartItemA = new CartItem(50, "A", 3);
            CartItem cartItemB = new CartItem(30, "B", 5);
            CartItem cartItemC = new CartItem(20, "C", 1);
            CartItem cartItemD = new CartItem(15, "D", 1);



            Cart cart = new Cart();
            cart.AddItem(cartItemA);
            cart.AddItem(cartItemB);
            cart.AddItem(cartItemC);
            cart.AddItem(cartItemD);

            PromotionEngine promotionEngine = new PromotionEngine(activePromotion);

            int totalCost = promotionEngine.checkout(cart);

            Assert.AreEqual(280, totalCost);

        }
    }
}
