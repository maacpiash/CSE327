namespace CSE327_Assignment01
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCourseBttn = new System.Windows.Forms.Button();
            this.NewRegBttn = new System.Windows.Forms.Button();
            this.sl = new System.Windows.Forms.Label();
            this.coursetitle = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.tpc = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.Txt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 324);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course ID";
            // 
            // AddCourseBttn
            // 
            this.AddCourseBttn.Location = new System.Drawing.Point(9, 91);
            this.AddCourseBttn.Name = "AddCourseBttn";
            this.AddCourseBttn.Size = new System.Drawing.Size(103, 32);
            this.AddCourseBttn.TabIndex = 6;
            this.AddCourseBttn.Text = "Add Courses";
            this.AddCourseBttn.UseVisualStyleBackColor = true;
            this.AddCourseBttn.Click += new System.EventHandler(this.AddCourseBttn_Click);
            // 
            // NewRegBttn
            // 
            this.NewRegBttn.Location = new System.Drawing.Point(12, 12);
            this.NewRegBttn.Name = "NewRegBttn";
            this.NewRegBttn.Size = new System.Drawing.Size(103, 32);
            this.NewRegBttn.TabIndex = 5;
            this.NewRegBttn.Text = "New Registration";
            this.NewRegBttn.UseVisualStyleBackColor = true;
            this.NewRegBttn.Click += new System.EventHandler(this.NewRegBttn_Click);
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.Location = new System.Drawing.Point(12, 160);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(34, 13);
            this.sl.TabIndex = 9;
            this.sl.Text = "SL #";
            // 
            // coursetitle
            // 
            this.coursetitle.AutoSize = true;
            this.coursetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetitle.Location = new System.Drawing.Point(69, 160);
            this.coursetitle.Name = "coursetitle";
            this.coursetitle.Size = new System.Drawing.Size(75, 13);
            this.coursetitle.TabIndex = 10;
            this.coursetitle.Text = "Course Title";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(310, 160);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(40, 13);
            this.credit.TabIndex = 11;
            this.credit.Text = "Credit";
            // 
            // tpc
            // 
            this.tpc.AutoSize = true;
            this.tpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpc.Location = new System.Drawing.Point(523, 160);
            this.tpc.Name = "tpc";
            this.tpc.Size = new System.Drawing.Size(93, 13);
            this.tpc.TabIndex = 12;
            this.tpc.Text = "Tuition / Credit";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(763, 160);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(62, 13);
            this.subtotal.TabIndex = 13;
            this.subtotal.Text = "Sub Total";
            // 
            // Txt
            // 
            this.Txt.FormattingEnabled = true;
            this.Txt.Items.AddRange(new object[] {
            "CSE 115",
            "CSE 173",
            "CSE 215",
            "CSE 225",
            "CSE 231",
            "CSE 273",
            "CSE 311",
            "CSE 323",
            "CSE 332",
            "CSE 338",
            "CSE 418",
            "CSE 482",
            "EEE 111",
            "EEE 141",
            "EEE 311",
            "MAT 120",
            "MAT 130",
            "MAT 240",
            "MAT 250",
            "MAT 350",
            "MAT 361",
            "PHY 107",
            "PHY 108"});
            this.Txt.Location = new System.Drawing.Point(72, 59);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(121, 21);
            this.Txt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Development Fee / BD Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(763, 503);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(14, 13);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grand Total";
            // 
            // gTotalLabel
            // 
            this.gTotalLabel.AutoSize = true;
            this.gTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotalLabel.Location = new System.Drawing.Point(766, 532);
            this.gTotalLabel.Name = "gTotalLabel";
            this.gTotalLabel.Size = new System.Drawing.Size(14, 13);
            this.gTotalLabel.TabIndex = 18;
            this.gTotalLabel.Text = "0";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 557);
            this.Controls.Add(this.gTotalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.tpc);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.coursetitle);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCourseBttn);
            this.Controls.Add(this.NewRegBttn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Register Courses";
            this.Load += new System.EventHandler(this.CourseRegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCourseBttn;
        private System.Windows.Forms.Button NewRegBttn;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.Label coursetitle;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label tpc;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.ComboBox Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gTotalLabel;
    }
}