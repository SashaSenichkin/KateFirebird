using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KateFirebird
{
    static class Program
    {
        public static IDataProvider Data;
        public static Form DirPanel ;
        public static Form AdminPanel;
        public static Form StartWin;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Data = new RandomRata();
            Data = new FirebaseADO();
            DirPanel = new DirectorPanel();
             AdminPanel = new AdminPanel();
             StartWin = new StartWin();
            Application.Run(StartWin);
        }
    }
}
