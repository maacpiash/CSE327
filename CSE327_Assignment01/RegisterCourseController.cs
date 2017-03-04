using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class RegisterCourseController
    {
        private Registration reg;

        public void makeNewRegistration()
        {
            reg = new Registration();
        }

        public void addCourse(string id)
        {
            reg.addCourse(CourseFactory.getCourse(id));
        }

        public Registration getRegistration() { return reg; }
        public Course getCourse(string id) { return CourseFactory.getCourse(id); }
    }
}
