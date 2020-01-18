using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ReturnSports()
        {
            using (var db = new ModelContext())
            {
                var reservesList = db.Reserves.ToList();

                foreach (var reserve in reservesList)
                {
                    Console.WriteLine("\t" + reserve.Sport);
                }
            }
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
