using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class BDTaxCalculator
    {
        public static float calculateVATAmount(int total)
        {
            return (float)(total * 0.15);
        }
    }
}
