namespace Laba4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.FunctionsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PhaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AmplitudeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SmoothingType = new System.Windows.Forms.GroupBox();
            this.MedianSmoothing = new System.Windows.Forms.RadioButton();
            this.SlidingSmoothing = new System.Windows.Forms.RadioButton();
            this.ParabolicSmoothing = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeChart)).BeginInit();
            this.SmoothingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionsChart
            // 
            this.FunctionsChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunctionsChart.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.FunctionsChart.ChartAreas.Add(chartArea1);
            this.FunctionsChart.Location = new System.Drawing.Point(13, 13);
            this.FunctionsChart.Margin = new System.Windows.Forms.Padding(4);
            this.FunctionsChart.Name = "FunctionsChart";
            this.FunctionsChart.Size = new System.Drawing.Size(571, 233);
            this.FunctionsChart.TabIndex = 1;
            this.FunctionsChart.Text = "FunctionsChart";
            // 
            // PhaseChart
            // 
            this.PhaseChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhaseChart.BackColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.PhaseChart.ChartAreas.Add(chartArea2);
            this.PhaseChart.Location = new System.Drawing.Point(13, 254);
            this.PhaseChart.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseChart.Name = "PhaseChart";
            this.PhaseChart.Size = new System.Drawing.Size(571, 233);
            this.PhaseChart.TabIndex = 2;
            this.PhaseChart.Text = "PhaseChart";
            // 
            // AmplitudeChart
            // 
            this.AmplitudeChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmplitudeChart.BackColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.AmplitudeChart.ChartAreas.Add(chartArea3);
            this.AmplitudeChart.Location = new System.Drawing.Point(598, 13);
            this.AmplitudeChart.Margin = new System.Windows.Forms.Padding(4);
            this.AmplitudeChart.Name = "AmplitudeChart";
            this.AmplitudeChart.Size = new System.Drawing.Size(571, 233);
            this.AmplitudeChart.TabIndex = 3;
            this.AmplitudeChart.Text = "AmplitudeChart";
            // 
            // SmoothingType
            // 
            this.SmoothingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmoothingType.Controls.Add(this.MedianSmoothing);
            this.SmoothingType.Controls.Add(this.SlidingSmoothing);
            this.SmoothingType.Controls.Add(this.ParabolicSmoothing);
            this.SmoothingType.Location = new System.Drawing.Point(598, 254);
            this.SmoothingType.Margin = new System.Windows.Forms.Padding(4);
            this.SmoothingType.Name = "SmoothingType";
            this.SmoothingType.Padding = new System.Windows.Forms.Padding(4);
            this.SmoothingType.Size = new System.Drawing.Size(571, 230);
            this.SmoothingType.TabIndex = 4;
            this.SmoothingType.TabStop = false;
            this.SmoothingType.Text = "Smoothing type";
            // 
            // MedianSmoothing
            // 
            this.MedianSmoothing.AutoSize = true;
            this.MedianSmoothing.Location = new System.Drawing.Point(8, 172);
            this.MedianSmoothing.Margin = new System.Windows.Forms.Padding(4);
            this.MedianSmoothing.Name = "MedianSmoothing";
            this.MedianSmoothing.Size = new System.Drawing.Size(144, 21);
            this.MedianSmoothing.TabIndex = 2;
            this.MedianSmoothing.TabStop = true;
            this.MedianSmoothing.Text = "Median smoothing";
            this.MedianSmoothing.UseVisualStyleBackColor = true;
            this.MedianSmoothing.CheckedChanged += new System.EventHandler(this.Median_Checked);
            // 
            // SlidingSmoothing
            // 
            this.SlidingSmoothing.AutoSize = true;
            this.SlidingSmoothing.Location = new System.Drawing.Point(8, 126);
            this.SlidingSmoothing.Margin = new System.Windows.Forms.Padding(4);
            this.SlidingSmoothing.Name = "SlidingSmoothing";
            this.SlidingSmoothing.Size = new System.Drawing.Size(140, 21);
            this.SlidingSmoothing.TabIndex = 1;
            this.SlidingSmoothing.TabStop = true;
            this.SlidingSmoothing.Text = "Sliding smoothing";
            this.SlidingSmoothing.UseVisualStyleBackColor = true;
            this.SlidingSmoothing.CheckedChanged += new System.EventHandler(this.Sliding_Checked);
            // 
            // ParabolicSmoothing
            // 
            this.ParabolicSmoothing.AutoSize = true;
            this.ParabolicSmoothing.Checked = true;
            this.ParabolicSmoothing.Location = new System.Drawing.Point(8, 81);
            this.ParabolicSmoothing.Margin = new System.Windows.Forms.Padding(4);
            this.ParabolicSmoothing.Name = "ParabolicSmoothing";
            this.ParabolicSmoothing.Size = new System.Drawing.Size(157, 21);
            this.ParabolicSmoothing.TabIndex = 0;
            this.ParabolicSmoothing.TabStop = true;
            this.ParabolicSmoothing.Text = "Parabolic smoothing";
            this.ParabolicSmoothing.UseVisualStyleBackColor = true;
            this.ParabolicSmoothing.CheckedChanged += new System.EventHandler(this.Parabolic_Checked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1182, 493);
            this.Controls.Add(this.SmoothingType);
            this.Controls.Add(this.AmplitudeChart);
            this.Controls.Add(this.PhaseChart);
            this.Controls.Add(this.FunctionsChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Laba4";
            ((System.ComponentModel.ISupportInitialize)(this.FunctionsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeChart)).EndInit();
            this.SmoothingType.ResumeLayout(false);
            this.SmoothingType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PhaseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AmplitudeChart;
        private System.Windows.Forms.GroupBox SmoothingType;
        private System.Windows.Forms.RadioButton SlidingSmoothing;
        private System.Windows.Forms.RadioButton ParabolicSmoothing;
        private System.Windows.Forms.RadioButton MedianSmoothing;
    }
}

