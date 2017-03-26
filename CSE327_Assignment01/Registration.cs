using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class Registration
    {
        private List<Course> courseList;
        private IExtraFeeCalculator iefc;
        private IDiscountStrategy discountStrategy;

        public Registration() { courseList = new List<Course>(); }
        
        public List<Course> getCourseList() { return courseList; }

        public bool addCourse(Course c)
        {
            if(!courseList.Contains(c))
            {
                courseList.Add(c);
                return true;
            }
            if(Program.success)
                MessageBox.Show("Course already added.", "Duplicate course", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;
        }

        public int getTotal()
        {
            int total = 0;
            if (courseList.Count > 0)
                foreach (Course c in courseList)
                    try { total += c.getSubTotal(); } catch { }
            return total;
        }

        public int getExtraFeeAmount()
        {
            iefc = CourseFactory.getInstance().getExtraFeeCalculator();
            return iefc.getExtraAmount(this.getTotal());
        }

        public int getDiscountedAmount()
        {
            return discountStrategy == null ? 0 : discountStrategy.getTotal(this);
        }

        public int getGrandTotal()
        {
            return getTotal() + getExtraFeeAmount() - getDiscountedAmount();
        }

        public void setDiscountStrategy(IDiscountStrategy ids) { discountStrategy = ids; }
        public IDiscountStrategy getDiscountStrategy() { return discountStrategy; }

        
    }
}
