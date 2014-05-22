using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colrot
{
    public partial class Settings : Form
    {
        private ColRot colRot;
        public Settings()
        {
            InitializeComponent();
            this.mode.SelectedIndex = 0;

            colRot = new ColRot();
            Thread thread = new Thread(colRot.Start);

            delay_ValueChanged(null, null);
            saturation_Scroll(null, null);
            value_Scroll(null, null);
            this.FormClosing += Settings_FormClosing;
            thread.Start();
        }

        void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        internal void RealShow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                colRot.SetMode(this.mode.SelectedIndex);
                colRot.Run();
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void delay_ValueChanged(object sender, EventArgs e)
        {
            colRot.SetInterval(Convert.ToDouble(this.delay.Value) * 1000);
        }

        private void saturation_Scroll(object sender, EventArgs e)
        {
            colRot.SetS(Convert.ToDouble(this.saturation.Value) / Convert.ToDouble(this.saturation.Maximum));
            colRot.Run();
        }

        private void value_Scroll(object sender, EventArgs e)
        {
            colRot.SetV(Convert.ToDouble(this.value.Value) / Convert.ToDouble(this.value.Maximum));
            colRot.Run();
        }


    }
}
