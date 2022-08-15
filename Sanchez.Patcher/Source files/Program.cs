using System;
using System.Windows.Forms;

namespace MT2.Patcher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pForm());


        }
    }
}
