﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class Registration : IObservable<IDiscountStrategy>
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

        public int getGrandTotal()
        {
            return discountStrategy.getTotal(this);
        }

        public void setDiscountStrategy(IDiscountStrategy ids) { discountStrategy = ids; }
        public IDiscountStrategy getDiscountStrategy() { return discountStrategy; }

        public IDisposable Subscribe(IObserver<IDiscountStrategy> observer)
        {
            throw new NotImplementedException();
        }
    }
}
