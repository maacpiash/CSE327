using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CSE327_Assignment01
{
    static class Program
    {
        public static bool success;

        private static MySqlConnection connection;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            string cmdString = "DROP TABLE IF EXISTS courses";
            MySqlCommand init = new MySqlCommand(cmdString, connection);
            init.ExecuteNonQuery();


            cmdString = "create table courses (id char(8) not null primary key, title char(50), credit int, tpc int);";
            MySqlCommand sqlcmd = new MySqlCommand(cmdString, connection);
            sqlcmd.ExecuteNonQuery();
            try
            {
                cmdString = "insert into courses (id, title, credit, tpc) values ('CSE 482', 'Web Development', 3, 1500), ('CSE 418', 'Computer Graphics', 3, 1500), ('EEE 311', 'Analog Electronics II', 3, 1500), ('PHY 108', 'Physics II', 3, 1500), ('PHY 107', 'Physics I', 3, 1500), ('CSE 323', 'Operating System', 3, 1500), ('CSE 338', 'Networking', 3, 1500), ('CSE 231', 'Digital Logic Design', 3, 1500), ('CSE 332', 'Computer Organization and Architecture', 3, 1500), ('EEE 111','Analog Electronics I', 3, 1500), ('MAT 120', 'Calculus and Analytic Geometry I', 3, 1500), ('MAT 130', 'Calculus and Analytic Geometry II', 3, 1500), ('MAT 240', 'Calculus and Analytic Geometry III', 3, 1500), ('MAT 250', 'Calculus and Analytic Geometry IV', 3, 1500), ('MAT 350', 'Engineering Mathematics', 3, 1500), ('MAT 361', 'Probability & Statistics', 3, 1500), ('CSE 215', 'Fundamentals of Computer Programming', 3, 1500), ('CSE 115', 'Computing Concepts', 3, 1500), ('CSE 225', 'Data Structures', 3, 1500), ('EEE 141', 'Electrical Circuits', 3, 1500), ('CSE 311', 'Database Management System', 3, 1500), ('CSE 273', 'Introduction to Theory of Computation', 3, 1500), ('CSE 173', 'Discrete Mathematics', 3, 1500);";
                sqlcmd = new MySqlCommand(cmdString, connection);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetType().ToString());
            }

            string readcmd = "select * from courses";
            sqlcmd = new MySqlCommand(readcmd, connection);

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            List<Course> courses = new List<Course>();

            while (reader.Read()) courses.Add(new Course(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));

            string msg = "";
            courses.ForEach(c => msg = msg + c.getId() + " :: " + c.getTitle() + Environment.NewLine);
            MessageBox.Show(msg);



            connection.Close();

            //connection = new MySqlConnection(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            success = true;
            Application.Run(new RegistrationForm());
        }
    }
}
