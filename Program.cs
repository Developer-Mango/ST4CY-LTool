using System;
using System.Windows.Forms;

namespace ST4CY_Login_Tool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Copy());
        }
    }
}
