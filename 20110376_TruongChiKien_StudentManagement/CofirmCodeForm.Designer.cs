namespace _20110376_TruongChiKien_StudentManagement
{
    partial class CofirmCodeForm
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtCfCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Lime;
            this.btnVerify.Location = new System.Drawing.Point(240, 72);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(144, 41);
            this.btnVerify.TabIndex = 43;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtCfCode
            // 
            this.txtCfCode.Location = new System.Drawing.Point(226, 27);
            this.txtCfCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCfCode.Name = "txtCfCode";
            this.txtCfCode.Size = new System.Drawing.Size(172, 22);
            this.txtCfCode.TabIndex = 42;
            this.txtCfCode.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Confirmation Code:";
            // 
            // CofirmCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 153);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtCfCode);
            this.Controls.Add(this.label1);
            this.Name = "CofirmCodeForm";
            this.Text = "CofirmCodeForm";
            this.Load += new System.EventHandler(this.CofirmCodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtCfCode;
        private System.Windows.Forms.Label label1;
    }
}