using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            using (var db = new ModelContext())
            {
                var park = db.Parks.Find(1);
            }

            /** DEBUG**/
            HomeController a = new HomeController();
            // a.getMyEvents("josefa");
            //a.getEventSuggestions("josefa");

           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Form1());


        }
    }
}
