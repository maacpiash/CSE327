using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public abstract class CompositeDiscount : IDiscountStrategy
    {
        private int total_disc;
        protected List<IDiscountStrategy> discounts;

        public CompositeDiscount()
        {
            total_disc = 0;
            discounts = new List<IDiscountStrategy>();
        }

        public void add(IDiscountStrategy disc_strat)
        {
            discounts.Add(disc_strat);
        }

        public abstract int getTotal(Registration reg);
        //{
        //    int total = 0;
        //    discounts.ForEach(x => total += x.getTotal(reg));
        //    return total;
        //}
    }
}
