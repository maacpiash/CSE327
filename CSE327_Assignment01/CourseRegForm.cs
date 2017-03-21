using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        public static List<CheckBox> checks;

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
            comboBox1.Text = "Best for NSU";
            checks = new List<CheckBox>() { chkAE, chkFF, chkAM };
            foreach(CheckBox c in checks) c.Click += C_Click;
            comboBox1.Enabled = false;
            calcDiscButton.Enabled = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (CheckBox c in checks) if (c.Checked) i++;
            comboBox1.Enabled = (i > 1);
            calcDiscButton.Enabled = (i > 0);
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
            discountLabel.Text = "0";
            gTotalLabel.Text = "0";
            rcc.makeNewRegistration();
            comboBox1.Enabled = false;
            calcDiscButton.Enabled = false;
            foreach (CheckBox c in checks) c.Checked = false;
        }

        private void calcDiscButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (CheckBox c in checks) if (c.Checked) i++;
            if (i == 0) return;
            IDiscountStrategy disc_strat;
            try
            {
                if (i == 1)
                {
                    if (chkAE.Checked)
                        disc_strat = new AcademicExcellenceDiscount();
                    else if (chkAM.Checked)
                        disc_strat = new AboriginalMinorityDiscount();
                    else // if (chkFF.Checked)
                        disc_strat = new FreedomFighterDiscount();
                    rcc.getRegistration().setDiscountStrategy(disc_strat);
                }
                else
                {
                    
                    if (comboBox1.Text == "Best for NSU")
                    {
                        disc_strat = new BestForNSU();
                        var ds = (BestForNSU)disc_strat;
                        if (chkAE.Checked) ds.add(new AcademicExcellenceDiscount());
                        if (chkAM.Checked) ds.add(new AboriginalMinorityDiscount());
                        if (chkFF.Checked) ds.add(new FreedomFighterDiscount());
                        rcc.getRegistration().setDiscountStrategy(disc_strat);
                        disc_strat = ds;
                    }
                    else
                    {
                        disc_strat = new BestForStudent();
                        var ds = (BestForNSU)disc_strat;
                        if (chkAE.Checked) ds.add(new AcademicExcellenceDiscount());
                        if (chkAM.Checked) ds.add(new AboriginalMinorityDiscount());
                        if (chkFF.Checked) ds.add(new FreedomFighterDiscount());
                        rcc.getRegistration().setDiscountStrategy(disc_strat);
                        disc_strat = ds;
                    }
                }
                discountLabel.Text = disc_strat.getTotal(rcc.getRegistration()).ToString();
                gTotalLabel.Text = rcc.getRegistration().getGrandTotal().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Student who is a progeny of a Freedom Fighter cannot take more than 5 courses.", "Course limit exceeded!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                discountLabel.Text = "0";
                disc_strat = null;
            }
            SystemSounds.Beep.Play();
        }
    }
}
