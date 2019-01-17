namespace coursemo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentLst = new System.Windows.Forms.ListBox();
            this.allStudents = new System.Windows.Forms.Button();
            this.allCourses = new System.Windows.Forms.Button();
            this.GrpBoxEnroll = new System.Windows.Forms.GroupBox();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.labelCRN = new System.Windows.Forms.Label();
            this.textBoxCRN = new System.Windows.Forms.TextBox();
            this.labelNetid = new System.Windows.Forms.Label();
            this.textBoxNetID = new System.Windows.Forms.TextBox();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.textBox_history_netid = new System.Windows.Forms.TextBox();
            this.courseLst = new System.Windows.Forms.ListBox();
            this.buttonCourseInfo = new System.Windows.Forms.Button();
            this.courseInfoLst = new System.Windows.Forms.ListBox();
            this.SwapBox = new System.Windows.Forms.GroupBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.student2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSC2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSN2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSC1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSN1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentInfoBox = new System.Windows.Forms.ListBox();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GrpBoxEnroll.SuspendLayout();
            this.SwapBox.SuspendLayout();
            this.student2.SuspendLayout();
            this.student1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2078, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.testConnectionToolStripMenuItem.Text = "Test Connection";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.aboutAuthorToolStripMenuItem.Text = "About Author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentLst
            // 
            this.studentLst.FormattingEnabled = true;
            this.studentLst.ItemHeight = 20;
            this.studentLst.Location = new System.Drawing.Point(33, 135);
            this.studentLst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.studentLst.Name = "studentLst";
            this.studentLst.Size = new System.Drawing.Size(309, 384);
            this.studentLst.TabIndex = 1;
            // 
            // allStudents
            // 
            this.allStudents.Location = new System.Drawing.Point(33, 68);
            this.allStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.allStudents.Name = "allStudents";
            this.allStudents.Size = new System.Drawing.Size(309, 40);
            this.allStudents.TabIndex = 2;
            this.allStudents.Text = "View All Students";
            this.allStudents.UseVisualStyleBackColor = true;
            this.allStudents.Click += new System.EventHandler(this.allStudents_Click);
            // 
            // allCourses
            // 
            this.allCourses.Location = new System.Drawing.Point(365, 68);
            this.allCourses.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.allCourses.Name = "allCourses";
            this.allCourses.Size = new System.Drawing.Size(326, 40);
            this.allCourses.TabIndex = 4;
            this.allCourses.Text = "View All Courses";
            this.allCourses.UseVisualStyleBackColor = true;
            this.allCourses.Click += new System.EventHandler(this.allCourses_Click);
            // 
            // GrpBoxEnroll
            // 
            this.GrpBoxEnroll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GrpBoxEnroll.Controls.Add(this.buttonDrop);
            this.GrpBoxEnroll.Controls.Add(this.labelCRN);
            this.GrpBoxEnroll.Controls.Add(this.textBoxCRN);
            this.GrpBoxEnroll.Controls.Add(this.labelNetid);
            this.GrpBoxEnroll.Controls.Add(this.textBoxNetID);
            this.GrpBoxEnroll.Controls.Add(this.buttonEnroll);
            this.GrpBoxEnroll.Location = new System.Drawing.Point(782, 164);
            this.GrpBoxEnroll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GrpBoxEnroll.Name = "GrpBoxEnroll";
            this.GrpBoxEnroll.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GrpBoxEnroll.Size = new System.Drawing.Size(726, 253);
            this.GrpBoxEnroll.TabIndex = 7;
            this.GrpBoxEnroll.TabStop = false;
            this.GrpBoxEnroll.Text = "Enroll/Drop";
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(474, 149);
            this.buttonDrop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(118, 32);
            this.buttonDrop.TabIndex = 8;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // labelCRN
            // 
            this.labelCRN.AutoSize = true;
            this.labelCRN.Location = new System.Drawing.Point(72, 155);
            this.labelCRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCRN.Name = "labelCRN";
            this.labelCRN.Size = new System.Drawing.Size(102, 20);
            this.labelCRN.TabIndex = 4;
            this.labelCRN.Text = "Course CRN:";
            // 
            // textBoxCRN
            // 
            this.textBoxCRN.Location = new System.Drawing.Point(200, 149);
            this.textBoxCRN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxCRN.Name = "textBoxCRN";
            this.textBoxCRN.Size = new System.Drawing.Size(198, 26);
            this.textBoxCRN.TabIndex = 3;
            // 
            // labelNetid
            // 
            this.labelNetid.AutoSize = true;
            this.labelNetid.Location = new System.Drawing.Point(91, 82);
            this.labelNetid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetid.Name = "labelNetid";
            this.labelNetid.Size = new System.Drawing.Size(59, 20);
            this.labelNetid.TabIndex = 2;
            this.labelNetid.Text = "NetID: ";
            // 
            // textBoxNetID
            // 
            this.textBoxNetID.Location = new System.Drawing.Point(200, 76);
            this.textBoxNetID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxNetID.Name = "textBoxNetID";
            this.textBoxNetID.Size = new System.Drawing.Size(193, 26);
            this.textBoxNetID.TabIndex = 1;
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.Location = new System.Drawing.Point(474, 67);
            this.buttonEnroll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(112, 35);
            this.buttonEnroll.TabIndex = 0;
            this.buttonEnroll.Text = "Enroll";
            this.buttonEnroll.UseVisualStyleBackColor = true;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(28, 552);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(102, 20);
            this.labelHistory.TabIndex = 8;
            this.labelHistory.Text = "Enter NetID: ";
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(18, 602);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(309, 48);
            this.buttonHistory.TabIndex = 9;
            this.buttonHistory.Text = "Display Enrolled/Waitlisted Courses";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // textBox_history_netid
            // 
            this.textBox_history_netid.Location = new System.Drawing.Point(158, 552);
            this.textBox_history_netid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_history_netid.Name = "textBox_history_netid";
            this.textBox_history_netid.Size = new System.Drawing.Size(169, 26);
            this.textBox_history_netid.TabIndex = 10;
            // 
            // courseLst
            // 
            this.courseLst.FormattingEnabled = true;
            this.courseLst.ItemHeight = 20;
            this.courseLst.Location = new System.Drawing.Point(365, 135);
            this.courseLst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.courseLst.Name = "courseLst";
            this.courseLst.Size = new System.Drawing.Size(325, 384);
            this.courseLst.TabIndex = 11;
            // 
            // buttonCourseInfo
            // 
            this.buttonCourseInfo.Location = new System.Drawing.Point(365, 578);
            this.buttonCourseInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCourseInfo.Name = "buttonCourseInfo";
            this.buttonCourseInfo.Size = new System.Drawing.Size(325, 49);
            this.buttonCourseInfo.TabIndex = 12;
            this.buttonCourseInfo.Text = "Display Course Information";
            this.buttonCourseInfo.UseVisualStyleBackColor = true;
            this.buttonCourseInfo.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // courseInfoLst
            // 
            this.courseInfoLst.FormattingEnabled = true;
            this.courseInfoLst.ItemHeight = 20;
            this.courseInfoLst.Location = new System.Drawing.Point(372, 671);
            this.courseInfoLst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.courseInfoLst.Name = "courseInfoLst";
            this.courseInfoLst.Size = new System.Drawing.Size(319, 284);
            this.courseInfoLst.TabIndex = 13;
            // 
            // SwapBox
            // 
            this.SwapBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SwapBox.Controls.Add(this.buttonSwap);
            this.SwapBox.Controls.Add(this.student2);
            this.SwapBox.Controls.Add(this.student1);
            this.SwapBox.Location = new System.Drawing.Point(782, 474);
            this.SwapBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SwapBox.Name = "SwapBox";
            this.SwapBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SwapBox.Size = new System.Drawing.Size(726, 404);
            this.SwapBox.TabIndex = 14;
            this.SwapBox.TabStop = false;
            this.SwapBox.Text = "Swap";
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(280, 288);
            this.buttonSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(181, 62);
            this.buttonSwap.TabIndex = 2;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // student2
            // 
            this.student2.BackColor = System.Drawing.SystemColors.Control;
            this.student2.Controls.Add(this.comboBoxSC2);
            this.student2.Controls.Add(this.comboBoxSN2);
            this.student2.Controls.Add(this.label4);
            this.student2.Controls.Add(this.label2);
            this.student2.Location = new System.Drawing.Point(400, 58);
            this.student2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student2.Name = "student2";
            this.student2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student2.Size = new System.Drawing.Size(287, 189);
            this.student2.TabIndex = 1;
            this.student2.TabStop = false;
            this.student2.Text = "Student 2";
            // 
            // comboBoxSC2
            // 
            this.comboBoxSC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSC2.FormattingEnabled = true;
            this.comboBoxSC2.Location = new System.Drawing.Point(128, 121);
            this.comboBoxSC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSC2.Name = "comboBoxSC2";
            this.comboBoxSC2.Size = new System.Drawing.Size(127, 28);
            this.comboBoxSC2.TabIndex = 6;
            // 
            // comboBoxSN2
            // 
            this.comboBoxSN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSN2.FormattingEnabled = true;
            this.comboBoxSN2.Location = new System.Drawing.Point(103, 56);
            this.comboBoxSN2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSN2.Name = "comboBoxSN2";
            this.comboBoxSN2.Size = new System.Drawing.Size(127, 28);
            this.comboBoxSN2.TabIndex = 5;
            this.comboBoxSN2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course CRN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NetID:";
            // 
            // student1
            // 
            this.student1.BackColor = System.Drawing.SystemColors.Control;
            this.student1.Controls.Add(this.comboBoxSC1);
            this.student1.Controls.Add(this.comboBoxSN1);
            this.student1.Controls.Add(this.label3);
            this.student1.Controls.Add(this.label1);
            this.student1.Location = new System.Drawing.Point(55, 58);
            this.student1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student1.Name = "student1";
            this.student1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student1.Size = new System.Drawing.Size(287, 189);
            this.student1.TabIndex = 0;
            this.student1.TabStop = false;
            this.student1.Text = "Student 1";
            // 
            // comboBoxSC1
            // 
            this.comboBoxSC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSC1.FormattingEnabled = true;
            this.comboBoxSC1.Location = new System.Drawing.Point(117, 126);
            this.comboBoxSC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSC1.Name = "comboBoxSC1";
            this.comboBoxSC1.Size = new System.Drawing.Size(127, 28);
            this.comboBoxSC1.TabIndex = 5;
            // 
            // comboBoxSN1
            // 
            this.comboBoxSN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSN1.FormattingEnabled = true;
            this.comboBoxSN1.Location = new System.Drawing.Point(117, 59);
            this.comboBoxSN1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSN1.Name = "comboBoxSN1";
            this.comboBoxSN1.Size = new System.Drawing.Size(127, 28);
            this.comboBoxSN1.TabIndex = 4;
            this.comboBoxSN1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course CRN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NetID:";
            // 
            // studentInfoBox
            // 
            this.studentInfoBox.FormattingEnabled = true;
            this.studentInfoBox.ItemHeight = 20;
            this.studentInfoBox.Location = new System.Drawing.Point(42, 671);
            this.studentInfoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentInfoBox.Name = "studentInfoBox";
            this.studentInfoBox.Size = new System.Drawing.Size(284, 284);
            this.studentInfoBox.TabIndex = 16;
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(954, 82);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(207, 26);
            this.delayBox.TabIndex = 17;
            this.delayBox.Text = "0";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(789, 85);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(134, 20);
            this.labelDelay.TabIndex = 18;
            this.labelDelay.Text = "Add a Delay (ms):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2078, 1410);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.studentInfoBox);
            this.Controls.Add(this.SwapBox);
            this.Controls.Add(this.courseInfoLst);
            this.Controls.Add(this.buttonCourseInfo);
            this.Controls.Add(this.courseLst);
            this.Controls.Add(this.textBox_history_netid);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.GrpBoxEnroll);
            this.Controls.Add(this.allCourses);
            this.Controls.Add(this.allStudents);
            this.Controls.Add(this.studentLst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Coursemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GrpBoxEnroll.ResumeLayout(false);
            this.GrpBoxEnroll.PerformLayout();
            this.SwapBox.ResumeLayout(false);
            this.student2.ResumeLayout(false);
            this.student2.PerformLayout();
            this.student1.ResumeLayout(false);
            this.student1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox studentLst;
        private System.Windows.Forms.Button allStudents;
        private System.Windows.Forms.Button allCourses;
        private System.Windows.Forms.GroupBox GrpBoxEnroll;
        private System.Windows.Forms.TextBox textBoxNetID;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Label labelCRN;
        private System.Windows.Forms.TextBox textBoxCRN;
        private System.Windows.Forms.Label labelNetid;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.TextBox textBox_history_netid;
        private System.Windows.Forms.ListBox courseLst;
        private System.Windows.Forms.Button buttonCourseInfo;
        private System.Windows.Forms.ListBox courseInfoLst;
        private System.Windows.Forms.GroupBox SwapBox;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.GroupBox student2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox student1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSN1;
        private System.Windows.Forms.ComboBox comboBoxSN2;
        private System.Windows.Forms.ComboBox comboBoxSC2;
        private System.Windows.Forms.ComboBox comboBoxSC1;
        private System.Windows.Forms.ListBox studentInfoBox;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.Label labelDelay;
    }
}

