using System;

namespace BusinessRuleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BuisnessRule buisnessRule = new BuisnessRule();
            var results = buisnessRule.ProcessBuisnessRule();

            foreach (var res in results)
                Console.WriteLine(res);
        }
    }
}
