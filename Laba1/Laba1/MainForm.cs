using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series DataSer;

        private List<TrackBar> trLst = new List<TrackBar>();

        double[] phc = new double[15];

        double A, f, phi;

        const int N = 1024;

        public MainForm()
        {
            InitializeComponent();

            trLst.Add(Phi1);
            trLst.Add(F1);
            trLst.Add(A1);
            trLst.Add(Phi2);
            trLst.Add(F2);
            trLst.Add(A2);
            trLst.Add(Phi3);
            trLst.Add(F3);
            trLst.Add(A3);
            trLst.Add(Phi4);
            trLst.Add(F4);
            trLst.Add(A4);
            trLst.Add(Phi5);
            trLst.Add(F5);
            trLst.Add(A5);
            
            for (int i = 0; i <= 14; i++)
            {
                phc[i] = trLst[i].Value;
                trLst[i].Scroll += new EventHandler(BuildPolyHarmGraph);
            }

            BuildHarmGraph();
        }

        private void BuildHarmGraph()
        {
            try
            {
                Graphics.Series.Remove(DataSer);
            }
            finally
            {
                DataSer = new System.Windows.Forms.DataVisualization.Charting.Series();
                DataSer.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                DataSer.Color = Color.Black;
                DataSer.BorderWidth = 3;

                A = trLst[2].Value;
                f = trLst[1].Value;
                phi = trLst[0].Value;

                for (int n = 0; n <= N - 1; n++)
                {
                    DataSer.Points.AddXY(n, A * Math.Sin(2 * Math.PI * f * n / N + phi / 180 * Math.PI));
                }
            }

            Graphics.ResetAutoValues();
            Graphics.Series.Add(DataSer);
        }

        private void BuildPolyHarmGraph(object sender, EventArgs e)
        {
            if (Harmonic1.Enabled && ! Harmonic2.Enabled)
            {
                BuildHarmGraph();
            }
            else
            {
                try
                {
                    Graphics.Series.Remove(DataSer);
                }
                finally
                {
                    for (int i = 0; i <= 14; i++)
                    {
                        phc[i] = trLst[i].Value;
                    }

                    DataSer = new System.Windows.Forms.DataVisualization.Charting.Series();
                    DataSer.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    DataSer.Color = Color.Black;
                    DataSer.BorderWidth = 3;

                    for (int n = 0; n <= N - 1; n++)
                    {
                        double res = 0;
                        for (int k = 0; k <= 4; k++)
                        {
                            double t = (phc[k * 3 + 2]) * Math.Sin(2 * Math.PI * (phc[k * 3 + 1]) * n / N + (phc[k * 3]) / 180 * Math.PI);
                            res += t;
                        }
                        DataSer.Points.AddXY(n, res);
                    }
                }

                Graphics.ResetAutoValues();
                Graphics.Series.Add(DataSer);
            }    
        }

        private void Harmonic_CheckedChanged(object sender, EventArgs e)
        {
            Harmonic1.Enabled = true;
            Harmonic2.Enabled = false;
            Harmonic3.Enabled = false;
            Harmonic4.Enabled = false;
            Harmonic5.Enabled = false;

            BuildHarmGraph();
        }

        private void Polyharmonic_CheckedChanged(object sender, EventArgs e)
        {
            Harmonic1.Enabled = true;
            Harmonic2.Enabled = true;
            Harmonic3.Enabled = true;
            Harmonic4.Enabled = true;
            Harmonic5.Enabled = true;

            BuildPolyHarmGraph(sender,e);
        }
    }
}
