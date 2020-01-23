﻿using System;
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

        public ICollection<string> getMyStats()
        {
            ICollection<string> userStats = new List<string>();

            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Classifications.OfType<UserClassification>().Where(e => e.User.Username == AuthProperties.LoggedUser).First();

                userStats.Add(myStats.User.Events.Count.ToString());
                userStats.Add(myStats.FairplayAverage.ToString());
                userStats.Add(myStats.SkillAverage.ToString());
                userStats.Add(myStats.Ratio.ToString());
                userStats.Add(myStats.Points.ToString());

                return userStats;
            }

        }

        public ICollection<Reserve> getEventSuggestions()
        {
            using (ModelContext db = new ModelContext())
            {

                // Query para dar Sugestões            
                return db.Reserves.Include("User").Include("Ground.Park").Include("Sport").Where(e => e.User.Username != AuthProperties.LoggedUser && e.Event.StartDate > DateTime.Now && (e.Event.Users.Count) < e.Event.MaxPlayers
                    && (e.Ground.Park.Address.CountyId == e.User.CountyId || e.Ground.Park.Address.County.DistrictId == e.User.County.DistrictId
                     && e.Event.Users.Contains(e.User) == false)).ToList();
            }

        }

        public ICollection<Event> getMyEvents()
        {
            ICollection<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var query = db.Reserves.Include("Ground.Park").Include("Sport").Where(c => c.Event.StartDate > DateTime.Now).ToList();
                var whoIam = db.Users.Where(e => e.Username == AuthProperties.LoggedUser).First();

                foreach (Reserve a in query) // todos os eventos que esse user participou (Tanto os que esta inscrito, como reservou)
                {
                    if (a.Event.Users.Contains(whoIam))
                        myEvents.Add(a.Event); //guardo o evento dessa reserva
                }
            }

            return myEvents;

        }

    }
}
