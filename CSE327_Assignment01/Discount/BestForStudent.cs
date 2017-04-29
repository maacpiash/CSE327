using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    class BestForStudent : CompositeDiscount
    {
        public int GetTotal(Registration reg, List<IDiscountStrategy> discounts)
        {
            if (discounts.Count == 2)
            {
                return discounts[0].getTotal(reg) > discounts[1].getTotal(reg)
                    ? discounts[0].getTotal(reg) : discounts[1].getTotal(reg);
            }
            else if (discounts.Count == 3)
            {
                if (discounts[0].getTotal(reg) > discounts[1].getTotal(reg))
                    return discounts[2].getTotal(reg) > discounts[0].getTotal(reg)
                        ? discounts[2].getTotal(reg) : discounts[0].getTotal(reg);
                else
                    return discounts[2].getTotal(reg) > discounts[1].getTotal(reg)
                        ? discounts[2].getTotal(reg) : discounts[1].getTotal(reg);
            }
            return 0;
        }
    }
}
