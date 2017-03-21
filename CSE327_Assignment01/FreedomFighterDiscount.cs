using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    class FreedomFighterDiscount : IDiscountStrategy
    {
        public int getTotal(Registration reg)
        {
            if (reg.getCourseList().Count <= 5)
            {
                int discount = reg.getDiscountStrategy() == null ? 0 : 20000;
                return (int)(reg.getTotal() + reg.getExtraFeeAmount() - discount);
            }
            else
                throw new Exception("Student who is a progeny of a Freedom Fighter cannot take more than 5 courses.");
        }
    }
}
