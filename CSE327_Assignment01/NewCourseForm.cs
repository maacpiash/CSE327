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
    public partial class NewCourseForm : Form
    {
        List<Label> labels;
        List<Course> courses;
        public NewCourseForm()
        {
            InitializeComponent();
            labels = new List<Label>();
        }

        private void NewCourseForm_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            labels.ForEach(x => panel1.Controls.Remove(x));
            Label p;
            CourseFactory cf = new CourseFactory();
            courses = CourseFactory.getInstance().getCList();
            for(int i = 0; i < courses.Count; i++)
            {
                p = new Label() { Text = courses[i].getId(), Location = new Point(label10.Location.X, i * 30), Size = new Size(80, 20) };
                panel1.Controls.Add(p);
                labels.Add(p);

                p = new Label() { Text = courses[i].getTitle(), Location = new Point(label9.Location.X, i * 30), Size = new Size(300, 20) };
                panel1.Controls.Add(p);
                labels.Add(p);

                p = new Label() { Text = courses[i].getCredit().ToString(), Location = new Point(label8.Location.X, i * 30) };
                panel1.Controls.Add(p);
                labels.Add(p);

                p = new Label() { Text = courses[i].getTuitionPerCredit().ToString(), Location = new Point(label7.Location.X, i * 30) };
                panel1.Controls.Add(p);
                labels.Add(p);

                p = new Label() { Text = courses[i].getProgram(), Location = new Point(label6.Location.X, i * 30) };
                panel1.Controls.Add(p);
                labels.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.setId(idText.Text);
            c.setTitle(titleText.Text);
            int temp;
            int.TryParse(creditText.Text, out temp);
            c.setCredit(temp);
            int.TryParse(tpcText.Text, out temp);
            c.setTuitionPerCredit(temp);
            c.setProgram(comboBox1.Text);

            DepttProgram dp = new DepttProgram(idText.Text, titleText.Text, comboBox1.Text);

            PersistenceFacade.getInstance().put(c);
            PersistenceFacade.getInstance().put(dp);

            update();
        }
    }
}
