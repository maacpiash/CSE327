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

        public RegistrationForm()
        {
            InitializeComponent();
            rcc = new RegisterCourseController();
            rcc.makeNewRegistration();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            tableView.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tableView.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            resize();
            InitializeTable();
        }

        public void InitializeTable()
        {
            l = new Label();
            l.Text = "SL #";
            tableView.Controls.Add(l, 0, 0);

            l = new Label();
            l.Text = "Course Title";
            tableView.Controls.Add(l, 1, 0);

            l = new Label();
            l.Text = "Credit";
            tableView.Controls.Add(l, 2, 0);

            l = new Label();
            l.Text = "Tuition / Credit";
            tableView.Controls.Add(l, 3, 0);

            l = new Label();
            l.Text = "Sub Total";
            tableView.Controls.Add(l, 4, 0);

            Total();
        }

        public void resize()
        {
            tableView.Width = Width - 37;
            tableView.Height = Height - 196;
        }

        private void RegistrationForm_SizeChanged(object sender, EventArgs e)
        {
            resize();
        }

        public void Total()
        {
            tableView.RowCount++;
            l = new Label();
            l.Text = "Total";
            tableView.Controls.Add(l, 3, tableView.RowCount - 1);
        }

        private void NewRegBttn_Click(object sender, EventArgs e)
        {
            Controls.Remove(tableView);
        }

        private void AddCourseBttn_Click(object sender, EventArgs e)
        {
            rcc.addCourse(Txt.Text);
        }
    }
}
