namespace Laba2
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
            this.Graphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ParametersSelector = new System.Windows.Forms.GroupBox();
            this.PhiValue = new System.Windows.Forms.Label();
            this.KValue = new System.Windows.Forms.Label();
            this.PhiTracker = new System.Windows.Forms.TrackBar();
            this.KTracker = new System.Windows.Forms.TrackBar();
            this.PhiLabel = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graphics)).BeginInit();
            this.ParametersSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhiTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // Graphics
            // 
            this.Graphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graphics.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.Graphics.ChartAreas.Add(chartArea1);
            this.Graphics.Location = new System.Drawing.Point(13, 13);
            this.Graphics.Margin = new System.Windows.Forms.Padding(4);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(612, 280);
            this.Graphics.TabIndex = 0;
            this.Graphics.Text = "chart1";
            // 
            // ParametersSelector
            // 
            this.ParametersSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ParametersSelector.Controls.Add(this.PhiValue);
            this.ParametersSelector.Controls.Add(this.KValue);
            this.ParametersSelector.Controls.Add(this.PhiTracker);
            this.ParametersSelector.Controls.Add(this.KTracker);
            this.ParametersSelector.Controls.Add(this.PhiLabel);
            this.ParametersSelector.Controls.Add(this.KLabel);
            this.ParametersSelector.Location = new System.Drawing.Point(13, 301);
            this.ParametersSelector.Margin = new System.Windows.Forms.Padding(4);
            this.ParametersSelector.Name = "ParametersSelector";
            this.ParametersSelector.Padding = new System.Windows.Forms.Padding(4);
            this.ParametersSelector.Size = new System.Drawing.Size(612, 87);
            this.ParametersSelector.TabIndex = 2;
            this.ParametersSelector.TabStop = false;
            this.ParametersSelector.Text = "Signal parameters";
            // 
            // PhiValue
            // 
            this.PhiValue.AutoSize = true;
            this.PhiValue.Location = new System.Drawing.Point(362, 41);
            this.PhiValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhiValue.Name = "PhiValue";
            this.PhiValue.Size = new System.Drawing.Size(16, 17);
            this.PhiValue.TabIndex = 6;
            this.PhiValue.Text = "0";
            // 
            // KValue
            // 
            this.KValue.AutoSize = true;
            this.KValue.Location = new System.Drawing.Point(9, 41);
            this.KValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KValue.Name = "KValue";
            this.KValue.Size = new System.Drawing.Size(16, 17);
            this.KValue.TabIndex = 5;
            this.KValue.Text = "0";
            // 
            // PhiTracker
            // 
            this.PhiTracker.Location = new System.Drawing.Point(389, 25);
            this.PhiTracker.Margin = new System.Windows.Forms.Padding(4);
            this.PhiTracker.Maximum = 360;
            this.PhiTracker.Name = "PhiTracker";
            this.PhiTracker.Size = new System.Drawing.Size(215, 56);
            this.PhiTracker.TabIndex = 0;
            this.PhiTracker.TickFrequency = 20;
            this.PhiTracker.Scroll += new System.EventHandler(this.Tracker_Scroll);
            // 
            // KTracker
            // 
            this.KTracker.Location = new System.Drawing.Point(28, 25);
            this.KTracker.Margin = new System.Windows.Forms.Padding(4);
            this.KTracker.Maximum = 1024;
            this.KTracker.Name = "KTracker";
            this.KTracker.Size = new System.Drawing.Size(215, 56);
            this.KTracker.TabIndex = 3;
            this.KTracker.TickFrequency = 32;
            this.KTracker.Scroll += new System.EventHandler(this.Tracker_Scroll);
            // 
            // PhiLabel
            // 
            this.PhiLabel.AutoSize = true;
            this.PhiLabel.Location = new System.Drawing.Point(362, 25);
            this.PhiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhiLabel.Name = "PhiLabel";
            this.PhiLabel.Size = new System.Drawing.Size(28, 17);
            this.PhiLabel.TabIndex = 1;
            this.PhiLabel.Text = "Phi";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(9, 25);
            this.KLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(17, 17);
            this.KLabel.TabIndex = 2;
            this.KLabel.Text = "K";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.ParametersSelector);
            this.Controls.Add(this.Graphics);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Laba2";
            ((System.ComponentModel.ISupportInitialize)(this.Graphics)).EndInit();
            this.ParametersSelector.ResumeLayout(false);
            this.ParametersSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhiTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTracker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graphics;
        private System.Windows.Forms.GroupBox ParametersSelector;
        private System.Windows.Forms.Label PhiLabel;
        private System.Windows.Forms.TrackBar PhiTracker;
        private System.Windows.Forms.Label PhiValue;
        private System.Windows.Forms.Label KValue;
        private System.Windows.Forms.TrackBar KTracker;
        private System.Windows.Forms.Label KLabel;
    }
}

