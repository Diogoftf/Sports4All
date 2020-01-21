using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

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
            //BrowseParksController b = new BrowseParksController();
            //ICollection<int> list = b.GetReservesCountyIds();
            //ParkDescriptionController b = new ParkDescriptionController();
            //ICollection<string> list = b.GetParkAvailableSports(1);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
