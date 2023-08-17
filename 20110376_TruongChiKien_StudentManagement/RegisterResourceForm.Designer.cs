namespace _20110376_TruongChiKien_StudentManagement
{
    partial class RegisterResourceForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxlname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.PictureBoxHumanResourse = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHumanResourse)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(28, 545);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(378, 29);
            this.linkLabel1.TabIndex = 93;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<Do you have an account? Log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 50);
            this.label1.TabIndex = 92;
            this.label1.Text = "Register Human Resource";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Fuchsia;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRegister.Location = new System.Drawing.Point(145, 473);
            this.btRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(124, 44);
            this.btRegister.TabIndex = 91;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click_1);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.Red;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upload.Location = new System.Drawing.Point(216, 381);
            this.upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(230, 39);
            this.upload.TabIndex = 90;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click_1);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(216, 223);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(230, 22);
            this.TextBoxPass.TabIndex = 88;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(216, 194);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(230, 22);
            this.TextBoxUserName.TabIndex = 87;
            // 
            // TextBoxlname
            // 
            this.TextBoxlname.Location = new System.Drawing.Point(216, 164);
            this.TextBoxlname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxlname.Name = "TextBoxlname";
            this.TextBoxlname.Size = new System.Drawing.Size(230, 22);
            this.TextBoxlname.TabIndex = 86;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(216, 132);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(230, 22);
            this.TextBoxFname.TabIndex = 85;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(216, 98);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(230, 22);
            this.txtStudentID.TabIndex = 84;
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Picture.Location = new System.Drawing.Point(74, 244);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(94, 29);
            this.Picture.TabIndex = 83;
            this.Picture.Text = "Picture:";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pass.Location = new System.Drawing.Point(51, 214);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(126, 29);
            this.Pass.TabIndex = 82;
            this.Pass.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserName.Location = new System.Drawing.Point(39, 185);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(141, 29);
            this.UserName.TabIndex = 81;
            this.UserName.Text = "User Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastName.Location = new System.Drawing.Point(42, 155);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(134, 29);
            this.LastName.TabIndex = 80;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstName.Location = new System.Drawing.Point(42, 125);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(137, 29);
            this.FirstName.TabIndex = 79;
            this.FirstName.Text = "First Name:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(123, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 29);
            this.ID.TabIndex = 78;
            this.ID.Text = "ID:";
            // 
            // PictureBoxHumanResourse
            // 
            this.PictureBoxHumanResourse.BackColor = System.Drawing.Color.White;
            this.PictureBoxHumanResourse.Location = new System.Drawing.Point(216, 253);
            this.PictureBoxHumanResourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxHumanResourse.Name = "PictureBoxHumanResourse";
            this.PictureBoxHumanResourse.Size = new System.Drawing.Size(230, 105);
            this.PictureBoxHumanResourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHumanResourse.TabIndex = 89;
            this.PictureBoxHumanResourse.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(315, 473);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 44);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 626);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.PictureBoxHumanResourse);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.TextBoxlname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RegisterResourceForm";
            this.Text = "RegisterResourceForm";
            this.Load += new System.EventHandler(this.RegisterResourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHumanResourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox PictureBoxHumanResourse;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxlname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label Picture;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btnCancel;
    }
}