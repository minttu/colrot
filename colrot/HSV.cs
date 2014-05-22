using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace colrot
{
    class HSV
    {
        private double h;
        private double s;
        private double v;
        private double each_step;
        public HSV(double step)
        {
            this.each_step = step;
            this.h = 0;
            this.s = 1;
            this.v = 1;
        }
        public void Step()
        {
            this.h += each_step;
            this.h = this.h % 360;
        }
        public void Random()
        {
            this.h = new Random().NextDouble() * 360;
        }
        public void SetV(double v)
        {
            this.v = v;
        }
        public void SetS(double s)
        {
            this.s = s;
        }
        public Color ToRGB()
        {
            double r, g, b;
            r = g = b = 0;
            if (s == 0)
            {
                r = g = b = v;
            }
            else
            {
                int i = Convert.ToInt32(Math.Floor(this.h / 60));
                double f, p, q, t;
                f = (h / 60) - i;
                p = v * (1 - s);
                q = v * (1 - s * f);
                t = v * (1 - s * (1 - f));
                switch (i)
                {
                    case 0:
                        r = v;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = v;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = v;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = v;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = v;
                        break;
                    default:
                        r = v;
                        g = p;
                        b = q;
                        break;
                }
            }
            return Color.FromArgb(
                Convert.ToInt32(r * 255),
                Convert.ToInt32(g * 255),
                Convert.ToInt32(b * 255)
            );
        }
        public Bitmap ToBitmap()
        {
            Bitmap res = new Bitmap(1, 1);
            res.SetPixel(0, 0, this.ToRGB());
            return res;
        }
    }
}
