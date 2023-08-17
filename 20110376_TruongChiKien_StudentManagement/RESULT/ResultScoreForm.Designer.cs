namespace _20110376_TruongChiKien_StudentManagement.RESULT
{
    partial class ResultScoreForm
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
            this.add_btn = new System.Windows.Forms.Button();
            this.Printer_btn = new System.Windows.Forms.Button();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxSudentID = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Blue;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.Location = new System.Drawing.Point(454, 520);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(285, 50);
            this.add_btn.TabIndex = 100;
            this.add_btn.Text = "Print To Text File";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // Printer_btn
            // 
            this.Printer_btn.BackColor = System.Drawing.Color.Red;
            this.Printer_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printer_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Printer_btn.Location = new System.Drawing.Point(949, 520);
            this.Printer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Printer_btn.Name = "Printer_btn";
            this.Printer_btn.Size = new System.Drawing.Size(296, 50);
            this.Printer_btn.TabIndex = 99;
            this.Printer_btn.Text = "To Printer";
            this.Printer_btn.UseVisualStyleBackColor = false;
            this.Printer_btn.Click += new System.EventHandler(this.Printer_btn_Click_1);
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AllowUserToAddRows = false;
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(346, 78);
            this.dataGridViewScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScore.Size = new System.Drawing.Size(1128, 405);
            this.dataGridViewScore.TabIndex = 98;
            this.dataGridViewScore.Click += new System.EventHandler(this.dataGridViewScore_Click_1);
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(11, 280);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(339, 25);
            this.labelSearch.TabIndex = 97;
            this.labelSearch.Text = "Search By ID, FName, LName:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(149, 226);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(141, 22);
            this.textBoxLName.TabIndex = 96;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(149, 172);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(141, 22);
            this.textBoxFName.TabIndex = 95;
            // 
            // textBoxSudentID
            // 
            this.textBoxSudentID.Location = new System.Drawing.Point(149, 112);
            this.textBoxSudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSudentID.Name = "textBoxSudentID";
            this.textBoxSudentID.Size = new System.Drawing.Size(141, 22);
            this.textBoxSudentID.TabIndex = 94;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(13, 226);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(106, 20);
            this.labelLName.TabIndex = 93;
            this.labelLName.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(11, 168);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(108, 20);
            this.labelFName.TabIndex = 92;
            this.labelFName.Text = "First Name:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(14, 112);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(104, 20);
            this.labelStudentID.TabIndex = 91;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelSub
            // 
            this.labelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(583, 9);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(268, 46);
            this.labelSub.TabIndex = 90;
            this.labelSub.Text = "Student Result";
            this.labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(19, 328);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 34);
            this.buttonSearch.TabIndex = 89;
            this.buttonSearch.Text = "   Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(149, 335);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(141, 22);
            this.textBoxSearch.TabIndex = 88;
            // 
            // ResultScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 700);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.Printer_btn);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxSudentID);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "ResultScoreForm";
            this.Text = "ResultScoreForm";
            this.Load += new System.EventHandler(this.ResultScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button Printer_btn;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxSudentID;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}