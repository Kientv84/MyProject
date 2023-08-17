namespace _20110376_TruongChiKien_StudentManagement.RESULT
{
    partial class StaticResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanelCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelResult = new System.Windows.Forms.FlowLayoutPanel();
            this.BieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCourse
            // 
            this.flowLayoutPanelCourse.AutoScroll = true;
            this.flowLayoutPanelCourse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanelCourse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelCourse.Location = new System.Drawing.Point(96, 321);
            this.flowLayoutPanelCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelCourse.Name = "flowLayoutPanelCourse";
            this.flowLayoutPanelCourse.Size = new System.Drawing.Size(227, 262);
            this.flowLayoutPanelCourse.TabIndex = 57;
            // 
            // flowLayoutPanelResult
            // 
            this.flowLayoutPanelResult.AutoScroll = true;
            this.flowLayoutPanelResult.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanelResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelResult.Location = new System.Drawing.Point(408, 321);
            this.flowLayoutPanelResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelResult.Name = "flowLayoutPanelResult";
            this.flowLayoutPanelResult.Size = new System.Drawing.Size(227, 262);
            this.flowLayoutPanelResult.TabIndex = 58;
            // 
            // BieuDo
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDo.Legends.Add(legend1);
            this.BieuDo.Location = new System.Drawing.Point(767, 225);
            this.BieuDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BieuDo.Name = "BieuDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tong";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Pass";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Fall";
            this.BieuDo.Series.Add(series1);
            this.BieuDo.Series.Add(series2);
            this.BieuDo.Series.Add(series3);
            this.BieuDo.Size = new System.Drawing.Size(532, 391);
            this.BieuDo.TabIndex = 59;
            this.BieuDo.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(473, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 42);
            this.label4.TabIndex = 35;
            this.label4.Text = "Statistic Result Score Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Chart of students passing and failing by each course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Statistics of the results of each course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Statistic by Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Statistic by Course";
            // 
            // StaticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BieuDo);
            this.Controls.Add(this.flowLayoutPanelResult);
            this.Controls.Add(this.flowLayoutPanelCourse);
            this.Name = "StaticResult";
            this.Text = "StaticResult";
            this.Load += new System.EventHandler(this.StaticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}