using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE327_Assignment01
{
    public partial class RegistrationForm : Form
    {
        private static RegisterCourseController rcc;
        public static Label l;
        public static List<Label> labels;
        public static int row;

        public RegistrationForm()
        {
            InitializeComponent();
            rcc = new RegisterCourseController();
            labels = new List<Label>();
            row = 0;
        }

        private void CourseRegForm_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void InitializeTable()
        {

        }

        private void AddCourseBttn_Click(object sender, EventArgs e)
        {
            
            if (rcc.addCourse(Txt.Text) && Program.success)
            {
                Course c = rcc.getCourse(Txt.Text);

                l = new Label() { Text = (row + 1).ToString(), Location = new Point(sl.Location.X, 10 + row * 25), Size = new Size(25, 13) };
                labels.Add(l);
                panel1.Controls.Add(l);

                l = new Label() { Text = c.getTitle(), Location = new Point(coursetitle.Location.X, 10 + row * 25), Size = new Size(225, 13) };
                labels.Add(l);
                panel1.Controls.Add(l);

                l = new Label() { Text = c.getCredit().ToString(), Location = new Point(credit.Location.X, 10 + row * 25) };
                labels.Add(l);
                panel1.Controls.Add(l);

                l = new Label() { Text = c.getTuitionPerCredit().ToString(), Location = new Point(tpc.Location.X, 10 + row * 25) };
                labels.Add(l);
                panel1.Controls.Add(l);

                l = new Label() { Text = c.getSubTotal().ToString(), Location = new Point(subtotal.Location.X, 10 + row * 25), Size = new Size(35, 13) };
                labels.Add(l);
                panel1.Controls.Add(l);

                totalLabel.Text = rcc.getRegistration().getExtraFeeAmount().ToString();
                gTotalLabel.Text = rcc.getRegistration().getGrandTotal().ToString();
                row++;
            }

        }

        private void NewRegBttn_Click(object sender, EventArgs e)
        {
            foreach (Label l in labels)
                panel1.Controls.Remove(l);
            row = 0;
            totalLabel.Text = "0";
            rcc.makeNewRegistration();
        }
    }
}
