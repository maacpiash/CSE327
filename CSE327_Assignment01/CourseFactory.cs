using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace CSE327_Assignment01
{
    public class CourseFactory
    {
        private static CourseFactory instance;
        private IExtraFeeCalculator efCalculator;
        private List<Course> cList;
        
        

        public CourseFactory()
        {
            cList = new List<Course>();

            Course course = new Course();
            course.setId("CSE 327");
            course.setTitle("Soft. Eng.");
            course.setCredit(3);
            course.setTuitionPerCredit(1500);
            cList.Add(course);

            cList.Add(new Course("CSE 482", "Web Development", 3, 1500));
            cList.Add(new Course("CSE 418", "Computer Graphics", 3, 1500));
            cList.Add(new Course("EEE 311", "Analog Electronics II", 3, 1500));
            cList.Add(new Course("PHY 108", "Physics II", 3, 1500));
            cList.Add(new Course("PHY 107", "Physics I", 3, 1500));
            cList.Add(new Course("CSE 323", "Operating System", 3, 1500));
            cList.Add(new Course("CSE 338", "Networking", 3, 1500));
            cList.Add(new Course("CSE 231", "Digital Logic Design", 3, 1500));
            cList.Add(new Course("CSE 332", "Computer Organization and Architechture", 3, 1500));
            cList.Add(new Course("EEE 111", "Analog Electronics I", 3, 1500));
            cList.Add(new Course("MAT 120", "Calculus and Analytic Geometry-I", 3, 1500));
            cList.Add(new Course("MAT 130", "Calculus and Analytic Geometry-II", 3, 1500));
            cList.Add(new Course("MAT 240", "Calculus and Analytic Geometry-III", 3, 1500));
            cList.Add(new Course("MAT 250", "Calculus and Analytic Geometry-IV", 3, 1500));
            cList.Add(new Course("MAT 350", "Engineering Mathematics", 3, 1500));
            cList.Add(new Course("MAT 361", "Probability && Statistics", 3, 1500));
            cList.Add(new Course("CSE 215", "Fundamentals of Computer Programming", 3, 1500));
            cList.Add(new Course("CSE 115", "Computing Concepts", 3, 1500));
            cList.Add(new Course("CSE 225", "Data Structures", 3, 1500));
            cList.Add(new Course("EEE 141", "Electrical Circuits", 3, 1500));
            cList.Add(new Course("CSE 311", "Database Management System", 3, 1500));
            cList.Add(new Course("CSE 273", "Introduction to Theory of Computation", 3, 1500));
            cList.Add(new Course("CSE 173", "Discrete Mathematics", 3, 1500));

            instance = this;
        }

        public static CourseFactory getInstance()
        {
            Object sync = new object();
            lock(sync)
            {
                if (instance == null)
                    instance = new CourseFactory();
                return instance;
            }
            
        }

        public IExtraFeeCalculator getExtraFeeCalculator()
        {
            if(efCalculator == null)
            {
                try
                {
                    efCalculator = (IExtraFeeCalculator) Activator.CreateInstance(Type.GetType(Program.getTypeFromConfig()));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
            return efCalculator;
        }

        public Course getCourse(string id)
        {
            var c = cList.Where(course => course.getId() == id);
            if (c.ToList().Count == 0) { MessageBox.Show("No course found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); Program.success = false; }
            else { Program.success = true; }
            return c.FirstOrDefault();
        }
    }
}
