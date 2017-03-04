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
            this.tableView = new System.Windows.Forms.TableLayoutPanel();
            this.NewRegBttn = new System.Windows.Forms.Button();
            this.AddCourseBttn = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.AutoScroll = true;
            this.tableView.ColumnCount = 5;
            this.tableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableView.Location = new System.Drawing.Point(9, 145);
            this.tableView.Name = "tableView";
            this.tableView.RowCount = 1;
            this.tableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableView.Size = new System.Drawing.Size(967, 458);
            this.tableView.TabIndex = 0;
            // 
            // NewRegBttn
            // 
            this.NewRegBttn.Location = new System.Drawing.Point(12, 12);
            this.NewRegBttn.Name = "NewRegBttn";
            this.NewRegBttn.Size = new System.Drawing.Size(103, 32);
            this.NewRegBttn.TabIndex = 1;
            this.NewRegBttn.Text = "New Registration";
            this.NewRegBttn.UseVisualStyleBackColor = true;
            this.NewRegBttn.Click += new System.EventHandler(this.NewRegBttn_Click);
            // 
            // AddCourseBttn
            // 
            this.AddCourseBttn.Location = new System.Drawing.Point(9, 91);
            this.AddCourseBttn.Name = "AddCourseBttn";
            this.AddCourseBttn.Size = new System.Drawing.Size(103, 32);
            this.AddCourseBttn.TabIndex = 2;
            this.AddCourseBttn.Text = "Add Courses";
            this.AddCourseBttn.UseVisualStyleBackColor = true;
            this.AddCourseBttn.Click += new System.EventHandler(this.AddCourseBttn_Click);
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(72, 59);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(194, 20);
            this.Txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course ID";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.AddCourseBttn);
            this.Controls.Add(this.NewRegBttn);
            this.Controls.Add(this.tableView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "Register Courses";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.SizeChanged += new System.EventHandler(this.RegistrationForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableView;
        private System.Windows.Forms.Button NewRegBttn;
        private System.Windows.Forms.Button AddCourseBttn;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Label label1;
    }
}

