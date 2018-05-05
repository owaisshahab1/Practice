namespace WindowsFormsApplication
{
    partial class ChartDemoVc3
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SalesByChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FromcomboBox = new System.Windows.Forms.ComboBox();
            this.Fromlabel = new System.Windows.Forms.Label();
            this.TocomboBox = new System.Windows.Forms.ComboBox();
            this.Tolabel = new System.Windows.Forms.Label();
            this.OkayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesByChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesByChart2
            // 
            this.SalesByChart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.SalesByChart2.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.SalesByChart2.Legends.Add(legend1);
            this.SalesByChart2.Location = new System.Drawing.Point(12, 49);
            this.SalesByChart2.Name = "SalesByChart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SalesByChart2.Series.Add(series1);
            this.SalesByChart2.Size = new System.Drawing.Size(872, 232);
            this.SalesByChart2.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Sales By Year";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Title2";
            title2.Text = "Year";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.Name = "Title3";
            title3.Text = "Total";
            this.SalesByChart2.Titles.Add(title1);
            this.SalesByChart2.Titles.Add(title2);
            this.SalesByChart2.Titles.Add(title3);
            // 
            // FromcomboBox
            // 
            this.FromcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromcomboBox.FormattingEnabled = true;
            this.FromcomboBox.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.FromcomboBox.Location = new System.Drawing.Point(104, 13);
            this.FromcomboBox.Name = "FromcomboBox";
            this.FromcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FromcomboBox.TabIndex = 1;
            // 
            // Fromlabel
            // 
            this.Fromlabel.AutoSize = true;
            this.Fromlabel.Location = new System.Drawing.Point(24, 16);
            this.Fromlabel.Name = "Fromlabel";
            this.Fromlabel.Size = new System.Drawing.Size(30, 13);
            this.Fromlabel.TabIndex = 2;
            this.Fromlabel.Text = "From";
            // 
            // TocomboBox
            // 
            this.TocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TocomboBox.FormattingEnabled = true;
            this.TocomboBox.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.TocomboBox.Location = new System.Drawing.Point(334, 13);
            this.TocomboBox.Name = "TocomboBox";
            this.TocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TocomboBox.TabIndex = 1;
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Location = new System.Drawing.Point(254, 16);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(20, 13);
            this.Tolabel.TabIndex = 2;
            this.Tolabel.Text = "To";
            // 
            // OkayBtn
            // 
            this.OkayBtn.Location = new System.Drawing.Point(490, 12);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(75, 23);
            this.OkayBtn.TabIndex = 3;
            this.OkayBtn.Text = "OK";
            this.OkayBtn.UseVisualStyleBackColor = true;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // ChartDemoVc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 293);
            this.Controls.Add(this.OkayBtn);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.TocomboBox);
            this.Controls.Add(this.Fromlabel);
            this.Controls.Add(this.FromcomboBox);
            this.Controls.Add(this.SalesByChart2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartDemoVc3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Demo";
            this.Load += new System.EventHandler(this.ChartDemoVc3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesByChart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SalesByChart2;
        private System.Windows.Forms.ComboBox FromcomboBox;
        private System.Windows.Forms.Label Fromlabel;
        private System.Windows.Forms.ComboBox TocomboBox;
        private System.Windows.Forms.Label Tolabel;
        private System.Windows.Forms.Button OkayBtn;
    }
}