using Market_Store.Cards;
using Microsoft.VisualBasic;
using System;
using System.Threading;

namespace Market_Store
{
    class MarketStore
    {
        public static string turnoverInput;

        public static string purchaseInput;

        public static string type;

        static void Main(string[] args)
        {
            Read();

            while (true)
            {
                if (turnoverInput == "END")
                {
                    break;
                };

                if (Validator.Validate(purchaseInput) && Validator.Validate(turnoverInput))
                {
                    var purchase = decimal.Parse(purchaseInput);
                    var turnover = decimal.Parse(turnoverInput);
                    Card card;
                    if (type == "bronze")
                    {
                        card = new BronzeCard(purchase, turnover);
                    }
                    else if(type == "silver")
                    {
                        card = new SilverCard(purchase, turnover);
                    }
                    else if (type == "gold")
                    {
                        card = new GoldCard(purchase, turnover);
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid type of Card");
                    }

                    card.Print();
                    Read();
                }
            }
        }

        public static void Read()
        {
            Console.WriteLine("What is the turnover? or END");
            Console.Write("Value: ");
            turnoverInput = Console.ReadLine();

            Console.WriteLine("What is the purchase at the moment?");
            Console.Write("Value: ");
            purchaseInput = Console.ReadLine();

            Console.WriteLine("What is the type of cart?");
            Console.Write("Value (bronze/gold/silver): ");
            type = Console.ReadLine();
        }
    }
}
