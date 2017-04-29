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
            this.chkAE = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.chkAM = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.calcDiscButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.fetchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(18, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 498);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course ID";
            // 
            // AddCourseBttn
            // 
            this.AddCourseBttn.Location = new System.Drawing.Point(14, 140);
            this.AddCourseBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCourseBttn.Name = "AddCourseBttn";
            this.AddCourseBttn.Size = new System.Drawing.Size(154, 49);
            this.AddCourseBttn.TabIndex = 6;
            this.AddCourseBttn.Text = "Add Courses";
            this.AddCourseBttn.UseVisualStyleBackColor = true;
            this.AddCourseBttn.Click += new System.EventHandler(this.AddCourseBttn_Click);
            // 
            // NewRegBttn
            // 
            this.NewRegBttn.Location = new System.Drawing.Point(18, 18);
            this.NewRegBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewRegBttn.Name = "NewRegBttn";
            this.NewRegBttn.Size = new System.Drawing.Size(154, 49);
            this.NewRegBttn.TabIndex = 5;
            this.NewRegBttn.Text = "New Registration";
            this.NewRegBttn.UseVisualStyleBackColor = true;
            this.NewRegBttn.Click += new System.EventHandler(this.NewRegBttn_Click);
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.Location = new System.Drawing.Point(18, 211);
            this.sl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(48, 20);
            this.sl.TabIndex = 9;
            this.sl.Text = "SL #";
            // 
            // coursetitle
            // 
            this.coursetitle.AutoSize = true;
            this.coursetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetitle.Location = new System.Drawing.Point(104, 211);
            this.coursetitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coursetitle.Name = "coursetitle";
            this.coursetitle.Size = new System.Drawing.Size(112, 20);
            this.coursetitle.TabIndex = 10;
            this.coursetitle.Text = "Course Title";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(465, 211);
            this.credit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(60, 20);
            this.credit.TabIndex = 11;
            this.credit.Text = "Credit";
            // 
            // tpc
            // 
            this.tpc.AutoSize = true;
            this.tpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpc.Location = new System.Drawing.Point(784, 211);
            this.tpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tpc.Name = "tpc";
            this.tpc.Size = new System.Drawing.Size(135, 20);
            this.tpc.TabIndex = 12;
            this.tpc.Text = "Tuition / Credit";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(1144, 211);
            this.subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(89, 20);
            this.subtotal.TabIndex = 13;
            this.subtotal.Text = "Sub Total";
            // 
            // Txt
            // 
            this.Txt.FormattingEnabled = true;
            this.Txt.Location = new System.Drawing.Point(108, 91);
            this.Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(180, 28);
            this.Txt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 774);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Development Fee / BD Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(1144, 774);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalLabel.Size = new System.Drawing.Size(19, 20);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 862);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grand Total";
            // 
            // gTotalLabel
            // 
            this.gTotalLabel.AutoSize = true;
            this.gTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotalLabel.Location = new System.Drawing.Point(1144, 862);
            this.gTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gTotalLabel.Name = "gTotalLabel";
            this.gTotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gTotalLabel.Size = new System.Drawing.Size(19, 20);
            this.gTotalLabel.TabIndex = 18;
            this.gTotalLabel.Text = "0";
            // 
            // chkAE
            // 
            this.chkAE.AutoSize = true;
            this.chkAE.Location = new System.Drawing.Point(18, 743);
            this.chkAE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAE.Name = "chkAE";
            this.chkAE.Size = new System.Drawing.Size(183, 24);
            this.chkAE.TabIndex = 19;
            this.chkAE.Text = "Academic excellence";
            this.chkAE.UseVisualStyleBackColor = true;
            // 
            // chkFF
            // 
            this.chkFF.AutoSize = true;
            this.chkFF.Location = new System.Drawing.Point(18, 778);
            this.chkFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFF.Name = "chkFF";
            this.chkFF.Size = new System.Drawing.Size(153, 24);
            this.chkFF.TabIndex = 20;
            this.chkFF.Text = "Freedom Fighter";
            this.chkFF.UseVisualStyleBackColor = true;
            // 
            // chkAM
            // 
            this.chkAM.AutoSize = true;
            this.chkAM.Location = new System.Drawing.Point(18, 815);
            this.chkAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAM.Name = "chkAM";
            this.chkAM.Size = new System.Drawing.Size(220, 24);
            this.chkAM.TabIndex = 21;
            this.chkAM.Text = "Aboriginal / Minority Group";
            this.chkAM.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Best for NSU",
            "Best for Student"});
            this.comboBox1.Location = new System.Drawing.Point(18, 851);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // calcDiscButton
            // 
            this.calcDiscButton.Location = new System.Drawing.Point(18, 929);
            this.calcDiscButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcDiscButton.Name = "calcDiscButton";
            this.calcDiscButton.Size = new System.Drawing.Size(182, 49);
            this.calcDiscButton.TabIndex = 23;
            this.calcDiscButton.Text = "Calculate Discount";
            this.calcDiscButton.UseVisualStyleBackColor = true;
            this.calcDiscButton.Click += new System.EventHandler(this.calcDiscButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(784, 815);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Discount";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(1144, 817);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountLabel.Size = new System.Drawing.Size(19, 20);
            this.discountLabel.TabIndex = 25;
            this.discountLabel.Text = "0";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(788, 41);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(472, 26);
            this.studentID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Student ID:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(213, 929);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(238, 49);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save Registration";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(788, 81);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(218, 49);
            this.fetchButton.TabIndex = 29;
            this.fetchButton.Text = "Show Previous Registration";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 49);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add New Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 997);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcDiscButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkAM);
            this.Controls.Add(this.chkFF);
            this.Controls.Add(this.chkAE);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.CheckBox chkAE;
        private System.Windows.Forms.CheckBox chkFF;
        private System.Windows.Forms.CheckBox chkAM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button calcDiscButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.Button button1;
    }
}