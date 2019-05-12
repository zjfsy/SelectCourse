using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectCourse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogSign sign = new DialogSign("root", "123456");
            if (sign.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Window());
            }
        }
    }
}
