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
        public static bool play;
        private static MySqlConnection connection;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            success = true;
            play = false;
            Application.Run(new RegistrationForm());
        }

        static void OpenConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=cse327;UID=maac;PASSWORD=1416;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        static void CreateCourses()
        {
            //string cmdString; //= "DROP TABLE IF EXISTS courses";
            //MySqlCommand init = new MySqlCommand(cmdString, connection);
            //init.ExecuteNonQuery();

            //cmdString = "create table courses (id char(9) not null primary key, title char(50), credit int, tpc int);";

            //cmdString = "create table programs (id char(9) not null primary key, title char(50), deptt char(3));";
            //cmdString = "create table registrations (id char(10) not null primary key, courses char(100), grandtotal int(6));";
            MySqlCommand sqlcmd; // = new MySqlCommand(cmdString, connection);
            //sqlcmd.ExecuteNonQuery();
            string cmdString = "insert into programs (id, title, deptt) values ('CSE 482', 'Web Development', 'CSE')," +
                "('CSE 418', 'Computer Graphics', 'CSE'), ('EEE 311', 'Analog Electronics II', 'EEE')," +
                "('PHY 108', 'Physics II', 'MPS'), ('PHY 107', 'Physics I', 'MPS')," +
                "('CSE 323', 'Operating System', 'CSE'), ('CSE 338', 'Networking', 'CSE')," +
                "('CSE 231', 'Digital Logic Design', 'CSE'), ('CSE 332', 'Computer Organization and Architecture', 'CSE')," +
                "('EEE 111','Analog Electronics I', 'EEE'), ('MAT 120', 'Calculus and Analytic Geometry I', 'MPS')," +
                "('MAT 130', 'Calculus and Analytic Geometry II', 'MPS'), ('MAT 240', 'Calculus and Analytic Geometry III', 'MPS')," +
                "('MAT 250', 'Calculus and Analytic Geometry IV', 'MPS'), ('MAT 350', 'Engineering Mathematics', 'MPS')," +
                "('MAT 361', 'Probability & Statistics', 'MPS'), ('CSE 215', 'Fundamentals of Computer Programming', 'CSE')," +
                "('CSE 115', 'Computing Concepts', 'CSE'), ('CSE 225', 'Data Structures', 'CSE'), ('EEE 141', 'Electrical Circuits', 'EEE')," +
                "('CSE 311', 'Database Management System', 'CSE'), ('CSE 273', 'Introduction to Theory of Computation', 'CSE')," +
                "('CSE 173', 'Discrete Mathematics', 'CSE'), ('ENV 107', 'Introduction to Environmental Science', 'ESM')," +
                "('ACT 201', 'Introduction to Financial Accounting', 'SBE');";
            
            sqlcmd = new MySqlCommand(cmdString, connection);
            sqlcmd.ExecuteNonQuery();
        }

    }
}
