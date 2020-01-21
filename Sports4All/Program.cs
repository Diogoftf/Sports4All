using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /** DEBUG**/
            // HomeController a = new HomeController();
            //a.pointsCalculator();
            //a.getMyEvents("josefa");
            //a.getEventSuggestions("josefa");

           // RankController a = new RankController();
           // a.getTopRecintos();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
