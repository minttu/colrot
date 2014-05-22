using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colrot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings settings = new Settings();
            NotifyIcon icon = new NotifyIcon();
            icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            icon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Show", (s, e) => {settings.RealShow();}),
                new MenuItem("Exit", (s, e) => { Application.Exit(); })
            });
            icon.Click += delegate
            {
                settings.RealShow();
            };
            icon.Visible = true;
            Application.Run(settings);
        }
    }
}
