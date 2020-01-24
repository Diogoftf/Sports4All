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
            //using (var db = new ModelContext())
            //{
            //    var query = db.Events.Include("Evaluations.Evaluator").ToList().ElementAt(0);
            //    ICollection<Evaluation> evaluations = query.Evaluations.ToList();

            //    foreach(var e in evaluations)
            //    {
            //        Console.WriteLine(e.EvaluationId);
            //        Console.WriteLine(e.EvaluatorId);
            //        Console.WriteLine(e.Event.Name);
            //        Console.WriteLine(e.Evaluator.Username);

            //        var ev = db.Evaluations.Include("Evaluated").OfType<UserEvaluation>().ToList();

            //        foreach (var item in ev)
            //        {
            //            Console.WriteLine(item.UserId);
            //        }
            //        //if(ev != null ) Console.WriteLine(ev.Evaluated.Username);
                    
            //    }



                //var userEvaluation = new UserEvaluation
                //{
                //    Skill = 4,
                //    FairPlay = 1,
                //    UserId = "andreMx",
                //    EvaluatorId = "ruben21",
                //    EventId = 1
                //};
                //db.Evaluations.Add(userEvaluation);
                //db.SaveChanges();
            //}


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
