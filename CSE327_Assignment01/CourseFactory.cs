using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using MySql.Data.MySqlClient;

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

            string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "select * from courses;";
            MySqlCommand sqlcmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = sqlcmd.ExecuteReader();
            
            while (reader.Read())
            {
                Course x = new Course(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                cList.Add(x);
            }
            connection.Close();

            connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
            connection = new MySqlConnection(connectionString);
            connection.Open();

            query = "select * from programs;";
            sqlcmd = new MySqlCommand(query, connection);


            reader = sqlcmd.ExecuteReader();

            while(reader.Read())
            {
                foreach (Course c in cList)
                    if (reader.GetString(0) == c.getId())
                    {
                        c.setProgram(reader.GetString(2));
                        break;
                    }
            }

            connection.Close();


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
                    string type = typeof(IExtraFeeCalculator).Namespace.ToString() + "." + ConfigurationSettings.AppSettings["ClassName"].ToString();
                    efCalculator = (IExtraFeeCalculator) Activator.CreateInstance(Type.GetType(type));
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
            Program.success = (c.ToList().Count == 0) ? false : true;
            if (!Program.success)
                MessageBox.Show("No course found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return c.FirstOrDefault();
        }

        public List<Course> getCList()
        {
            return cList;
        }
    }
}
