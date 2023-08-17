namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    partial class StaticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.LabelMale = new System.Windows.Forms.Label();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelTotal.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.Cyan;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LabelTotal.Location = new System.Drawing.Point(0, 0);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(1010, 349);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total Student: 100%";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            // 
            // LabelFemale
            // 
            this.LabelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LabelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LabelFemale.Location = new System.Drawing.Point(-5, 0);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(513, 85);
            this.LabelFemale.TabIndex = 1;
            this.LabelFemale.Text = "Female: 50%";
            this.LabelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMale
            // 
            this.LabelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LabelMale.Location = new System.Drawing.Point(-10, 0);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(521, 85);
            this.LabelMale.TabIndex = 2;
            this.LabelMale.Text = "Male: 50%";
            this.LabelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTotal
            // 
            this.PanelTotal.Controls.Add(this.LabelTotal);
            this.PanelTotal.Location = new System.Drawing.Point(0, 0);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(1014, 320);
            this.PanelTotal.TabIndex = 3;
            // 
            // PanelMale
            // 
            this.PanelMale.Controls.Add(this.LabelMale);
            this.PanelMale.Location = new System.Drawing.Point(0, 323);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(503, 85);
            this.PanelMale.TabIndex = 4;
            // 
            // PanelFemale
            // 
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(502, 323);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(512, 85);
            this.PanelFemale.TabIndex = 5;
            // 
            // BarChart
            // 
            this.BarChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(0, 410);
            this.BarChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarChart.Name = "BarChart";
            this.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Student";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(503, 351);
            this.BarChart.TabIndex = 11;
            this.BarChart.Text = "chart2";
            this.BarChart.Click += new System.EventHandler(this.BarChart_Click);
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(502, 410);
            this.PieChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Student";
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(512, 351);
            this.PieChart.TabIndex = 12;
            this.PieChart.Text = "chart2";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 763);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelMale.ResumeLayout(false);
            this.PanelFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelFemale;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}