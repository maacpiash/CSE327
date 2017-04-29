using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSE327_Assignment01
{
    public class Registration
    {
        // create table courses (id char(8) not null primary key, title char(50), credit int, tpc int;
        // CREATE TABLE courses (id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, state CHAR(25), population INT(9));
        /* insert into courses (id, title, credit, tpc) values ("CSE 482", "Web Development", 3, 1500), ("CSE 418", "Computer Graphics", 3, 1500), ("EEE 311", "Analog Electronics II", 3, 1500), ("PHY 108", "Physics II", 3, 1500), ("PHY 107", "Physics I", 3, 1500), ("CSE 323", "Operating System", 3, 1500), ("CSE 338", "Networking", 3, 1500), ("CSE 231", "Digital Logic Design", 3, 1500), ("CSE 332", "Computer Organization and Architecture", 3, 1500), ("EEE 111", "Analog Electronics I", 3, 1500), ("MAT 120", "Calculus and Analytic Geometry-I", 3, 1500), ("MAT 130", "Calculus and Analytic Geometry-II", 3, 1500), ("MAT 240", "Calculus and Analytic Geometry-III", 3, 1500), ("MAT 250", "Calculus and Analytic Geometry-IV", 3, 1500), ("MAT 350", "Engineering Mathematics", 3, 1500), ("MAT 361", "Probability && Statistics", 3, 1500), ("CSE 215", "Fundamentals of Computer Programming", 3, 1500), ("CSE 115", "Computing Concepts", 3, 1500), ("CSE 225", "Data Structures", 3, 1500), ("EEE 141", "Electrical Circuits", 3, 1500), ("CSE 311", "Database Management System", 3, 1500), ("CSE 273", "Introduction to Theory of Computation", 3, 1500), ("CSE 173", "Discrete Mathematics", 3, 1500);
            */

        private string id;
        private List<Course> courseList;
        private string courses;
        private IExtraFeeCalculator iefc;
        private IDiscountStrategy discountStrategy;
        private int grandTotal;
        private int gt;
        private string obtainedCourses;

        public Registration()
        {
            courseList = new List<Course>();
            grandTotal = 0;
        }

        public Registration(string id, string courses, int gt)
        {
            this.id = id;
            obtainedCourses = courses;
            courseList = new List<Course>();
            this.gt = gt;
        }

        public string ObtainedCourses() { return obtainedCourses; }
        
        public List<Course> getCourseList() { return courseList; }

        public string getID() { return id; }
        public void setID(string ID) { this.id = ID; }

        public string getCourses()
        {
            courses = courseList[0].ToString();
            for (int i = 1; i < courseList.Count; i++)
                courses = courses + ", " + courseList[i].ToString();
            obtainedCourses = courses;
            return courses;
        }
        public void setCourses()
        {
            courses = courseList[0].ToString();
            for (int i = 1; i < courseList.Count; i++)
                courses = courses + ", " + courseList[i].ToString();
        }

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
            grandTotal = getTotal() + getExtraFeeAmount() - getDiscountedAmount();
            gt = grandTotal;
            return grandTotal;
        }

        public int getGT()
        {
            return gt;
        }

        public void setDiscountStrategy(IDiscountStrategy ids) { discountStrategy = ids; }
        public IDiscountStrategy getDiscountStrategy() { return discountStrategy; }

        
    }
}
