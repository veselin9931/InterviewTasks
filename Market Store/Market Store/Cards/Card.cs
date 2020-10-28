using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Cards
{
    public abstract class Card
    {

        public abstract decimal TotalPurchase();

        public abstract decimal DiscountRate();

        public abstract decimal Discount();


    }
}
