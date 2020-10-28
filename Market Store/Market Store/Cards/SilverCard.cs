using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards
{
    public class SilverCard : Card
    {
        public SilverCard(decimal p, decimal t) : base(p)
        {
            this.PrevTurnover = t;
            this.DiscountRate();
        }

        public override decimal DiscountRate()
        {
            this.DiscauntRate = 2;
          
            if (PrevTurnover > 300)
            {
                this.DiscauntRate = 3.5M;
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
