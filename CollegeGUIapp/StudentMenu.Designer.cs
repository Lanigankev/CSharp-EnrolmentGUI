namespace CollegeGUIapp
{
    partial class StudentMenu
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
            this.btnDisplayStud = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstDisplayBox = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.btnTeacherOptions = new System.Windows.Forms.Button();
            this.grpStudentOptions = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpStudentOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayStud
            // 
            this.btnDisplayStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStud.Location = new System.Drawing.Point(10, 275);
            this.btnDisplayStud.Name = "btnDisplayStud";
            this.btnDisplayStud.Size = new System.Drawing.Size(104, 34);
            this.btnDisplayStud.TabIndex = 33;
            this.btnDisplayStud.Text = "Refresh Student List";
            this.btnDisplayStud.UseVisualStyleBackColor = true;
            this.btnDisplayStud.Click += new System.EventHandler(this.btnDisplayStud_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(10, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 34);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search ID";
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
            this.lstDisplayBox.TabIndex = 34;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(10, 235);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(104, 34);
            this.btnAddStudent.TabIndex = 36;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(139, 199);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(104, 24);
            this.txtSearchId.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(139, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 34);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfo.Location = new System.Drawing.Point(139, 235);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(104, 34);
            this.btnMoreInfo.TabIndex = 43;
            this.btnMoreInfo.Text = "Edit Student";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnTeacherOptions
            // 
            this.btnTeacherOptions.Location = new System.Drawing.Point(40, 408);
            this.btnTeacherOptions.Name = "btnTeacherOptions";
            this.btnTeacherOptions.Size = new System.Drawing.Size(104, 34);
            this.btnTeacherOptions.TabIndex = 53;
            this.btnTeacherOptions.Text = "Teacher Options";
            this.btnTeacherOptions.UseVisualStyleBackColor = true;
            this.btnTeacherOptions.Click += new System.EventHandler(this.btnTeacherOptions_Click);
            // 
            // grpStudentOptions
            // 
            this.grpStudentOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpStudentOptions.Controls.Add(this.btnDisplayStud);
            this.grpStudentOptions.Controls.Add(this.btnMoreInfo);
            this.grpStudentOptions.Controls.Add(this.btnDelete);
            this.grpStudentOptions.Controls.Add(this.btnAddStudent);
            this.grpStudentOptions.Controls.Add(this.txtSearchId);
            this.grpStudentOptions.Controls.Add(this.lstDisplayBox);
            this.grpStudentOptions.Controls.Add(this.btnSearch);
            this.grpStudentOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentOptions.Location = new System.Drawing.Point(30, 41);
            this.grpStudentOptions.Name = "grpStudentOptions";
            this.grpStudentOptions.Size = new System.Drawing.Size(257, 325);
            this.grpStudentOptions.TabIndex = 54;
            this.grpStudentOptions.TabStop = false;
            this.grpStudentOptions.Text = "Student Options";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(169, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 34);
            this.btnLogout.TabIndex = 55;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 452);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpStudentOptions);
            this.Controls.Add(this.btnTeacherOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpStudentOptions.ResumeLayout(false);
            this.grpStudentOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayStud;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstDisplayBox;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button btnTeacherOptions;
        private System.Windows.Forms.GroupBox grpStudentOptions;
        private System.Windows.Forms.Button btnLogout;
    }
}