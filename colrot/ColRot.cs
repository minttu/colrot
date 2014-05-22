using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Timers;
using System.Runtime.InteropServices;

namespace colrot
{
    class ColRot
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private HSV hsv;
        private Timer timer;
        private int mode;
        public ColRot()
        {
            this.mode = 0;
            this.hsv = new HSV(5);
            this.timer = new Timer(5000);
            this.timer.Elapsed += timer_Elapsed;
            timer_Elapsed(null, null);
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Run()
        {
            timer.Stop();
            timer_Elapsed(null, null);
            timer.Start();
        }

        public void SetV(double v)
        {
            this.hsv.SetV(v);
        }

        public void SetS(double s)
        {
            this.hsv.SetS(s);
        }

        public void SetInterval(Double interval)
        {
            this.timer.Interval = interval;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (mode == 0)
            {
                this.hsv.Step();
            }
            else
            {
                this.hsv.Random();
            }
            string path = Path.Combine(Path.GetTempPath(), "colrot.bmp");
            Bitmap bitmap = this.hsv.ToBitmap();
            try
            {
                bitmap.Save(path, ImageFormat.Bmp);
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }

            bitmap.Dispose();
            SystemParametersInfo(20, 0, path, 3);
        }

        internal void SetMode(int p)
        {
            this.mode = p;
        }
    }
}
