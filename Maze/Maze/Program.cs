using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    static class Program
    {
        internal static Menu IMenu;
        internal static Game IGame;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMenu = new Menu();

            Application.Run(IMenu);
        }
    }
}
