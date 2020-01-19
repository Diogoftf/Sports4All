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

        public List<Reserve> getEventSuggestions(string username)
        {
            //events -> todos os eventos que o user participou
            // reservs -> todos os eventos que o user criou

            using (ModelContext db = new ModelContext())
            {
                var user = db.Users.Where(c => c.Username == username).First();

                // var userReserves1 = db.Reserves.Where(e => e.UserId != username).ToList();

                // Pego todas as reservas que nao foram realizadas pelo user especifico                //Todos os players + quem fez a reserva
                return db.Reserves.Where(e => e.UserId != username && e.Event.StartDate > DateTime.Now && (e.Event.Users.Count + 1) < e.Event.MaxPlayers
                    && (e.Ground.Park.Adress.CountyId == user.CountyId || e.Ground.Park.Adress.County.DistrictId == user.County.DistrictId
                     && e.Event.Users.Contains(user))).ToList();
            }

        }

        public List<Event> getMyEvents(string username)
        {
            List<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                //var queryMyReserves = db.Users.Where(c => c.Username == username).First().Reserves //Filtro pelas reservas realizadas por o user
                //    .Where(e => e.Event.StartDate > DateTime.Now).ToList();

                //var queryMyEvents = db.Users.Where(c => c.Username == username).First().Events //Filtro pelos eventos em que o user vai participar
                //    .Where(e => e.StartDate > DateTime.Now).ToList();

                var queryMyReserves = db.Users.Where(c => c.Username == username).First().Reserves //Filtro pelas reservas realizadas por o user
    .ToList();

                var queryMyEvents = db.Users.Where(c => c.Username == username).First().Events //Filtro pelos eventos em que o user vai participar
                    .ToList();

                foreach (Reserve a in queryMyReserves) // todos os eventos que esse user participou
                {
                    myEvents.Add(a.Event); //guardo o evento dessa reserva
                }

                // Verificador para garantir que nao há eventos repetidos
                bool verificador = false;
                for (int i = 0; i < queryMyEvents.Count; i++)
                {
                    for (int j = 0; j < myEvents.Count; j++)
                    {
                        if (queryMyEvents[i].EventId == myEvents[j].EventId)
                            verificador = true;
                    }

                    if (!verificador)
                    {
                        myEvents.Add(queryMyEvents[i]);
                        verificador = false;
                    }

                }

            }

            return myEvents;
            
        }
    }
}
