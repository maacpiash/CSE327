using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class Registration
    {
        private List<Course> courseList;
        
        public Registration()
        {
            courseList = new List<Course>();
        }

        public void addCourse(Course c)
        {
            courseList.Add(c);
        }

        public int getTotal()
        {
            int total = 0;
            foreach (Course c in courseList)
                total += c.getSubTotal();
            return total;
        }

    }
}
