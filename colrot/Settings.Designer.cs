namespace colrot
{
    partial class Settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.mode = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TrackBar();
            this.saturation = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit_Click);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(48, 160);
            this.delay.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(119, 20);
            this.delay.TabIndex = 7;
            this.delay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.delay.ValueChanged += new System.EventHandler(this.delay_ValueChanged);
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Rotate",
            "Random"});
            this.mode.Location = new System.Drawing.Point(48, 124);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(119, 30);
            this.mode.TabIndex = 5;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delay";
            // 
            // value
            // 
            this.value.LargeChange = 4;
            this.value.Location = new System.Drawing.Point(11, 73);
            this.value.Maximum = 20;
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(156, 45);
            this.value.TabIndex = 3;
            this.value.Value = 20;
            this.value.Scroll += new System.EventHandler(this.value_Scroll);
            // 
            // saturation
            // 
            this.saturation.LargeChange = 4;
            this.saturation.Location = new System.Drawing.Point(11, 25);
            this.saturation.Maximum = 20;
            this.saturation.Name = "saturation";
            this.saturation.Size = new System.Drawing.Size(158, 45);
            this.saturation.TabIndex = 1;
            this.saturation.Value = 20;
            this.saturation.Scroll += new System.EventHandler(this.saturation_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saturation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saturation);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "colrot";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.ListBox mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar value;
        private System.Windows.Forms.TrackBar saturation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

