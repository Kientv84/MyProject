namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    partial class ManageScoreForm
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
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AvgScore = new System.Windows.Forms.Button();
            this.btn_removeScore = new System.Windows.Forms.Button();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.dataGridViewManageScore = new System.Windows.Forms.DataGridView();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.Location = new System.Drawing.Point(1088, 54);
            this.buttonShowScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(351, 28);
            this.buttonShowScore.TabIndex = 93;
            this.buttonShowScore.Text = "Show Scores";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click_1);
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.Location = new System.Drawing.Point(598, 54);
            this.buttonShowStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(351, 28);
            this.buttonShowStudent.TabIndex = 94;
            this.buttonShowStudent.Text = "Show Students";
            this.buttonShowStudent.UseVisualStyleBackColor = true;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "*to edit a score you have to delete it and RE add it with the values you want";
            // 
            // btn_AvgScore
            // 
            this.btn_AvgScore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_AvgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvgScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AvgScore.Location = new System.Drawing.Point(72, 541);
            this.btn_AvgScore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AvgScore.Name = "btn_AvgScore";
            this.btn_AvgScore.Size = new System.Drawing.Size(449, 48);
            this.btn_AvgScore.TabIndex = 91;
            this.btn_AvgScore.Text = "Avg Score By Course";
            this.btn_AvgScore.UseVisualStyleBackColor = false;
            this.btn_AvgScore.Click += new System.EventHandler(this.btn_AvgScore_Click);
            // 
            // btn_removeScore
            // 
            this.btn_removeScore.BackColor = System.Drawing.Color.Red;
            this.btn_removeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_removeScore.Location = new System.Drawing.Point(329, 471);
            this.btn_removeScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeScore.Name = "btn_removeScore";
            this.btn_removeScore.Size = new System.Drawing.Size(192, 49);
            this.btn_removeScore.TabIndex = 90;
            this.btn_removeScore.Text = "Remove ";
            this.btn_removeScore.UseVisualStyleBackColor = false;
            this.btn_removeScore.Click += new System.EventHandler(this.btn_removeScore_Click);
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddScore.Location = new System.Drawing.Point(72, 471);
            this.btn_AddScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(183, 49);
            this.btn_AddScore.TabIndex = 89;
            this.btn_AddScore.Text = "Add ";
            this.btn_AddScore.UseVisualStyleBackColor = false;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click_1);
            // 
            // dataGridViewManageScore
            // 
            this.dataGridViewManageScore.AllowUserToAddRows = false;
            this.dataGridViewManageScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageScore.Location = new System.Drawing.Point(598, 89);
            this.dataGridViewManageScore.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewManageScore.Name = "dataGridViewManageScore";
            this.dataGridViewManageScore.RowHeadersWidth = 51;
            this.dataGridViewManageScore.Size = new System.Drawing.Size(840, 582);
            this.dataGridViewManageScore.TabIndex = 88;
            this.dataGridViewManageScore.Click += new System.EventHandler(this.dataGridViewManageScore_Click_1);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(237, 160);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(313, 37);
            this.comboBoxCourse.TabIndex = 87;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(237, 309);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(313, 141);
            this.textBoxDescription.TabIndex = 84;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(237, 89);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudentID.Multiline = true;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(313, 35);
            this.textBoxStudentID.TabIndex = 85;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(237, 237);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(313, 35);
            this.textBoxScore.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Description:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStudentID.Location = new System.Drawing.Point(30, 101);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(121, 25);
            this.labelStudentID.TabIndex = 82;
            this.labelStudentID.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Select Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Score:";
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 769);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AvgScore);
            this.Controls.Add(this.btn_removeScore);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.dataGridViewManageScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AvgScore;
        private System.Windows.Forms.Button btn_removeScore;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.DataGridView dataGridViewManageScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}