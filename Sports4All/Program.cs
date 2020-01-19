using System;
using System.Collections;
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
            ICollection<string> countyIds = new HashSet<string>();
            using (var db = new ModelContext())
            {
                var userList = db.Users.Include("County").ToList();
                string name = userList[1].County.Name;

                //foreach (var user in userList)
                //{
                //    string countyId = user.County.Name;
                //    countyIds.Add(countyId);
                    Console.WriteLine(name);
            
            }

            /** DEBUG**/
            //HomeController a = new HomeController();
            //a.getMyEvents("josefa");
            //a.getEventSuggestions("josefa");

            BrowseParksController b = new BrowseParksController();
            ICollection<int> list = b.GetReservesCountyIds();

            foreach (var id in list)
            {
                Console.WriteLine(id);
            }

                Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Form1());


        }
    }
}
