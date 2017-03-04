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
            tablePanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            InitializeTable();
            resize();
        }

        public void InitializeTable()
        {
            l = new Label();
            l.Text = "SL #";
            tablePanel.Controls.Add(l, 0, 0);

            l = new Label();
            l.Text = "Course Title";
            tablePanel.Controls.Add(l, 1, 0);

            l = new Label();
            l.Text = "Credit";
            tablePanel.Controls.Add(l, 2, 0);

            l = new Label();
            l.Text = "Tuition / Credit";
            tablePanel.Controls.Add(l, 3, 0);

            l = new Label();
            l.Text = "Sub Total";
            tablePanel.Controls.Add(l, 4, 0);

            for(int i = 0; i < tablePanel.ColumnCount; i++)
            {
                ColumnStyle cs = new ColumnStyle(SizeType.Percent, 20);

            }

            //Total();
        }

        public void resize()
        {
            tablePanel.Width = Width - 37;
            tablePanel.Height = Height - 196;
        }

        private void RegistrationForm_SizeChanged(object sender, EventArgs e)
        {
            resize();
        }

        public void Total()
        {
            tablePanel.RowCount++;
            l = new Label();
            l.Text = "Total";
            tablePanel.Controls.Add(l, 3, tablePanel.RowCount - 1);
        }

        private void NewRegBttn_Click(object sender, EventArgs e)
        {
            Controls.Remove(tablePanel);
            tablePanel = new TableLayoutPanel();
            tablePanel.Location = new Point(9, 145);
            Controls.Add(tablePanel);
            tablePanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            InitializeTable();
            resize();
        }

        private void AddCourseBttn_Click(object sender, EventArgs e)
        {
            rcc.addCourse(Txt.Text);
        }
    }
}
