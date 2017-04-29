using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public class RegistrationMapper : IMapper
    {
        string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
        MySqlConnection conn;

        public object get(string id)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string readcmd = string.Format("select * from registrations where id = '{0}';", id);
            MySqlCommand sqlcmd = new MySqlCommand(readcmd, conn);
            MySqlDataReader reader = sqlcmd.ExecuteReader();
            Registration reg = null;
            while (reader.Read())
            {
                if (reader.GetString(0) == id)
                {
                    reg = new Registration(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                    break;
                }

            }
            conn.Close();
            return reg;
        }

        public void put(object obj)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            Registration reg = obj as Registration;
            string cmd = string.Format("insert into registrations (id, courses, grandtotal) values ('{0}', '{1}', {2});", reg.getID(), reg.getCourses(), reg.getGrandTotal().ToString());
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
