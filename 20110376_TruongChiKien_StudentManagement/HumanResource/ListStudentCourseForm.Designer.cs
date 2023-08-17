namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    partial class ListStudentCourseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.printToWord_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListContact = new System.Windows.Forms.DataGridView();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(433, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 53);
            this.label4.TabIndex = 62;
            this.label4.Text = "List Student Course Form";
            // 
            // printToWord_btn
            // 
            this.printToWord_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.printToWord_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToWord_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printToWord_btn.Location = new System.Drawing.Point(578, 451);
            this.printToWord_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printToWord_btn.Name = "printToWord_btn";
            this.printToWord_btn.Size = new System.Drawing.Size(267, 70);
            this.printToWord_btn.TabIndex = 67;
            this.printToWord_btn.Text = "Print To File Word";
            this.printToWord_btn.UseVisualStyleBackColor = false;
            this.printToWord_btn.Click += new System.EventHandler(this.printToWord_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(278, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 66;
            this.label3.Text = "STUDENT LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "COURSE";
            // 
            // dataGridViewListContact
            // 
            this.dataGridViewListContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListContact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.dataGridViewListContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListContact.Location = new System.Drawing.Point(271, 159);
            this.dataGridViewListContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListContact.Name = "dataGridViewListContact";
            this.dataGridViewListContact.RowHeadersWidth = 51;
            this.dataGridViewListContact.RowTemplate.Height = 24;
            this.dataGridViewListContact.Size = new System.Drawing.Size(995, 270);
            this.dataGridViewListContact.TabIndex = 64;
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(20, 159);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(215, 276);
            this.listBoxCourse.TabIndex = 63;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click_1);
            // 
            // ListStudentCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1298, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printToWord_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewListContact);
            this.Controls.Add(this.listBoxCourse);
            this.Name = "ListStudentCourseForm";
            this.Text = "ListStudentCourseForm";
            this.Load += new System.EventHandler(this.ListStudentCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printToWord_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListContact;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}