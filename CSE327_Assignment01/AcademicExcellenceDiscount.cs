using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class AcademicExcellenceDiscount : IDiscountStrategy
    {
        public int getTotal(Registration reg)
        {
            int discount = reg.getDiscountStrategy() == null ? 0 : (int)(reg.getTotal() * 0.5);
            return (int)(reg.getTotal() + reg.getExtraFeeAmount() - discount);
        }
    }
}
