namespace _20110376_TruongChiKien_StudentManagement.COURSE
{
    partial class ManageCourseForm
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            this.btn_EditCourse = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelTotalCourse = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxID.Location = new System.Drawing.Point(167, 44);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(316, 34);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxLabel.Location = new System.Drawing.Point(167, 120);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(316, 34);
            this.textBoxLabel.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxDescription.Location = new System.Drawing.Point(167, 375);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(316, 34);
            this.textBoxDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonFirst.Location = new System.Drawing.Point(40, 430);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(123, 55);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonPrevious.Location = new System.Drawing.Point(204, 430);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(123, 55);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonNext.Location = new System.Drawing.Point(360, 430);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(123, 55);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonLast.Location = new System.Drawing.Point(514, 430);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(123, 55);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AddCourse.Location = new System.Drawing.Point(64, 555);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(148, 36);
            this.btn_AddCourse.TabIndex = 11;
            this.btn_AddCourse.Text = "Add";
            this.btn_AddCourse.UseVisualStyleBackColor = false;
            this.btn_AddCourse.Click += new System.EventHandler(this.btn_AddCourse_Click_1);
            // 
            // btn_EditCourse
            // 
            this.btn_EditCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_EditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EditCourse.Location = new System.Drawing.Point(243, 555);
            this.btn_EditCourse.Name = "btn_EditCourse";
            this.btn_EditCourse.Size = new System.Drawing.Size(148, 36);
            this.btn_EditCourse.TabIndex = 12;
            this.btn_EditCourse.Text = "Edit";
            this.btn_EditCourse.UseVisualStyleBackColor = false;
            this.btn_EditCourse.Click += new System.EventHandler(this.btn_EditCourse_Click_1);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.Location = new System.Drawing.Point(425, 555);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(148, 36);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click_1);
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.BackColor = System.Drawing.Color.Red;
            this.labelTotalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalCourse.Location = new System.Drawing.Point(960, 543);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(224, 60);
            this.labelTotalCourse.TabIndex = 14;
            this.labelTotalCourse.Text = "TotalCourse:";
            this.labelTotalCourse.UseVisualStyleBackColor = false;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 30;
            this.listBoxCourses.Location = new System.Drawing.Point(678, 155);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(506, 364);
            this.listBoxCourses.TabIndex = 15;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click_1);
            this.listBoxCourses.DoubleClick += new System.EventHandler(this.listBoxCourses_DoubleClick_1);
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownPeriod.Location = new System.Drawing.Point(167, 212);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(316, 34);
            this.numericUpDownPeriod.TabIndex = 16;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemester.Location = new System.Drawing.Point(900, 41);
            this.textBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemester.Multiline = true;
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(163, 37);
            this.textBoxSemester.TabIndex = 74;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(743, 53);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(111, 25);
            this.labelSemester.TabIndex = 73;
            this.labelSemester.Text = "Semester:";
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherID.Location = new System.Drawing.Point(167, 300);
            this.textBoxTeacherID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(185, 34);
            this.textBoxTeacherID.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(16, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 112;
            this.label6.Text = "Teacher ID:";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1238, 688);
            this.Controls.Add(this.textBoxTeacherID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.labelTotalCourse);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.btn_EditCourse);
            this.Controls.Add(this.btn_AddCourse);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxID);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button btn_AddCourse;
        private System.Windows.Forms.Button btn_EditCourse;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button labelTotalCourse;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label6;
    }
}