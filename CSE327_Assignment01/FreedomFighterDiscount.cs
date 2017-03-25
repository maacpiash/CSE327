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
                if (reg.getTotal() + reg.getExtraFeeAmount() > 20000)
                    return reg.getDiscountStrategy() == null ? 0 : 20000;
                else return 0;
            }
            else
                throw new Exception("A student who is a progeny of a Freedom Fighter cannot take more than 5 courses.");
        }
    }
}
