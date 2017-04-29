using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class DepttProgram
    {
        // ID
        private string id;
        public string getId() { return id; }
        public void setId(string _id) {id = _id; }

        // Title
        private string title;
        public string getTitle() { return title; }
        public void setTitle(string _title) { title = _title; }

        // Department
        private string department;
        public string getDepartment() { return department; }
        public void setDepartment(string _department) { department = _department; }

        // Constructor
        public DepttProgram(string i, string t, string d)
        {
            id = i;
            title = t;
            department = d;
        }
    }
}