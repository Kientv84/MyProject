namespace _20110376_TruongChiKien_StudentManagement
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.LinkLabel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ClearLabel = new System.Windows.Forms.LinkLabel();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonHumanResource = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.showpass_btn = new System.Windows.Forms.Button();
            this.hidepass_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(455, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(308, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(315, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(87, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Do you have account?";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.LinkColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(315, 455);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(83, 25);
            this.register.TabIndex = 5;
            this.register.TabStop = true;
            this.register.Text = "Register";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked_1);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(453, 205);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(349, 30);
            this.textBoxUsername.TabIndex = 7;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(453, 296);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(349, 32);
            this.textBoxPass.TabIndex = 8;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(444, 431);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(148, 72);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(653, 431);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(149, 72);
            this.login.TabIndex = 10;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_2);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(546, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 25);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.LinkColor = System.Drawing.Color.Black;
            this.ClearLabel.Location = new System.Drawing.Point(779, 349);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(59, 25);
            this.ClearLabel.TabIndex = 14;
            this.ClearLabel.TabStop = true;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearLabel_LinkClicked);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonStudent.Location = new System.Drawing.Point(524, 118);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(101, 29);
            this.radioButtonStudent.TabIndex = 15;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonHumanResource
            // 
            this.radioButtonHumanResource.AutoSize = true;
            this.radioButtonHumanResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHumanResource.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonHumanResource.Location = new System.Drawing.Point(670, 118);
            this.radioButtonHumanResource.Name = "radioButtonHumanResource";
            this.radioButtonHumanResource.Size = new System.Drawing.Size(184, 29);
            this.radioButtonHumanResource.TabIndex = 16;
            this.radioButtonHumanResource.TabStop = true;
            this.radioButtonHumanResource.Text = "Human Resource";
            this.radioButtonHumanResource.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 240);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAdmin.Location = new System.Drawing.Point(370, 118);
            this.radioButtonAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(89, 29);
            this.radioButtonAdmin.TabIndex = 21;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // showpass_btn
            // 
            this.showpass_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showpass_btn.BackgroundImage")));
            this.showpass_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showpass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass_btn.Location = new System.Drawing.Point(797, 296);
            this.showpass_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showpass_btn.Name = "showpass_btn";
            this.showpass_btn.Size = new System.Drawing.Size(32, 32);
            this.showpass_btn.TabIndex = 25;
            this.showpass_btn.UseVisualStyleBackColor = true;
            this.showpass_btn.Click += new System.EventHandler(this.showpass_btn_Click);
            // 
            // hidepass_btn
            // 
            this.hidepass_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidepass_btn.BackgroundImage")));
            this.hidepass_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hidepass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidepass_btn.Location = new System.Drawing.Point(797, 295);
            this.hidepass_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hidepass_btn.Name = "hidepass_btn";
            this.hidepass_btn.Size = new System.Drawing.Size(32, 32);
            this.hidepass_btn.TabIndex = 24;
            this.hidepass_btn.UseVisualStyleBackColor = true;
            this.hidepass_btn.Click += new System.EventHandler(this.hidepass_btn_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(910, 539);
            this.Controls.Add(this.showpass_btn);
            this.Controls.Add(this.hidepass_btn);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonHumanResource);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginform";
            this.Text = "loginform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel ClearLabel;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonHumanResource;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button showpass_btn;
        private System.Windows.Forms.Button hidepass_btn;
    }
}