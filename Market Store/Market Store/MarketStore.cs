using System;

namespace Market_Store
{
    class MarketStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the turnover at the moment?");
            Console.Write("Value: ");
            var turnoverInput = Console.ReadLine();

            Console.WriteLine("What is the purchase at the moment?");
            Console.Write("Value: ");
            var purchaseInput = Console.ReadLine();

            if (Validator.Validate(purchaseInput) && Validator.Validate(turnoverInput))
            {
                var purchase = decimal.Parse(purchaseInput);
                var turnover = decimal.Parse(turnoverInput);



            }
        }
    }
}
