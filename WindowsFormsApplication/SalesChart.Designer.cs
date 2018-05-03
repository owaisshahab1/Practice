namespace WindowsFormsApplication
{
    partial class SalesChart
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SalesByYearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SalesByYearChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesByYearChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SalesByYearChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.SalesByYearChart.Legends.Add(legend1);
            this.SalesByYearChart.Location = new System.Drawing.Point(26, 12);
            this.SalesByYearChart.Name = "SalesByYearChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "SalesByYear";
            this.SalesByYearChart.Series.Add(series1);
            this.SalesByYearChart.Size = new System.Drawing.Size(607, 239);
            this.SalesByYearChart.TabIndex = 0;
            this.SalesByYearChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.OrangeRed;
            title1.Name = "Title1";
            title1.Text = "Sales By Year Chart";
            this.SalesByYearChart.Titles.Add(title1);
            // 
            // SalesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 277);
            this.Controls.Add(this.SalesByYearChart);
            this.Name = "SalesChart";
            this.Text = "SalesChart";
            this.Load += new System.EventHandler(this.SalesChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesByYearChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SalesByYearChart;
    }
}