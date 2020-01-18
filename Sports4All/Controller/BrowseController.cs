using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sports4All.Controller
{
    public class BrowseController
    {
/*
        public bool GetAllEventsBy()
        {
            using (var db = new ModelContext())
            {





                var query = from r in db.Reserves
                            select r;

                foreach (var item in query)
                {
                    if (item.Username.Equals(username))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
*/
        public ICollection<int> ReturnSportsIds()
        {
            ICollection<int> sportsIds = new HashSet<int>();

            using (var db = new ModelContext())
            {
                var reservesList = db.Reserves.ToList();

                foreach (var reserve in reservesList)
                {
                    int id = reserve.SportId;
                    if(!sportsIds.Contains(id))
                    {
                        sportsIds.Add(id);
                    }
                }
            }

            return sportsIds;
        }


        public Sport GetSport(int id)
        {
            Sport sport;

            using (var db = new ModelContext())
            {
                sport = db.Sports.Find(id);

            }

            return sport;
        }


        /* public ICollection<Sport> ReturnSportsWithEvents()
         {
             ICollection<Sport> sportsWithEvents;
 
             using (var db = new ModelContext())
             {
                 var sportsList = db.Reserves.Include("Event").Include("Sport").ToList();
 
                 var query = from r in sportsList select r;
 
                 foreach (var item in query)
                 {
                     if (!sportsIds.Contains(item.SportId))
                     {
                         sportsIds.Add(item.SportId);
                     }
                 }
             }
         }*/


    }
}
