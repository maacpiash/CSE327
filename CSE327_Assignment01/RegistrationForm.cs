﻿using System;
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
        public static RegisterCourseController rcc;

        public RegistrationForm()
        {
            InitializeComponent();
            rcc = new RegisterCourseController();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
