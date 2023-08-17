namespace _20110376_TruongChiKien_StudentManagement.COURSE
{
    partial class RemoveCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.btn_removeCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Course ID:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxCourseID.Location = new System.Drawing.Point(387, 53);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(282, 34);
            this.textBoxCourseID.TabIndex = 1;
            // 
            // btn_removeCourse
            // 
            this.btn_removeCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_removeCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_removeCourse.Location = new System.Drawing.Point(723, 43);
            this.btn_removeCourse.Name = "btn_removeCourse";
            this.btn_removeCourse.Size = new System.Drawing.Size(196, 54);
            this.btn_removeCourse.TabIndex = 2;
            this.btn_removeCourse.Text = "Remove";
            this.btn_removeCourse.UseVisualStyleBackColor = false;
            this.btn_removeCourse.Click += new System.EventHandler(this.btn_removeCourse_Click_1);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1035, 172);
            this.Controls.Add(this.btn_removeCourse);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.Load += new System.EventHandler(this.RemoveCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Button btn_removeCourse;
    }
}