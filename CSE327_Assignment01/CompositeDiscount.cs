using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class CompositeDiscount : IDiscountStrategy
    {
        private List<IDiscountStrategy> discounts;
        private string type;
        protected CompositeDiscount instance;

        public CompositeDiscount()
        {
            discounts = new List<IDiscountStrategy>();
            instance = this;
        }

        public CompositeDiscount(string t)
        {
            discounts = new List<IDiscountStrategy>();
            type = t;
            instance = this;
        }

        public void addDiscount(IDiscountStrategy ids)
        {
            discounts.Add(ids);
            MessageBox.Show("Discount added successfully");
        }

        public void setType(string type) { this.type = type; }

        public string getType() { return type; }

        public int getTotal(Registration r)
        {
            if (type == "Best for NSU")
            {
                BestForNSU strat = new BestForNSU();
                return strat.GetTotal(r, discounts);
            }
            else
            {
                BestForStudent strat = new BestForStudent();
                return strat.GetTotal(r, discounts);
            }
        }
    }
}
