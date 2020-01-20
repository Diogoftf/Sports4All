using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class HomeController
    {
        public ICollection<Sport> getSports()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Sports.ToList();
            }

        }

        public List<string> getMyStats(string username)
        {
            List<string> userStats = new List<string>();
            using (ModelContext db = new ModelContext())
            {
                var eventsPlayed = db.Users.Where(e => e.Username == AuthProperties.LoggedUser).First().Events.ToList().Count();
                var reservesMade = db.Users.Where(e => e.Username == AuthProperties.LoggedUser).First().Reserves.ToList().Count();
                var matchesPlayed = reservesMade + eventsPlayed;
                
                var query = db.Evaluations.OfType<UserEvaluation>().Where(e => e.Evaluated.Username == AuthProperties.LoggedUser).ToList();
                double fairplayResult = 0;
                double skillResult = 0;
                double racio = 0;

                foreach (UserEvaluation e in query)
                {
                    fairplayResult += e.FairPlay;
                    skillResult += e.Skill;
                }

                fairplayResult /= query.Count;
                skillResult /= query.Count;
                racio = fairplayResult / skillResult;

                double points = fairplayResult * Points._fairplay_Height + skillResult * Points._skill_Height + eventsPlayed * Points._eventPerformed_Height
                    + reservesMade * Points._reservePerformed_Height;

                userStats.Add(matchesPlayed.ToString());
                userStats.Add(fairplayResult.ToString());
                userStats.Add(skillResult.ToString());
                userStats.Add(racio.ToString());
                userStats.Add(points.ToString());
                return userStats;
            }
        }

        public ICollection<Reserve> getEventSuggestions(string username)
        {
            //events -> todos os eventos que o user participou
            // reservs -> todos os eventos que o user criou

            using (ModelContext db = new ModelContext())
            {

                // Query para dar Sugestões            
                return db.Reserves.Include("User").Include("Ground.Park").Include("Sport").Where(e => e.User.Username != username && e.Event.StartDate > DateTime.Now && (e.Event.Users.Count) < e.Event.MaxPlayers
                    && (e.Ground.Park.Adress.CountyId == e.User.CountyId || e.Ground.Park.Adress.County.DistrictId == e.User.County.DistrictId
                     && e.Event.Users.Contains(e.User) == false)).ToList();
            }

        }

        public ICollection<Event> getMyEvents(string username)
        {
            ICollection<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var teste = db.Reserves.Include("Ground.Park").Include("Sport").Where(c => c.Event.StartDate > DateTime.Now).ToList();
                var whoIam = db.Users.Where(e => e.Username == username).First();

                foreach (Reserve a in teste) // todos os eventos que esse user participou (Tanto os que esta inscrito, como reservou)
                 {
                    if(a.Event.Users.Contains(whoIam)) 
                        myEvents.Add(a.Event); //guardo o evento dessa reserva
                 }
            }

            return myEvents;
            
        }
    }
}
