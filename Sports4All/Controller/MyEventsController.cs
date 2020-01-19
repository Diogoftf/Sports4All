using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    public class MyEventsController
    {


        //retorna todos os eventos em que o utilizador participou.
        public void RetrieveUserEvents(string username) { 

            ICollection<Event> userEvents = new Collection<Event>();
            using (var db = new ModelContext())
            {
                var user = db.Users
                    .Where(s=>s.Username == username)
                    .Include("Events")
                    .ToList();
                Console.WriteLine("User:"+ user[0].Username);
                Console.WriteLine("Evento em que participou:" + user[0].Events.ToList()[0].EventId);

                foreach (var ev in user[0].Events)
                {
                    
                }
                
                userEvents = user[0].Events.ToList();

             //   return userEvents.ToList();

            }

        }
    }
}
