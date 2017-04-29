using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class CourseMapper : IMapper
    {
        string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
        MySqlConnection conn;

        public object get(string id)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string readcmd = string.Format("select * from courses where id = '{0}';", id);
            MySqlCommand sqlcmd = new MySqlCommand(readcmd, conn);
            MySqlDataReader reader = sqlcmd.ExecuteReader();
            Course course = null;
            while (reader.Read())
            {
                if (reader.GetString(0) == id)
                {
                    course = new Course(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    break;
                }

            }
            conn.Close();
            return course;
        }

        public void put(object obj)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            Course course = obj as Course;
            string cmd = string.Format("insert into courses (id, title, credit, tpc) values ('{0}', '{1}', {2}, {3});", course.getId(), course.getTitle(), course.getCredit().ToString(), course.getTuitionPerCredit().ToString());
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
