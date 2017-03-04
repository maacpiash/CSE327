using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public class Course
    {
        /******************************** Properties ********************************/
        private string id;
        private string title;
        private int credit;
        private int tuitionPerCredit;


        /******************************* Constructors *******************************/
        public Course() { credit = 0; tuitionPerCredit = 0; }

        public Course(string id, string title, int credit, int tuitionPerCredit)
        {
            this.id = id;
            this.title = title;
            this.credit = credit;
            this.tuitionPerCredit = tuitionPerCredit;
        }


        /********************************* Setters *********************************/
        public void setId(string id) { this.id = id; }
        public void setTitle(string t) { this.title = t; }
        public void setCredit(int c) { credit = c; }
        public void setTuitionPerCredit(int tpc) { tuitionPerCredit = tpc; }


        /********************************* Getters *********************************/
        public string getId() { return id; }
        public string getTitle() { return title; }
        public int getCredit() { return credit; }
        public int getTuitionPerCredit() { return tuitionPerCredit; }


        /***************************** Other Method(s) *****************************/
        public int getSubTotal() { return credit * tuitionPerCredit; }
    }
}
