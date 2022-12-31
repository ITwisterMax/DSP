namespace Laba3
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SignalParameters = new System.Windows.Forms.GroupBox();
            this.FLabel = new System.Windows.Forms.Label();
            this.FTracker = new System.Windows.Forms.TrackBar();
            this.SignalsType = new System.Windows.Forms.ComboBox();
            this.FiltersType = new System.Windows.Forms.ComboBox();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.HFLabel = new System.Windows.Forms.Label();
            this.LFLabel = new System.Windows.Forms.Label();
            this.HFTracker = new System.Windows.Forms.TrackBar();
            this.LFTracker = new System.Windows.Forms.TrackBar();
            this.AmplitudeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FFTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PhaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SignalParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FTracker)).BeginInit();
            this.Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HFTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFTChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SignalParameters
            // 
            this.SignalParameters.Controls.Add(this.FLabel);
            this.SignalParameters.Controls.Add(this.FTracker);
            this.SignalParameters.Controls.Add(this.SignalsType);
            this.SignalParameters.Location = new System.Drawing.Point(704, 11);
            this.SignalParameters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignalParameters.Name = "SignalParameters";
            this.SignalParameters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignalParameters.Size = new System.Drawing.Size(252, 153);
            this.SignalParameters.TabIndex = 1;
            this.SignalParameters.TabStop = false;
            this.SignalParameters.Text = "Signal parameters";
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(6, 74);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(20, 17);
            this.FLabel.TabIndex = 2;
            this.FLabel.Text = "F:";
            // 
            // FTracker
            // 
            this.FTracker.Location = new System.Drawing.Point(6, 93);
            this.FTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTracker.Maximum = 29;
            this.FTracker.Minimum = 1;
            this.FTracker.Name = "FTracker";
            this.FTracker.Size = new System.Drawing.Size(236, 56);
            this.FTracker.TabIndex = 1;
            this.FTracker.Value = 1;
            this.FTracker.Scroll += new System.EventHandler(this.FTracker_Scroll);
            // 
            // SignalsType
            // 
            this.SignalsType.FormattingEnabled = true;
            this.SignalsType.Items.AddRange(new object[] {
            "Harmonic",
            "Polyharmonic"});
            this.SignalsType.Location = new System.Drawing.Point(6, 22);
            this.SignalsType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignalsType.Name = "SignalsType";
            this.SignalsType.Size = new System.Drawing.Size(236, 24);
            this.SignalsType.TabIndex = 0;
            this.SignalsType.SelectedIndexChanged += new System.EventHandler(this.SignalsType_SelectedIndexChanged);
            // 
            // FiltersType
            // 
            this.FiltersType.FormattingEnabled = true;
            this.FiltersType.Items.AddRange(new object[] {
            "LF filter",
            "HF filter",
            "Band-pass filter",
            "Choose a filter type"});
            this.FiltersType.Location = new System.Drawing.Point(9, 22);
            this.FiltersType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltersType.Name = "FiltersType";
            this.FiltersType.Size = new System.Drawing.Size(198, 24);
            this.FiltersType.TabIndex = 2;
            this.FiltersType.SelectedIndexChanged += new System.EventHandler(this.FiltersType_SelectedIndexChanged);
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.HFLabel);
            this.Filters.Controls.Add(this.LFLabel);
            this.Filters.Controls.Add(this.HFTracker);
            this.Filters.Controls.Add(this.LFTracker);
            this.Filters.Controls.Add(this.FiltersType);
            this.Filters.Location = new System.Drawing.Point(962, 11);
            this.Filters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Filters.Name = "Filters";
            this.Filters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Filters.Size = new System.Drawing.Size(408, 153);
            this.Filters.TabIndex = 5;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filters";
            // 
            // HFLabel
            // 
            this.HFLabel.AutoSize = true;
            this.HFLabel.Location = new System.Drawing.Point(206, 74);
            this.HFLabel.Name = "HFLabel";
            this.HFLabel.Size = new System.Drawing.Size(30, 17);
            this.HFLabel.TabIndex = 6;
            this.HFLabel.Text = "HF:";
            // 
            // LFLabel
            // 
            this.LFLabel.AutoSize = true;
            this.LFLabel.Location = new System.Drawing.Point(6, 74);
            this.LFLabel.Name = "LFLabel";
            this.LFLabel.Size = new System.Drawing.Size(28, 17);
            this.LFLabel.TabIndex = 5;
            this.LFLabel.Text = "LF:";
            // 
            // HFTracker
            // 
            this.HFTracker.Location = new System.Drawing.Point(209, 93);
            this.HFTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HFTracker.Maximum = 140;
            this.HFTracker.Minimum = 11;
            this.HFTracker.Name = "HFTracker";
            this.HFTracker.Size = new System.Drawing.Size(197, 56);
            this.HFTracker.TabIndex = 4;
            this.HFTracker.Value = 11;
            this.HFTracker.Scroll += new System.EventHandler(this.HFTracker_Scroll);
            // 
            // LFTracker
            // 
            this.LFTracker.Location = new System.Drawing.Point(6, 93);
            this.LFTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LFTracker.Name = "LFTracker";
            this.LFTracker.Size = new System.Drawing.Size(197, 56);
            this.LFTracker.TabIndex = 3;
            this.LFTracker.Scroll += new System.EventHandler(this.LFTracker_Scroll);
            // 
            // AmplitudeChart
            // 
            this.AmplitudeChart.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.AmplitudeChart.ChartAreas.Add(chartArea1);
            this.AmplitudeChart.Location = new System.Drawing.Point(704, 334);
            this.AmplitudeChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmplitudeChart.Name = "AmplitudeChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "FFT";
            series1.YValuesPerPoint = 4;
            this.AmplitudeChart.Series.Add(series1);
            this.AmplitudeChart.Size = new System.Drawing.Size(666, 308);
            this.AmplitudeChart.TabIndex = 0;
            this.AmplitudeChart.Text = "AmplitudeChart";
            // 
            // FFTChart
            // 
            this.FFTChart.BackColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.FFTChart.ChartAreas.Add(chartArea2);
            this.FFTChart.Location = new System.Drawing.Point(704, 168);
            this.FFTChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FFTChart.Name = "FFTChart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.Color = System.Drawing.Color.Green;
            series2.Name = "Amplitude";
            series2.YValuesPerPoint = 4;
            this.FFTChart.Series.Add(series2);
            this.FFTChart.Size = new System.Drawing.Size(666, 151);
            this.FFTChart.TabIndex = 0;
            this.FFTChart.Text = "FFTChart";
            // 
            // PhaseChart
            // 
            this.PhaseChart.BackColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.PhaseChart.ChartAreas.Add(chartArea3);
            this.PhaseChart.Location = new System.Drawing.Point(12, 334);
            this.PhaseChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhaseChart.Name = "PhaseChart";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "Phase";
            series3.YValuesPerPoint = 4;
            this.PhaseChart.Series.Add(series3);
            this.PhaseChart.Size = new System.Drawing.Size(686, 308);
            this.PhaseChart.TabIndex = 0;
            this.PhaseChart.Text = "PhaseChart";
            // 
            // FunctionsChart
            // 
            this.FunctionsChart.BackColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.FunctionsChart.ChartAreas.Add(chartArea4);
            this.FunctionsChart.Location = new System.Drawing.Point(12, 11);
            this.FunctionsChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionsChart.Name = "FunctionsChart";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "Source";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Blue;
            series5.Name = "RestoreWithPhase";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Green;
            series6.Name = "RestoreWithoutPhase";
            this.FunctionsChart.Series.Add(series4);
            this.FunctionsChart.Series.Add(series5);
            this.FunctionsChart.Series.Add(series6);
            this.FunctionsChart.Size = new System.Drawing.Size(686, 308);
            this.FunctionsChart.TabIndex = 0;
            this.FunctionsChart.Text = "FunctionsChart";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.AmplitudeChart);
            this.Controls.Add(this.FFTChart);
            this.Controls.Add(this.PhaseChart);
            this.Controls.Add(this.FunctionsChart);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.SignalParameters);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Laba3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SignalParameters.ResumeLayout(false);
            this.SignalParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FTracker)).EndInit();
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HFTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFTChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SignalParameters;
        private System.Windows.Forms.TrackBar FTracker;
        private System.Windows.Forms.ComboBox SignalsType;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.ComboBox FiltersType;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.TrackBar LFTracker;
        private System.Windows.Forms.Label HFLabel;
        private System.Windows.Forms.Label LFLabel;
        private System.Windows.Forms.TrackBar HFTracker;
        private System.Windows.Forms.DataVisualization.Charting.Chart AmplitudeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FFTChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PhaseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionsChart;
    }
}

