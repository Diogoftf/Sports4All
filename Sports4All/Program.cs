using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            ImagesController images = new ImagesController();
            ICollection<Picture> imgs = new Collection<Picture>();
            MyEventsController events = new MyEventsController();
            /** DEBUG**/
            //HomeController a = new HomeController(); 
            //a.getMyEvents("josefa");
            //a.getEventSuggestions("josefa");

            //images.InsertImagetoDB("User",4,imgs);
            //images.InsertImagetoDB("Park",3, imgs);
            //images.InsertImagetoDB("Sport",5, imgs);


            //images.DownloadImage(1, "User");
            //images.DownloadImage(2, "User");
            //images.DownloadImage(3, "User");
            //images.DownloadImage(4, "User")
            //;
            //events.RetrieveUserReserves("andreMx");
            //events.RetrieveNextEvents("andreMx");
            //events.RetrieveCompletedEvents("andreMx");
          //  events.RetrieveEnrolledUsers(1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
