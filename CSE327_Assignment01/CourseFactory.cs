using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class CourseFactory
    {
        private static List<Course> cList;

        public CourseFactory()
        {
            cList = new List<Course>();

            Course course = new Course();
            course.setId("CSE 327");
            course.setTitle("Soft. Eng.");
            course.setCredit(3);
            course.setTuitionPerCredit(1500);
            cList.Add(course);

            cList.Add(new Course("CSE 418", "Computer Graphics", 3, 1500));
            cList.Add(new Course("EEE 311", "Analog Elec. II", 3, 1500));
            cList.Add(new Course("PHY 108", "Physics II", 3, 1500));
            cList.Add(new Course("CSE 323", "Operating System", 3, 1500));
            cList.Add(new Course("CSE 338", "Networking", 3, 1500));
            cList.Add(new Course("CSE 332", "Computer Arch.", 3, 1500));
            cList.Add(new Course("EEE 111", "Analog Elec. I", 3, 1500));
            cList.Add(new Course("MAT 350", "Engineering Math.", 3, 1500));
            cList.Add(new Course("MAT 361", "Probability & Stat.", 3, 1500));
        }
        

        public Course getCourse(string id)
        {
            var c = cList.Where(course => course.getId() == id);
            if (c.ToList().Count == 0) MessageBox.Show("No course found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return c.FirstOrDefault();
        }
    }
}
