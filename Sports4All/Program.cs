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
            using (ModelContext db = new ModelContext() )
            {
                var query = db.Sports.Include("Picture").First();
                string name = query.Picture.PictureBody;
                MessageBox.Show(name);
            }
            /** DEBUG**/
            //HomeController a = new HomeController();
            //a.getMyEvents("josefa");
            //a.getEventSuggestions("josefa");

           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Authentication());


        }
    }
}
