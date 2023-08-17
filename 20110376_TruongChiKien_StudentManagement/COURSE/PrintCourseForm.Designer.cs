namespace _20110376_TruongChiKien_StudentManagement.COURSE
{
    partial class PrintCoursesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewPrintCourse = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(433, 421);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(233, 80);
            this.buttonPrint.TabIndex = 68;
            this.buttonPrint.Text = "To Printer";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // dataGridViewPrintCourse
            // 
            this.dataGridViewPrintCourse.AllowUserToAddRows = false;
            this.dataGridViewPrintCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrintCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrintCourse.Location = new System.Drawing.Point(83, -12);
            this.dataGridViewPrintCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrintCourse.Name = "dataGridViewPrintCourse";
            this.dataGridViewPrintCourse.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrintCourse.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrintCourse.Size = new System.Drawing.Size(631, 420);
            this.dataGridViewPrintCourse.TabIndex = 67;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(101, 421);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(261, 80);
            this.buttonSave.TabIndex = 69;
            this.buttonSave.Text = "Save To Text File";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // PrintCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewPrintCourse);
            this.Name = "PrintCoursesForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCoursesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewPrintCourse;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}