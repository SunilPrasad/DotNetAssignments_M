using System.Collections.Generic;

namespace BusinessRuleExample
{
    public class BuisnessRule
    {
        List<IPaymentProcessingRule> _paymentProcessingRule;

        public BuisnessRule()
        {
            _paymentProcessingRule = new List<IPaymentProcessingRule>();

            _paymentProcessingRule.Add(new PhysicalProductPaymentProcessingRule("PhysicalProduct"));
            _paymentProcessingRule.Add(new BookPaymentProcessingRule("Book"));
            _paymentProcessingRule.Add(new MembershipPaymentProcessingRule("Memebrship"));
            _paymentProcessingRule.Add(new UpgradePaymentProcessingRule("Upgrdae"));
            _paymentProcessingRule.Add(new VideoPaymentProcessingRule("Learning to Ski"));
        }
        public List<string> ProcessBuisnessRule()
        {
            List<string> results = new List<string>();

            foreach (var rule in _paymentProcessingRule)
            {
                string[] res = rule.ApplyRule();

                results.AddRange(res);
            }

            return results;
        }
    }
}
