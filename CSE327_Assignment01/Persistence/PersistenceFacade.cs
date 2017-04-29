using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class PersistenceFacade
    {
        private static PersistenceFacade instance;
        private Dictionary<Type, IMapper> mappers;
        

        public PersistenceFacade()
        {
            mappers = new Dictionary<Type, IMapper>();
            mappers.Add(typeof(CSE327_Assignment01.RegistrationMapper), new RegistrationMapper());
            mappers.Add(typeof(CSE327_Assignment01.CourseMapper), new CourseMapper());
            mappers.Add(typeof(CSE327_Assignment01.DepttProgram), new DepttProgramMapper());
        }

        public static PersistenceFacade getInstance()
        {
            Object sync = new object();
            lock(sync)
            {
                if (instance == null)
                    instance = new PersistenceFacade();
            }
            return instance;
        }

        


        // DepttProgram
        public void put(DepttProgram dp)
        {
            DepttProgramMapper map = new DepttProgramMapper();
            map.put(dp);
        }

        public Object get(string id, DepttProgram dp)
        {
            DepttProgramMapper map = new DepttProgramMapper();
            return map.get(id) as DepttProgram;
        }


        // Course
        public void put(Course c)
        {
            CourseMapper map = new CourseMapper();
            map.put(c);
        }

        public Object get(string id, Course c)
        {
            CourseMapper map = new CourseMapper();
            return map.get(id) as Course;
        }

        // Registration
        public void put(Registration reg)
        {
            RegistrationMapper map = new RegistrationMapper();
            map.put(reg);
        }

        public Object get(string id, Registration reg)
        {
            RegistrationMapper map = new RegistrationMapper();
            return map.get(id) as Registration;
        }
    }
}
