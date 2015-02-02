namespace CollegeGUIapp
{
    partial class AddStudent
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdoUndergraduate = new System.Windows.Forms.RadioButton();
            this.rdoPostgraduate = new System.Windows.Forms.RadioButton();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.grpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(37, 229);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(102, 38);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(106, 45);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(130, 21);
            this.txtFName.TabIndex = 2;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(39, 48);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(106, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(130, 21);
            this.txtLName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 97);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // rdoUndergraduate
            // 
            this.rdoUndergraduate.AutoSize = true;
            this.rdoUndergraduate.Location = new System.Drawing.Point(132, 152);
            this.rdoUndergraduate.Name = "rdoUndergraduate";
            this.rdoUndergraduate.Size = new System.Drawing.Size(108, 19);
            this.rdoUndergraduate.TabIndex = 8;
            this.rdoUndergraduate.TabStop = true;
            this.rdoUndergraduate.Text = "Undergraduate";
            this.rdoUndergraduate.UseVisualStyleBackColor = true;
            // 
            // rdoPostgraduate
            // 
            this.rdoPostgraduate.AutoSize = true;
            this.rdoPostgraduate.Location = new System.Drawing.Point(132, 175);
            this.rdoPostgraduate.Name = "rdoPostgraduate";
            this.rdoPostgraduate.Size = new System.Drawing.Size(98, 19);
            this.rdoPostgraduate.TabIndex = 9;
            this.rdoPostgraduate.TabStop = true;
            this.rdoPostgraduate.Text = "Postgraduate";
            this.rdoPostgraduate.UseVisualStyleBackColor = true;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(39, 74);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(67, 15);
            this.lblLName.TabIndex = 10;
            this.lblLName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(39, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 15);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.lblStatus);
            this.grpStudent.Controls.Add(this.btnReturnToMenu);
            this.grpStudent.Controls.Add(this.lblEmail);
            this.grpStudent.Controls.Add(this.btnAddStudent);
            this.grpStudent.Controls.Add(this.lblPhone);
            this.grpStudent.Controls.Add(this.lblLName);
            this.grpStudent.Controls.Add(this.rdoPostgraduate);
            this.grpStudent.Controls.Add(this.rdoUndergraduate);
            this.grpStudent.Controls.Add(this.txtEmail);
            this.grpStudent.Controls.Add(this.txtPhone);
            this.grpStudent.Controls.Add(this.txtLName);
            this.grpStudent.Controls.Add(this.lblFName);
            this.grpStudent.Controls.Add(this.txtFName);
            this.grpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudent.Location = new System.Drawing.Point(12, 12);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(293, 284);
            this.grpStudent.TabIndex = 14;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(39, 156);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(145, 229);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(102, 38);
            this.btnReturnToMenu.TabIndex = 14;
            this.btnReturnToMenu.Text = "Close";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 306);
            this.Controls.Add(this.grpStudent);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdoUndergraduate;
        private System.Windows.Forms.RadioButton rdoPostgraduate;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label lblStatus;
    }
}

