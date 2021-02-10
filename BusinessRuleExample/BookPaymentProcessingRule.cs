namespace BusinessRuleExample
{
    public class BookPaymentProcessingRule : IPaymentProcessingRule
    {
        private string productTitle;

        public BookPaymentProcessingRule(string productTitle)
        {
            this.productTitle = productTitle;
        }

        public string[] ApplyRule()
        {
            return new string[] { "duplicate packing slips for the royalty department" };
        }
    }
}
