namespace BusinessRuleExample
{
    public class MembershipPaymentProcessingRule : IPaymentProcessingRule
    {
        private string productTitle;

        public MembershipPaymentProcessingRule(string productTitle)
        {
            this.productTitle = productTitle;
        }

        public string[] ApplyRule()
        {
            return new string[] { "Activate that membership","email to owner" };
        }
    }
}
