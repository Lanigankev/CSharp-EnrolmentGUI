namespace CollegeGUIapp
{
    partial class TeacherMenu
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
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearchLName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDisplayTeacher = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstDisplayBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentOptions = new System.Windows.Forms.Button();
            this.grpTeacherOptions = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpTeacherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfo.Location = new System.Drawing.Point(139, 235);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(104, 34);
            this.btnMoreInfo.TabIndex = 51;
            this.btnMoreInfo.Text = "Edit Teacher";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(139, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 34);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchLName
            // 
            this.txtSearchLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLName.Location = new System.Drawing.Point(139, 199);
            this.txtSearchLName.Name = "txtSearchLName";
            this.txtSearchLName.Size = new System.Drawing.Size(104, 24);
            this.txtSearchLName.TabIndex = 48;
            this.txtSearchLName.TextChanged += new System.EventHandler(this.txtSearchLName_TextChanged);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(10, 235);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(104, 34);
            this.btnAddTeacher.TabIndex = 47;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnDisplayTeacher
            // 
            this.btnDisplayTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTeacher.Location = new System.Drawing.Point(10, 275);
            this.btnDisplayTeacher.Name = "btnDisplayTeacher";
            this.btnDisplayTeacher.Size = new System.Drawing.Size(104, 34);
            this.btnDisplayTeacher.TabIndex = 44;
            this.btnDisplayTeacher.Text = "Refresh Teacher List";
            this.btnDisplayTeacher.UseVisualStyleBackColor = true;
            this.btnDisplayTeacher.Click += new System.EventHandler(this.btnDisplayTeacher_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(10, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 34);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search Last Name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstDisplayBox
            // 
            this.lstDisplayBox.FormattingEnabled = true;
            this.lstDisplayBox.ItemHeight = 16;
            this.lstDisplayBox.Location = new System.Drawing.Point(10, 22);
            this.lstDisplayBox.Name = "lstDisplayBox";
            this.lstDisplayBox.Size = new System.Drawing.Size(233, 132);
            this.lstDisplayBox.TabIndex = 45;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 49;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStudentOptions
            // 
            this.btnStudentOptions.Location = new System.Drawing.Point(40, 406);
            this.btnStudentOptions.Name = "btnStudentOptions";
            this.btnStudentOptions.Size = new System.Drawing.Size(104, 34);
            this.btnStudentOptions.TabIndex = 52;
            this.btnStudentOptions.Text = "Student Options";
            this.btnStudentOptions.UseVisualStyleBackColor = true;
            this.btnStudentOptions.Click += new System.EventHandler(this.btnStudentOptions_Click);
            // 
            // grpTeacherOptions
            // 
            this.grpTeacherOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpTeacherOptions.Controls.Add(this.btnMoreInfo);
            this.grpTeacherOptions.Controls.Add(this.btnDelete);
            this.grpTeacherOptions.Controls.Add(this.txtSearchLName);
            this.grpTeacherOptions.Controls.Add(this.btnAddTeacher);
            this.grpTeacherOptions.Controls.Add(this.btnDisplayTeacher);
            this.grpTeacherOptions.Controls.Add(this.btnSearch);
            this.grpTeacherOptions.Controls.Add(this.lstDisplayBox);
            this.grpTeacherOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeacherOptions.Location = new System.Drawing.Point(30, 41);
            this.grpTeacherOptions.Name = "grpTeacherOptions";
            this.grpTeacherOptions.Size = new System.Drawing.Size(257, 325);
            this.grpTeacherOptions.TabIndex = 53;
            this.grpTeacherOptions.TabStop = false;
            this.grpTeacherOptions.Text = "Teacher Options";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(169, 406);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 34);
            this.btnLogout.TabIndex = 56;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 452);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpTeacherOptions);
            this.Controls.Add(this.btnStudentOptions);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TeacherMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMenu";
            this.Load += new System.EventHandler(this.TeacherMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTeacherOptions.ResumeLayout(false);
            this.grpTeacherOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchLName;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDisplayTeacher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstDisplayBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStudentOptions;
        private System.Windows.Forms.GroupBox grpTeacherOptions;
        private System.Windows.Forms.Button btnLogout;
    }
}