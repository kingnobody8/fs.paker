using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paker
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


            Form1 main = new Form1();
            all.InitManager();
            main.Show();
            main.Focus();

            while (main.Looping)
            {
               // all.Update();
                main.Update();
                main.Render();
                Application.DoEvents();
            }

            //all.End();

        }
    }
}
