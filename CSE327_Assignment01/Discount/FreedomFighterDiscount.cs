using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class FreedomFighterDiscount : IDiscountStrategy
    {
        public int getTotal(Registration r)
        {
            if (r.getCourseList().Count <= 5)
            {
                if (r.getTotal() + r.getExtraFeeAmount() > 20000)
                    return r.getDiscountStrategy() == null ? 0 : 20000;
                else return 0;
            }
            else
                throw new FreedomFighterCourseLimitExceeded();
        }
    }

    class FreedomFighterCourseLimitExceeded : Exception
    {
        public FreedomFighterCourseLimitExceeded() : base(String.Format("Progeny of a Freedom Fighter cannot take more than 5 courses.")) { }
    }
}
