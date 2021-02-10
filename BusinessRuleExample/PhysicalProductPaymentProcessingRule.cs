namespace BusinessRuleExample
{
    public class PhysicalProductPaymentProcessingRule : IPaymentProcessingRule
    {
        private string productTitle;

        public PhysicalProductPaymentProcessingRule(string productTitle)
        {
            this.productTitle = productTitle;
        }

        public string[] ApplyRule()
        {
            return new string[] { "packing slip for shipping" };
        }
    }
}
