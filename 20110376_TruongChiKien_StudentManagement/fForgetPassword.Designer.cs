namespace _20110376_TruongChiKien_StudentManagement
{
    partial class fForgetPassword
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
            this.labelSendCodevia = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.txtConfrimationCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSendCodevia
            // 
            this.labelSendCodevia.AutoSize = true;
            this.labelSendCodevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSendCodevia.Location = new System.Drawing.Point(159, 32);
            this.labelSendCodevia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendCodevia.Name = "labelSendCodevia";
            this.labelSendCodevia.Size = new System.Drawing.Size(217, 26);
            this.labelSendCodevia.TabIndex = 26;
            this.labelSendCodevia.Text = "Send Code via Email";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Lime;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(235, 257);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(128, 42);
            this.btnVerify.TabIndex = 25;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click_1);
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Red;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendCode.Location = new System.Drawing.Point(226, 144);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(155, 37);
            this.btnSendCode.TabIndex = 24;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click_1);
            // 
            // txtConfrimationCode
            // 
            this.txtConfrimationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfrimationCode.Location = new System.Drawing.Point(196, 203);
            this.txtConfrimationCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfrimationCode.Name = "txtConfrimationCode";
            this.txtConfrimationCode.Size = new System.Drawing.Size(219, 30);
            this.txtConfrimationCode.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Confirmation Code";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(196, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 30);
            this.txtEmail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // fForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 330);
            this.Controls.Add(this.labelSendCodevia);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtConfrimationCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "fForgetPassword";
            this.Text = "fForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSendCodevia;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox txtConfrimationCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
    }
}