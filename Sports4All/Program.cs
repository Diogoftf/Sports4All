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

            //UserController b = new UserController();

            //var c= b.GetUser("rubin0").GetType().GetProperties();
            ////foreach (var prop in c)
            ////{
            ////    Console.WriteLine(prop.Name, prop.GetValue(c, null));
            ////}

            //MyEventsController events = new MyEventsController();

            //events.EventsbyGround("Agua de Pena");
            //events.RetrieveEnrolledUsers(1);
            //events.RetrieveNextEvents("andreMx");
            //events.RetrieveSingleEvent(1);
            //events.RetrieveUserReserves("andreMx");
            //events.VerifyEvaluation(1,"andreMx");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
