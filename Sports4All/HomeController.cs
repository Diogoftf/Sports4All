using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class HomeController
    {
        public List<Sport> getSports()
        {

            using (ModelContext db = new ModelContext())
            {
                return db.Sports.ToList();
            }

        }

        public List<Event> getEventSuggestions(string username)
        {
            using (ModelContext db = new ModelContext())
            {
                var query = db.Users.Where(c => c.Username == username).First();

                foreach (Event a in query.Events)
                {
                    if (a.StartDate > DateTime.Now)
                    {
                        myEvents.Add(a);
                    }
                }

            }

            return;
        }

        public List<Event> getMyEvents(string username)
        {
            List<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var query = db.Users.Where(c => c.Username == username).First();

                foreach (Event a in query.Events)
                {
                    if (a.StartDate > DateTime.Now)
                    {
                        myEvents.Add(a);
                    }
                }

            }

            return myEvents;
            
        }
    }
}
