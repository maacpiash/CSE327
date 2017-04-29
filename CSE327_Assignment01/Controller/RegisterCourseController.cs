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

        public RegisterCourseController()
        {
            makeNewRegistration();
        }

        public void makeNewRegistration() { reg = new Registration(); }
        public bool addCourse(string id) { return reg.addCourse(CourseFactory.getInstance().getCourse(id)); }
        public Registration getRegistration() { return reg; }
        public Course getCourse(string id) { return CourseFactory.getInstance().getCourse(id); }
    }
}
