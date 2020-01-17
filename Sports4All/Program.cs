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
            /*    using (var db = new ModelContext())
               {

                   var manager = db.Evaluations.OfType<UserEvaluation>().ToList();

                   var manager2 = db.Users.ToList()[0].Evaluations.OfType<UserEvaluation>().ToList();

                          var query = from u in db.Users
                                       select u;
                   //db.SaveChanges();
               }*/



                    Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
