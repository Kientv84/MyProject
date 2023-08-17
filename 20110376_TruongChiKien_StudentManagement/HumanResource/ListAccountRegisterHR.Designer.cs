namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    partial class ListAccountRegisterHR
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.qlsvDataSet9 = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet9();
            this.registerAccountHRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerAccountHRTableAdapter = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet9TableAdapters.RegisterAccountHRTableAdapter();
            this.qlsvDataSet10 = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet10();
            this.qlsvDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qlsvDataSet11 = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet11();
            this.registerAccountHRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerAccountHRTableAdapter1 = new _20110376_TruongChiKien_StudentManagement.qlsvDataSet11TableAdapters.RegisterAccountHRTableAdapter();
            this.pigDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verifyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerAccountHRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerAccountHRBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(17, 362);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // qlsvDataSet9
            // 
            this.qlsvDataSet9.DataSetName = "qlsvDataSet9";
            this.qlsvDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerAccountHRBindingSource
            // 
            this.registerAccountHRBindingSource.DataMember = "RegisterAccountHR";
            this.registerAccountHRBindingSource.DataSource = this.qlsvDataSet9;
            // 
            // registerAccountHRTableAdapter
            // 
            this.registerAccountHRTableAdapter.ClearBeforeFill = true;
            // 
            // qlsvDataSet10
            // 
            this.qlsvDataSet10.DataSetName = "qlsvDataSet10";
            this.qlsvDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlsvDataSet10BindingSource
            // 
            this.qlsvDataSet10BindingSource.DataSource = this.qlsvDataSet10;
            this.qlsvDataSet10BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verifyDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.pigDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.registerAccountHRBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 299);
            this.dataGridView1.TabIndex = 11;
            // 
            // qlsvDataSet11
            // 
            this.qlsvDataSet11.DataSetName = "qlsvDataSet11";
            this.qlsvDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerAccountHRBindingSource1
            // 
            this.registerAccountHRBindingSource1.DataMember = "RegisterAccountHR";
            this.registerAccountHRBindingSource1.DataSource = this.qlsvDataSet11;
            // 
            // registerAccountHRTableAdapter1
            // 
            this.registerAccountHRTableAdapter1.ClearBeforeFill = true;
            // 
            // pigDataGridViewImageColumn
            // 
            this.pigDataGridViewImageColumn.DataPropertyName = "pig";
            this.pigDataGridViewImageColumn.HeaderText = "Picture";
            this.pigDataGridViewImageColumn.MinimumWidth = 6;
            this.pigDataGridViewImageColumn.Name = "pigDataGridViewImageColumn";
            this.pigDataGridViewImageColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // verifyDataGridViewCheckBoxColumn
            // 
            this.verifyDataGridViewCheckBoxColumn.DataPropertyName = "verify";
            this.verifyDataGridViewCheckBoxColumn.HeaderText = "Verify";
            this.verifyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.verifyDataGridViewCheckBoxColumn.Name = "verifyDataGridViewCheckBoxColumn";
            this.verifyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ListAccountRegisterHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Name = "ListAccountRegisterHR";
            this.Text = "ListAccountRegisterHR";
            this.Load += new System.EventHandler(this.ListAccountRegisterHR_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerAccountHRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerAccountHRBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private qlsvDataSet9 qlsvDataSet9;
        private System.Windows.Forms.BindingSource registerAccountHRBindingSource;
        private qlsvDataSet9TableAdapters.RegisterAccountHRTableAdapter registerAccountHRTableAdapter;
        private qlsvDataSet10 qlsvDataSet10;
        private System.Windows.Forms.BindingSource qlsvDataSet10BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private qlsvDataSet11 qlsvDataSet11;
        private System.Windows.Forms.BindingSource registerAccountHRBindingSource1;
        private qlsvDataSet11TableAdapters.RegisterAccountHRTableAdapter registerAccountHRTableAdapter1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn verifyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pigDataGridViewImageColumn;
    }
}