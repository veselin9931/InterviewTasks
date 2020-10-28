
using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards
{
    public class BronzeCard : Card
    {
        public BronzeCard(decimal p, decimal t) : base(p)
        {
            this.PrevTurnover = t;
            this.DiscountRate();
        }

        public override decimal DiscountRate()
        {
            if (PrevTurnover > 300 )
            {
                this.DiscauntRate = 2.5M;
            }
            else if (PrevTurnover >= 100 && PrevTurnover <= 300)
            {
                this.DiscauntRate = 1;
            }

            return this.DiscauntRate;
        }
        public override void Print()
        {
            Console.WriteLine($"Purchase value: ${this.purchase}");
            Console.WriteLine($"Discount rate: ${this.DiscauntRate}");
            Console.WriteLine($"Discount: ${this.Discount(purchase)}");
            Console.WriteLine($"Total: ${this.TotalPurchase()}");
        }
    }
}
