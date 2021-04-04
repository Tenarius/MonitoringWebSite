using System;
using System.Windows.Forms;

namespace Monitoring
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View view = new();
            Presenter presenter = new(view);
            Application.Run(view);
        }
    }
}
