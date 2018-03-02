using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication
{
    public partial class msChart : Form
    {
        List<double> seriesColumnEval = new List<double> ();
        List<double> seriesLineTime = new List<double> ();
        List<double> seriesLineDepth = new List<double> ();
        bool initialData;

        


        public msChart ()
        {
            seriesColumnEval.Add (0.1);
            seriesColumnEval.Add (0.2);
            seriesColumnEval.Add (0.4);
            seriesColumnEval.Add (0.8);
            seriesColumnEval.Add (1);
            seriesColumnEval.Add (1.5);

            seriesLineDepth.Add (10);
            seriesLineDepth.Add (12);
            seriesLineDepth.Add (15);
            seriesLineDepth.Add (14);
            seriesLineDepth.Add (18);
            seriesLineDepth.Add (25);

            seriesLineTime.Add (0.05);  // 5
            seriesLineTime.Add (0.10);  // 10
            seriesLineTime.Add (0.15);   // 15
            seriesLineTime.Add (0.20);  // 20
            seriesLineTime.Add (0.25);  // 0.25
            seriesLineTime.Add (0.45);  // 0.45


            InitializeComponent ();
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            StripLine sp = new StripLine ();
            sp.Interval = 0;
            sp.StripWidth = 0.01;
            sp.BackColor = Color.Black;
            chart1.ChartAreas[0].AxisY.StripLines.Add (sp);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 25;

        }

        public void Game_ClearGraphData ()
        {
            ClearAllGraph ();
            timeToolStripMenuItem.Checked = true;
            depthToolStripMenuItem.Checked = true;
            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset ();
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset ();
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 25;

        }

        private void EvalGraphUc_Load (object sender, EventArgs e)
        {

            this.chart1.Series.Clear ();
            this.chart1.Height = this.Height;
            this.chart1.Width = this.Width;
            InitializeGraph ();
            initialData = true;

        }


        private void EvalGraphUc_Resize (object sender, System.EventArgs e)
        {
            this.chart1.Height = this.Height;
            this.chart1.Width = this.Width;

        }
        private void Form1_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show ();
            }
        }
        private void chart1_Click (object sender, EventArgs e)
        {

        }


        public void InitializeGraph ()
        {
            seriesColumnEval.Add (0);
            seriesLineDepth.Add (0);
            seriesLineTime.Add (0);
            DrawEvaluationGraph ();
            DrawDepthGraph ();
            DrawTimeGraph ();
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 25;

        }

        public void DrawChart ()
        {
            if (initialData)
            {
                seriesColumnEval.Remove (0);
                seriesLineDepth.Remove (0);
                seriesLineTime.Remove (0); initialData = false;
            }

            try
            {



                this.chart1.Series.Clear ();
                DrawEvaluationGraph ();
                DrawTimeGraph ();
                DrawDepthGraph ();

                //  if (chart1.ChartAreas[0].AxisX.ScrollBar.IsVisible) chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset ();
                //  if (chart1.ChartAreas[0].AxisY.ScrollBar.IsVisible) chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset ();
            }
            catch (Exception ex)
            {

            }

        }

        public void DrawEvaluationGraph ()
        {
            if (EvaluationToolStripMenuItem.Checked)
            {
                Series series = this.chart1.Series.Add ("");
                chart1.Series["Series1"]["PointWidth"] = "1";
                for (int i = 0; i < seriesColumnEval.Count; i++)
                {
                    series.Points.AddXY (i, seriesColumnEval[i]);
                    series.Points[i].Color = seriesColumnEval[i] > 0 ? Color.Green : Color.Red;
                }
            }

            try
            {
                double maxY = seriesColumnEval.Max ();
                double minY = seriesColumnEval.Min ();

                double result = Math.Abs (maxY) > Math.Abs (minY) ? Math.Abs (maxY) : Math.Abs (minY);

                chart1.ChartAreas[0].AxisY.Minimum = -result;
                chart1.ChartAreas[0].AxisY.Maximum = result;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = seriesColumnEval.Count;
            }
            catch { }





        }

        public void DrawTimeGraph ()
        {

            Series series3 = this.chart1.Series.Add ("");
            series3.ChartType = SeriesChartType.FastLine;
            series3.Color = Color.Purple;
            series3.BorderWidth = 3;

            if (depthToolStripMenuItem.Checked)
            {

                for (int i = 0; i < seriesLineTime.Count; i++)
                {
                    series3.Points.AddXY (i + 1 / 10, seriesLineTime[i] / 10);
                }
            }
            try
            {
                double maxY = seriesColumnEval.Max ();
                double minY = seriesColumnEval.Min ();

                double result = Math.Abs (maxY) > Math.Abs (minY) ? Math.Abs (maxY) : Math.Abs (minY);



                chart1.ChartAreas[0].AxisY.Minimum = -result;
                chart1.ChartAreas[0].AxisY.Maximum = result;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = seriesColumnEval.Count;
            }
            catch { }

        }
        public void DrawDepthGraph ()
        {

            Series series2 = this.chart1.Series.Add ("");

            series2.ChartType = SeriesChartType.FastLine;
            series2.Color = Color.Orange;
            series2.BorderWidth = 3;

            if (timeToolStripMenuItem.Checked)

            {



                for (int i = 0; i < seriesLineDepth.Count; i++)
                {
                    series2.Points.AddXY (i + 1 / 10, seriesLineDepth[i] / 10);
                }
            }



        }




        public void ClearAllGraph ()
        {

            chart1.Series.Clear ();
            seriesColumnEval.Clear ();
            seriesLineDepth.Clear ();
            seriesLineTime.Clear ();

            //   chart1.ChartAreas[0].AxisY.ScaleView.Size = 10;
            //   chart1.ChartAreas[0].AxisY2.ScaleView.Size = 10;
            //   chart1.ChartAreas[0].AxisX.ScaleView.Size = 30;
            //   chart1.ChartAreas[0].AxisX2.ScaleView.Size = 30;

            InitializeGraph ();
        }

        private void EvaluationToolStripMenuItem_Click (object sender, EventArgs e)
        {
            EvaluationToolStripMenuItem.Checked = !EvaluationToolStripMenuItem.Checked;

            this.Refresh ();

            this.chart1.Series.Clear ();
            DrawEvaluationGraph ();
            DrawTimeGraph ();
            DrawDepthGraph ();

        }


        private void timeToolStripMenuItem_Click (object sender, EventArgs e)
        {

            timeToolStripMenuItem.Checked = !timeToolStripMenuItem.Checked;
            this.Refresh ();
            this.chart1.Series.Clear ();
            DrawEvaluationGraph ();
            DrawTimeGraph ();
            DrawDepthGraph ();



        }

        private void depthToolStripMenuItem_Click (object sender, EventArgs e)
        {

            depthToolStripMenuItem.Checked = !depthToolStripMenuItem.Checked;
            this.Refresh ();
            this.chart1.Series.Clear ();
            DrawEvaluationGraph ();
            DrawTimeGraph ();
            DrawDepthGraph ();
        }

        private void EvalGraphUc_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show (this, PointToClient (MousePosition));
            }
        }

        private void label2_Click (object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click (object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = chart1;
            label1.BringToFront ();
        }

        private void chart1_Click_1 (object sender, EventArgs e)
        {

        }
    }
}
