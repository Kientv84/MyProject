namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    partial class AddScoreForm
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
            this.qlsvDataSet1 = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewAddScore = new System.Windows.Forms.DataGridView();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // qlsvDataSet1
            // 
            this.qlsvDataSet1.DataSetName = "qlsvDataSet";
            this.qlsvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(82, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(47, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxStudentID.Location = new System.Drawing.Point(230, 48);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(289, 34);
            this.textBoxStudentID.TabIndex = 4;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxScore.Location = new System.Drawing.Point(230, 195);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(289, 34);
            this.textBoxScore.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxDescription.Location = new System.Drawing.Point(230, 352);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(289, 34);
            this.textBoxDescription.TabIndex = 7;
            // 
            // dataGridViewAddScore
            // 
            this.dataGridViewAddScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddScore.Location = new System.Drawing.Point(572, 48);
            this.dataGridViewAddScore.Name = "dataGridViewAddScore";
            this.dataGridViewAddScore.RowHeadersWidth = 51;
            this.dataGridViewAddScore.RowTemplate.Height = 24;
            this.dataGridViewAddScore.Size = new System.Drawing.Size(498, 440);
            this.dataGridViewAddScore.TabIndex = 8;
            this.dataGridViewAddScore.Click += new System.EventHandler(this.dataGridViewAddScore_Click_1);
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.BackColor = System.Drawing.Color.Red;
            this.btn_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_AddScore.Location = new System.Drawing.Point(43, 423);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(476, 44);
            this.btn_AddScore.TabIndex = 9;
            this.btn_AddScore.Text = "Add Score";
            this.btn_AddScore.UseVisualStyleBackColor = false;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click_1);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(230, 118);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(289, 37);
            this.comboBoxCourse.TabIndex = 10;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemester.Location = new System.Drawing.Point(230, 276);
            this.textBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemester.Multiline = true;
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(289, 37);
            this.textBoxSemester.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(47, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Semester:";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1099, 515);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.dataGridViewAddScore);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private qlsvDataSet qlsvDataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridViewAddScore;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label label5;
    }
}