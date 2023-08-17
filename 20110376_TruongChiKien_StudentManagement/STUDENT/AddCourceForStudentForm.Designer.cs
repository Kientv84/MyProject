namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    partial class AddCourceForStudentForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbBoxSemester = new System.Windows.Forms.ComboBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lstBxSelect = new System.Windows.Forms.ListBox();
            this.lstBxAvailable = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(239, 348);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 53);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(265, 254);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 41);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "<=";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(265, 194);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "=>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cbBoxSemester
            // 
            this.cbBoxSemester.FormattingEnabled = true;
            this.cbBoxSemester.Location = new System.Drawing.Point(489, 38);
            this.cbBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxSemester.Name = "cbBoxSemester";
            this.cbBoxSemester.Size = new System.Drawing.Size(95, 24);
            this.cbBoxSemester.TabIndex = 40;
            this.cbBoxSemester.SelectedIndexChanged += new System.EventHandler(this.cbBoxSemester_SelectedIndexChanged_1);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(154, 41);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(151, 22);
            this.txtStudentID.TabIndex = 39;
            // 
            // lstBxSelect
            // 
            this.lstBxSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstBxSelect.FormattingEnabled = true;
            this.lstBxSelect.ItemHeight = 16;
            this.lstBxSelect.Location = new System.Drawing.Point(382, 171);
            this.lstBxSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBxSelect.Name = "lstBxSelect";
            this.lstBxSelect.Size = new System.Drawing.Size(181, 148);
            this.lstBxSelect.TabIndex = 38;
            this.lstBxSelect.Click += new System.EventHandler(this.lstBxSelect_Click_1);
            // 
            // lstBxAvailable
            // 
            this.lstBxAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lstBxAvailable.FormattingEnabled = true;
            this.lstBxAvailable.ItemHeight = 16;
            this.lstBxAvailable.Location = new System.Drawing.Point(53, 171);
            this.lstBxAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBxAvailable.Name = "lstBxAvailable";
            this.lstBxAvailable.Size = new System.Drawing.Size(181, 148);
            this.lstBxAvailable.TabIndex = 37;
            this.lstBxAvailable.Click += new System.EventHandler(this.lstBxAvailable_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Available Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Select Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Student ID";
            // 
            // AddCourceForStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbBoxSemester);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lstBxSelect);
            this.Controls.Add(this.lstBxAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourceForStudentForm";
            this.Text = "AddCourceForStudentForm";
            this.Load += new System.EventHandler(this.AddCourceForStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbBoxSemester;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ListBox lstBxSelect;
        private System.Windows.Forms.ListBox lstBxAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}