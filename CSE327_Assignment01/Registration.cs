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

        public Registration() { courseList = new List<Course>(); }

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

    }
}
