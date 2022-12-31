using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba4
{
    public partial class MainForm : Form
    {
        Series DataSer_1, DataSer_2, DataSer_3, DataSer_4, DataSer_5, DataSer_6;
        

        public MainForm()
        {
            InitializeComponent();

            Calculate(1,NoisySignal.FilteringType.Parabolic);
        }

        private void Calculate(int freq, NoisySignal.FilteringType ft)
        {
            NoisySignal hs = new NoisySignal(10, freq, 0, 360);
            double[] fs = null;

            switch (ft)
            {
                case NoisySignal.FilteringType.Parabolic:
                    fs = hs.ps;
                    break;
                case NoisySignal.FilteringType.Median:
                    fs = hs.ms;
                    break;
                case NoisySignal.FilteringType.Sliding:
                    fs = hs.ss;
                    break;
                default:
                    break;
            }

            FunctionsChart.Series.Clear();

            DataSer_1 = new Series();
            DataSer_1.ChartType = SeriesChartType.Spline;
            DataSer_1.Color = Color.Red;
            DataSer_1.BorderWidth = 3;

            DataSer_2 = new Series();
            DataSer_2.ChartType = SeriesChartType.Spline;
            DataSer_2.Color = Color.Black;
            DataSer_2.BorderWidth = 3;

            for (int i = 0; i <= 359; i++)
            {
                DataSer_1.Points.AddXY(2 * Math.PI * i / 360, hs.signVal[i]);
                DataSer_2.Points.AddXY(2 * Math.PI * i / 360, fs[i]);
            }

            FunctionsChart.ResetAutoValues();
            FunctionsChart.Series.Add(DataSer_1);
            FunctionsChart.Series.Add(DataSer_2);

            hs.Operate(ft);

            PhaseChart.Series.Clear();
            
            DataSer_3 = new Series();
            DataSer_3.ChartType = SeriesChartType.Candlestick;
            DataSer_3.Color = Color.Red;
            DataSer_3.BorderWidth = 5;

            DataSer_5 = new Series();
            DataSer_5.ChartType = SeriesChartType.Candlestick;
            DataSer_5.Color = Color.Black;
            DataSer_5.BorderWidth = 3;

            DataSer_4 = new Series();
            DataSer_4.ChartType = SeriesChartType.Candlestick;
            DataSer_4.Color = Color.Red;
            DataSer_4.BorderWidth = 5;

            DataSer_6 = new Series();
            DataSer_6.ChartType = SeriesChartType.Candlestick;
            DataSer_6.Color = Color.Black;
            DataSer_6.BorderWidth = 3;

            AmplitudeChart.Series.Clear();

            for (int i = 0; i <= 49; i++)
            {
                DataSer_3.Points.AddXY(i, hs.phaseSp[i]);
                DataSer_4.Points.AddXY(i, hs.amplSp[i]);
                DataSer_5.Points.AddXY(i, hs.psp[i]);
                DataSer_6.Points.AddXY(i, hs.asp[i]);
            }

            PhaseChart.ResetAutoValues();
            PhaseChart.Series.Add(DataSer_3);
            PhaseChart.Series.Add(DataSer_5);

            AmplitudeChart.ResetAutoValues();
            AmplitudeChart.Series.Add(DataSer_4);
            AmplitudeChart.Series.Add(DataSer_6);
        }

        private void Parabolic_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Parabolic);
        }

        private void Median_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Median);
        }

        private void Sliding_Checked(object sender, EventArgs e)
        {
            Calculate(1, NoisySignal.FilteringType.Sliding);
        }
    }
}
