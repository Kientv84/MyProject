namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    partial class PrintScoreForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelReset = new System.Windows.Forms.LinkLabel();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scores List";
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelReset.Location = new System.Drawing.Point(752, 9);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(72, 29);
            this.labelReset.TabIndex = 2;
            this.labelReset.TabStop = true;
            this.labelReset.Text = "reset";
            this.labelReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelReset_LinkClicked);
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Location = new System.Drawing.Point(349, 51);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.RowHeadersWidth = 51;
            this.dataGridViewScoreList.RowTemplate.Height = 24;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(814, 443);
            this.dataGridViewScoreList.TabIndex = 4;
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(1184, 94);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 24;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(421, 359);
            this.dataGridViewStudentList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1198, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student List";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 16;
            this.listBoxCourses.Location = new System.Drawing.Point(66, 138);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(258, 276);
            this.listBoxCourses.TabIndex = 7;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(669, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "To Printer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.dataGridViewScoreList);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel labelReset;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}