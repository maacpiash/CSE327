using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class Course
    {
        private int id { get { return id; } set { if(value != 0) id = value; } }
        public string title { get; set; }
        public int credit { get; set; }
        public int tuitionPerCredit { get; set; }


    }
}
