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

        public List<Reserve> getEventSuggestions(string username)
        {
            //events -> todos os eventos que o user participou
            // reservs -> todos os eventos que o user criou
            var sportsPerformed = new List<string>();
            List<Reserve> SuggestionsEvents = new List<Reserve>();
            using (ModelContext db = new ModelContext())
            {
                var user = db.Users.Where(c => c.Username == username).First();
                var userEvents = user.Events.ToList(); //tenho todos os eventos que ele participou
                var userReserves = user.Reserves.ToList();

                if ((userEvents.Count + userReserves.Count) > 0) // Se ja participou em algum evento
                {
                    /*   for (int i = 0; i < userEvents.Count; i++)
                       {
                           sportsPerformed.Add(userEvents[i].Reserve.Sport.Name); // tenho todos os eventos em que o user participou

                       }

                       for (int i = 0; i < userReserves.Count; i++)
                       {
                           if (!sportsPerformed.Contains(userReserves[i].Sport.Name))
                           {
                               sportsPerformed.Add(userReserves[i].Sport.Name); // tenho todas as reservas do user especifico
                           }

                       }

                    && (e.UserId != username || !e.Event.Users.Contains(username)) && (e.User.County.CountyId == e.Ground.Park.Adress.CountyId || e.User.County.DistrictId == e.Ground.Park.Adress.County.DistrictId
                       */
                    var allReservesandEvents = db.Events.Where(e => e.StartDate > DateTime.Now ).Take(3).ToList();

                    for (int i = 0; i < allReservesandEvents.Count; i++)
                    {
                      //  SuggestionsEvents.Add(allReservesandEvents[i]); // tenho todas as reservas do user especifico

                    }

                }
                else
                {
                    var allReservesandEvents = db.Reserves.Where(e => e.Event.StartDate > DateTime.Now && (e.User.County.CountyId == e.Ground.Park.Adress.CountyId || e.User.County.DistrictId == e.Ground.Park.Adress.County.DistrictId)).Take(3).ToList();

                    for (int i = 0; i < allReservesandEvents.Count; i++)
                    {
                        SuggestionsEvents.Add(allReservesandEvents[i]); // tenho todas as reservas do user especifico

                    }

                }
                 // se nao tiver no concelho, vai ao distrito, se nao tiver no distrito incentiva o user a criar
                
            }

            return SuggestionsEvents;
        }

        public List<Event> getMyEvents(string username)
        {
            List<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var query = db.Users.Where(c => c.Username == username).First();

                foreach (Event a in query.Events) // todos os eventos que esse user participou
                {
                    if (a.StartDate > DateTime.Now)
                    {
                        myEvents.Add(a);
                    }
                }

                foreach (Reserve a in query.Reserves)
                {
                    if (a.Event.StartDate > DateTime.Now)
                    {
                        if(!myEvents.Contains(a.Event))
                            myEvents.Add(a.Event);
                    }
                }

            }

            return myEvents;
            
        }
    }
}
