namespace CollegeGUIapp
{
    partial class Form1
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rdoUndergraduate = new System.Windows.Forms.RadioButton();
            this.rdoPostgraduate = new System.Windows.Forms.RadioButton();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.grpTeacher = new System.Windows.Forms.GroupBox();
            this.lstDisplayBox = new System.Windows.Forms.ListBox();
            this.btnDisplayStud = new System.Windows.Forms.Button();
            this.grpStudent.SuspendLayout();
            this.grpTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(22, 223);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(96, 38);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(83, 245);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(102, 38);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(82, 15);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(130, 20);
            this.txtFName.TabIndex = 2;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(19, 18);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(82, 41);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(130, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // rdoUndergraduate
            // 
            this.rdoUndergraduate.AutoSize = true;
            this.rdoUndergraduate.Location = new System.Drawing.Point(116, 146);
            this.rdoUndergraduate.Name = "rdoUndergraduate";
            this.rdoUndergraduate.Size = new System.Drawing.Size(96, 17);
            this.rdoUndergraduate.TabIndex = 8;
            this.rdoUndergraduate.TabStop = true;
            this.rdoUndergraduate.Text = "Undergraduate";
            this.rdoUndergraduate.UseVisualStyleBackColor = true;
            // 
            // rdoPostgraduate
            // 
            this.rdoPostgraduate.AutoSize = true;
            this.rdoPostgraduate.Location = new System.Drawing.Point(116, 169);
            this.rdoPostgraduate.Name = "rdoPostgraduate";
            this.rdoPostgraduate.Size = new System.Drawing.Size(88, 17);
            this.rdoPostgraduate.TabIndex = 9;
            this.rdoPostgraduate.TabStop = true;
            this.rdoPostgraduate.Text = "Postgraduate";
            this.rdoPostgraduate.UseVisualStyleBackColor = true;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(19, 44);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 10;
            this.lblLName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(19, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 122);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Student ID";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.btnDisplayStud);
            this.grpStudent.Controls.Add(this.lblId);
            this.grpStudent.Controls.Add(this.lblEmail);
            this.grpStudent.Controls.Add(this.btnAddStudent);
            this.grpStudent.Controls.Add(this.lblPhone);
            this.grpStudent.Controls.Add(this.lblLName);
            this.grpStudent.Controls.Add(this.rdoPostgraduate);
            this.grpStudent.Controls.Add(this.rdoUndergraduate);
            this.grpStudent.Controls.Add(this.txtId);
            this.grpStudent.Controls.Add(this.txtEmail);
            this.grpStudent.Controls.Add(this.txtPhone);
            this.grpStudent.Controls.Add(this.txtLName);
            this.grpStudent.Controls.Add(this.lblFName);
            this.grpStudent.Controls.Add(this.txtFName);
            this.grpStudent.Location = new System.Drawing.Point(12, 12);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(341, 349);
            this.grpStudent.TabIndex = 14;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student";
            // 
            // grpTeacher
            // 
            this.grpTeacher.Controls.Add(this.btnAddTeacher);
            this.grpTeacher.Location = new System.Drawing.Point(372, 12);
            this.grpTeacher.Name = "grpTeacher";
            this.grpTeacher.Size = new System.Drawing.Size(338, 342);
            this.grpTeacher.TabIndex = 15;
            this.grpTeacher.TabStop = false;
            this.grpTeacher.Text = "Teacher";
            // 
            // lstDisplayBox
            // 
            this.lstDisplayBox.FormattingEnabled = true;
            this.lstDisplayBox.Location = new System.Drawing.Point(23, 385);
            this.lstDisplayBox.Name = "lstDisplayBox";
            this.lstDisplayBox.Size = new System.Drawing.Size(672, 173);
            this.lstDisplayBox.TabIndex = 16;
            this.lstDisplayBox.SelectedIndexChanged += new System.EventHandler(this.lstDisplayBox_SelectedIndexChanged);
            // 
            // btnDisplayStud
            // 
            this.btnDisplayStud.Location = new System.Drawing.Point(175, 223);
            this.btnDisplayStud.Name = "btnDisplayStud";
            this.btnDisplayStud.Size = new System.Drawing.Size(104, 38);
            this.btnDisplayStud.TabIndex = 14;
            this.btnDisplayStud.Text = "Display Student List";
            this.btnDisplayStud.UseVisualStyleBackColor = true;
            this.btnDisplayStud.Click += new System.EventHandler(this.btnDisplayStud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 604);
            this.Controls.Add(this.lstDisplayBox);
            this.Controls.Add(this.grpTeacher);
            this.Controls.Add(this.grpStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rdoUndergraduate;
        private System.Windows.Forms.RadioButton rdoPostgraduate;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.GroupBox grpTeacher;
        private System.Windows.Forms.ListBox lstDisplayBox;
        private System.Windows.Forms.Button btnDisplayStud;
    }
}

