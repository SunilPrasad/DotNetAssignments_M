namespace BusinessRuleExample
{
    public class VideoPaymentProcessingRule : IPaymentProcessingRule
    {
        private string productTitle;

        public VideoPaymentProcessingRule(string productTitle)
        {
            this.productTitle = productTitle;
        }

        public string[] ApplyRule()
        {
            if (productTitle == "Learning to Ski")
                return new string[] { productTitle, "First Aid video" };
            return new string[] { productTitle };
        }
    }
}
