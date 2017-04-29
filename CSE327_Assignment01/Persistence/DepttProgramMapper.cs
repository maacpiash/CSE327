using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class DepttProgramMapper : IMapper
    {
        string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
        MySqlConnection conn;

        public object get(string id)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string readcmd = string.Format("select * from programs where id = '{0}';", id);
            MySqlCommand sqlcmd = new MySqlCommand(readcmd, conn);
            MySqlDataReader reader = sqlcmd.ExecuteReader();
            DepttProgram dp = null;
            while (reader.Read())
            {
                if (reader.GetString(0) == id)
                {
                    dp = new DepttProgram(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    break;
                }

            }
            conn.Close();
            return dp;
        }

        public void put(object obj)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            DepttProgram dp = obj as DepttProgram;
            string cmd = string.Format("insert into programs (id, title, deptt) values ('{0}', '{1}', '{2}');", dp.getId(), dp.getTitle(), dp.getDepartment());
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
