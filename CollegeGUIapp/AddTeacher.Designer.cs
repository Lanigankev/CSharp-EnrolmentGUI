namespace CollegeGUIapp
{
    partial class AddTeacher
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
            this.grpTeacher = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.grpTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeacher
            // 
            this.grpTeacher.Controls.Add(this.btnReturn);
            this.grpTeacher.Controls.Add(this.lblSubject);
            this.grpTeacher.Controls.Add(this.cboSubject);
            this.grpTeacher.Controls.Add(this.lblSalary);
            this.grpTeacher.Controls.Add(this.lblEmail);
            this.grpTeacher.Controls.Add(this.lblPhone);
            this.grpTeacher.Controls.Add(this.lblLName);
            this.grpTeacher.Controls.Add(this.txtSalary);
            this.grpTeacher.Controls.Add(this.txtEmail);
            this.grpTeacher.Controls.Add(this.txtPhone);
            this.grpTeacher.Controls.Add(this.txtLName);
            this.grpTeacher.Controls.Add(this.lblFName);
            this.grpTeacher.Controls.Add(this.txtFName);
            this.grpTeacher.Controls.Add(this.btnAddTeacher);
            this.grpTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeacher.Location = new System.Drawing.Point(12, 12);
            this.grpTeacher.Name = "grpTeacher";
            this.grpTeacher.Size = new System.Drawing.Size(293, 284);
            this.grpTeacher.TabIndex = 16;
            this.grpTeacher.TabStop = false;
            this.grpTeacher.Text = "Teacher";
            this.grpTeacher.Enter += new System.EventHandler(this.grpTeacher_Enter);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(145, 229);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 38);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Close";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(39, 190);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 15);
            this.lblSubject.TabIndex = 30;
            this.lblSubject.Text = "Subject";
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Items.AddRange(new object[] {
            "MATHS",
            "SCIENCE",
            "ENGLISH"});
            this.cboSubject.Location = new System.Drawing.Point(102, 187);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(130, 23);
            this.cboSubject.TabIndex = 29;
            this.cboSubject.Text = ": Please Select Subject";
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(39, 152);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 15);
            this.lblSalary.TabIndex = 27;
            this.lblSalary.Text = "Salary";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(39, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 15);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(39, 74);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(67, 15);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(102, 149);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(130, 21);
            this.txtSalary.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 21);
            this.txtEmail.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 97);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 21);
            this.txtPhone.TabIndex = 19;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(102, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(130, 21);
            this.txtLName.TabIndex = 18;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(39, 48);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 17;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(102, 45);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(130, 21);
            this.txtFName.TabIndex = 16;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(37, 229);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(102, 38);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 306);
            this.Controls.Add(this.grpTeacher);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherOptions";
            this.grpTeacher.ResumeLayout(false);
            this.grpTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Button btnReturn;
    }
}