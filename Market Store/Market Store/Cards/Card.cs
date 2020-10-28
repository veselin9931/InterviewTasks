using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Market_Store.Cards
{
    public abstract class Card
    {

        private string owner;

        private decimal prevTurnover;

        public decimal purchase;

        public decimal discount;

        public Card(decimal purchase)
        {
            owner = this.Owner;
            prevTurnover = this.PrevTurnover;
            this.purchase = purchase;
        }


        public string Owner { get; set; }

        public decimal PrevTurnover { get; set; }

        public decimal DiscauntRate { get; set; }

        public abstract decimal DiscountRate();

        protected decimal TotalPurchase()
        {
            return purchase - discount;
        }
        protected decimal Discount(decimal purchase)
        {
            this.discount = purchase * this.DiscauntRate; ;
            return discount;
        }

        public abstract void Print();

    }
}
