using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CSE327_Assignment01
{
    static class Program
    {
        public static bool success;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            success = true;
            //string addr = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string fName = "typename.txt";
            //string fulladdr = System.IO.Path.Combine(addr, fName);
            
            
            //using (System.IO.StreamWriter f = new System.IO.StreamWriter(fulladdr))
            //{
            //        f.Write(type);
            //}
                
            //System.Configuration!System.Configuration.Configurationmanager.AppSettings
                Console.ReadLine();
            Application.Run(new RegistrationForm());
        }

        public static string getTypeFromConfig()
        {
            string targetAddr = System.IO.Path.Combine
                    (Environment.CurrentDirectory.ToString().TrimEnd("\\bin\\Debug".ToCharArray()),
                    "CourseRegister.config");
            string type = typeof(IExtraFeeCalculator).Namespace.ToString() + ".";
            string[] content = System.IO.File.ReadAllLines(targetAddr);
            for (int i = 33; content[3].ToCharArray()[i] != '"'; i++)
                type += (content[3].ToCharArray()[i]);
            return type;
        }
    }
}
