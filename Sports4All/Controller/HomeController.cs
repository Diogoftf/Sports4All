﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class HomeController
    {
        public ICollection<Sport> GetSports()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Sports.ToList();
            }

        }
        public ICollection<string> GetMyStats()
        {
            ICollection<string> userStats = new List<string>();

            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Classifications.OfType<UserClassification>().Where(e => e.User.Username.Equals(Session.Instance.LoggedUser)).First();

                userStats.Add(myStats.User.Events.Count.ToString());
                userStats.Add(myStats.FairplayAverage.ToString());
                userStats.Add(myStats.SkillAverage.ToString());
                userStats.Add(myStats.Ratio.ToString());
                userStats.Add(myStats.Points.ToString());

                return userStats;
            }

        }

        public User GetUserLogged(string username)
        {
            using(var db = new ModelContext())
            {
                return db.Users
                    .Include("Picture")
                    .Include("UserClassification")
                    .First(f => f.Username.Equals(username));
            }
        }

        public ICollection<Reserve> GetEventSuggestions()
        {
            using (ModelContext db = new ModelContext())
            {         
                var query = db.Reserves.Include("Event.Users").Include("User").Include("Ground.Park").Include("Sport").Where(e => e.User.Username != Session.Instance.LoggedUser && e.Event.StartDate > DateTime.Now && (e.Event.Users.Count) < e.Event.MaxPlayers
                    && (e.Ground.Park.Address.CountyId == e.User.CountyId || e.Ground.Park.Address.County.DistrictId == e.User.County.DistrictId
                     && e.Event.Users.Contains(e.User) == false)).ToList();

                ICollection<Reserve> listSugestions = new HashSet<Reserve>();
                bool aux = false;

                for(int i = 0; i < query.Count; i++)
                {
                    for(int j = 0; j < query.ToList()[i].Event.Users.Count; j++)
                    {
                        if(query.ToList()[i].Event.Users.ToList()[j].Username == Session.Instance.LoggedUser)
                        {
                            aux = true;
                        }
                    }

                    if (!aux)
                    {
                        listSugestions.Add(query.ToList()[i]);
                    }
                    else
                    {
                        aux = false;
                    }

                }

                return listSugestions;
            }

        }

        public ICollection<Event> getMyEvents()
        {
            ICollection<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var query = db.Reserves.Include("Ground.Park").Include("Sport.Picture").Where(c => c.Event.EndDate > DateTime.Now).OrderBy(c => c.Date).ToList();
                var whoIam = db.Users.Where(e => e.Username.Equals(Session.Instance.LoggedUser)).First();

                foreach (Reserve a in query)
                {
                    for(int i = 0; i < a.Event.Users.ToList().Count; i++)
                    {
                        if(a.Event.Users.ToList()[i].Username.Equals(Session.Instance.LoggedUser))
                        {
                            myEvents.Add(a.Event);
                            break;
                        }
                    }
                }
            }
            return myEvents;

        }

    }
}
