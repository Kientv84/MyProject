namespace _20110376_TruongChiKien_StudentManagement
{
    partial class RegisterForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.lblConfirmEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.label2.Location = new System.Drawing.Point(105, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.label3.Location = new System.Drawing.Point(113, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.label5.Location = new System.Drawing.Point(161, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.textBoxUsername.Location = new System.Drawing.Point(267, 81);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(348, 36);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.textBoxPassword.Location = new System.Drawing.Point(267, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(348, 36);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.textBoxConfirmPass.Location = new System.Drawing.Point(267, 233);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '*';
            this.textBoxConfirmPass.Size = new System.Drawing.Size(348, 36);
            this.textBoxConfirmPass.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.textBoxEmail.Location = new System.Drawing.Point(267, 304);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(348, 36);
            this.textBoxEmail.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(267, 431);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 60);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRegister.ForeColor = System.Drawing.Color.Red;
            this.buttonRegister.Location = new System.Drawing.Point(461, 431);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(154, 60);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Sign up";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Red;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendCode.Location = new System.Drawing.Point(267, 370);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(348, 44);
            this.btnSendCode.TabIndex = 45;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // lblConfirmEmail
            // 
            this.lblConfirmEmail.AutoSize = true;
            this.lblConfirmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmEmail.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblConfirmEmail.Location = new System.Drawing.Point(635, 384);
            this.lblConfirmEmail.Name = "lblConfirmEmail";
            this.lblConfirmEmail.Size = new System.Drawing.Size(50, 16);
            this.lblConfirmEmail.TabIndex = 46;
            this.lblConfirmEmail.Text = "label1";
            this.lblConfirmEmail.Click += new System.EventHandler(this.lblConfirmEmail_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.lblConfirmEmail);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblConfirmEmail;
    }
}