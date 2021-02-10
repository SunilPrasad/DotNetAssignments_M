namespace BusinessRuleExample
{
    public class UpgradePaymentProcessingRule : IPaymentProcessingRule
    {
        private string productTitle;

        public UpgradePaymentProcessingRule(string productTitle)
        {
            this.productTitle = productTitle;
        }

        public string[] ApplyRule()
        {
            return new string[] { "Upgrade that membership", "email to owner" };
        }

    }
}
