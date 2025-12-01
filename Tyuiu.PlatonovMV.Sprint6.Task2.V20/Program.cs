using System;
using System.Windows.Forms;

namespace Tyuiu.PlatonovMV.Sprint6.Task2.V20
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormMain());
        }
    }
}