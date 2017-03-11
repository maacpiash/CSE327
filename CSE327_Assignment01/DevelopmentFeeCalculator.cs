using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class DevelopmentFeeCalculator : IExtraFeeCalculator
    {
        public int getExtraAmount(int courseTotal)
        {
            return (int)Math.Ceiling(courseTotal * 0.1);
        }
    }
}
