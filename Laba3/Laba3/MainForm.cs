using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;

namespace Laba3
{
    public partial class MainForm : Form
    {
        enum SignalType { Harmonic, Polyharmonic }  

        SignalType currentSignal;
        FilterType currentFilterType;

        bool Redraw = false;

        Signal instSignal;

        Chart[] targetCharts;

        public MainForm()
        {
            InitializeComponent();

            targetCharts = new Chart[4];
            targetCharts[0] = FunctionsChart;
            targetCharts[1] = PhaseChart;
            targetCharts[2] = FFTChart;
            targetCharts[3] = AmplitudeChart;

            Filters.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SignalsType.SelectedIndex = 0;
            FiltersType.SelectedIndex = 3;

            FLabel.Text = "F: " + Convert.ToString(FTracker.Value);
            LFLabel.Text = "LF: " + Convert.ToString(LFTracker.Value);
            HFLabel.Text = "HF: " + Convert.ToString(HFTracker.Value);

            currentSignal = SignalType.Harmonic;
            currentFilterType = FilterType.none;

            Calculate(FTracker.Value, 0, 0);          
        }

        private void Calculate(int freq, int min, int max)
        {
            Signal hs;
            int N = 1024;
            if (Redraw == false || instSignal == null) { 
                if (currentSignal == SignalType.Harmonic)
                {
                    hs = new HarmonicSignal(20, freq, Math.PI / 4, N, min, max, currentFilterType);
                }
                else
                {
                    double[] A = new double[7] { 1, 3, 4, 10, 11, 14, 17 };
                    double[] ph = new double[6] { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 3 * Math.PI / 4, Math.PI };
                    hs = new PolyharmonicSignal(A, freq, ph, N, min, max, currentFilterType);
                }
                instSignal = hs;
            }
            else if (instSignal != null & Redraw == true)
                instSignal.reDrawSignal(min, max, currentFilterType);

            ClearCharts();
            
            Complex[] Summa = new Complex[N];
            for (int i = 0; i <= N - 1; i++)
            {
                targetCharts[0].Series[0].Points.AddXY(2 * Math.PI * i / N, instSignal.signVal[i]);
                Summa[i] = instSignal.signVal[i];
            }

            for (int i = 0; i <= instSignal.resotorePoints - 1; i++)
            {
                targetCharts[0].Series[1].Points.AddXY(2 * Math.PI * i / instSignal.resotorePoints, instSignal.restoredSignal[i]);
                targetCharts[0].Series[2].Points.AddXY(2 * Math.PI * i / instSignal.resotorePoints, instSignal.restorednonphasedSignal[i]);
            }

            for (int i = 0; i <= instSignal.numHarm - 1; i++)
            {
                targetCharts[1].Series[0].Points.AddXY(i, instSignal.phaseSp[i]);
                targetCharts[2].Series[0].Points.AddXY(i, instSignal.amplSp[i]);
            }

            if (currentSignal == SignalType.Polyharmonic)
            {
                Complex[] Summa2 = FFT.DecimationInTime(Summa, true);
                for (int i=0; i < Summa2.Length; i++)
                {
                    Summa2[i] /= Summa2.Length;
                    targetCharts[3].Series[0].Points.AddXY(2 * Math.PI * i / N, Math.Sqrt(Math.Pow(Summa2[i].Real, 2) + Math.Pow(Summa2[i].Imaginary, 2)));
                }               
            }
        }

        private void ClearCharts()
        {
            for (int i = 0; i <= 2; i++)
            {
                foreach (var j in targetCharts[i].Series)
                {
                    j.Points.Clear();
                }
            }
        }

        private void FTracker_Scroll(object sender, EventArgs e)
        {
            FLabel.Text = "F: " + Convert.ToString(FTracker.Value);
            Redraw = false;
            Calculate(FTracker.Value, LFTracker.Value, HFTracker.Value);
        }

        private void LFTracker_Scroll(object sender, EventArgs e)
        {
            LFLabel.Text = "LF: " + Convert.ToString(LFTracker.Value);
            Redraw = true;
            Calculate(FTracker.Value, LFTracker.Value, HFTracker.Value);
        }

        private void HFTracker_Scroll(object sender, EventArgs e)
        {
            HFLabel.Text = "HF: " + Convert.ToString(HFTracker.Value);
            Redraw = true;
            Calculate(FTracker.Value, LFTracker.Value, HFTracker.Value);
        }

        private void FiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltersType.SelectedIndex == 0)
            {
                currentFilterType = FilterType.Min;
            }
            else if (FiltersType.SelectedIndex == 1)
            {
                currentFilterType = FilterType.Max;
            }
            else if(FiltersType.SelectedIndex == 3)
            {
                currentFilterType = FilterType.none;
            }
            else
            {
                currentFilterType = FilterType.MinMax;
            }

            Redraw = true;

            Calculate(FTracker.Value, LFTracker.Value, HFTracker.Value);
        }

        private void SignalsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SignalsType.SelectedIndex == 0)
            {
                currentSignal = SignalType.Harmonic;
                currentFilterType = FilterType.none;
                Filters.Enabled = false;
            }
            else
            {
                currentSignal = SignalType.Polyharmonic;
                Filters.Enabled = true;
            }
            Redraw = false;

            Calculate(FTracker.Value, LFTracker.Value, HFTracker.Value);
        }
    }
}
