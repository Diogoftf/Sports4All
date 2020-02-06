using System;
using System.Collections;
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
        public ICollection<int> GetSportsIds()
        {
            ICollection<int> sportsIds = new HashSet<int>();

            using (var db = new ModelContext())
            {
                DateTime currentTime = DateTime.Now;
                var eventsList = db.Events.Include("Reserve").Where(x => x.StartDate > currentTime).ToList();

                foreach (var ev in eventsList)
                {
                    int id = ev.Reserve.SportId;
                    if (!sportsIds.Contains(id))
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
                sport = db.Sports.Include("Picture").FirstOrDefault(s => s.SportId == id);
            }
            return sport;
        }

        public ICollection<Sport> GetSports(ICollection<int> ids)
        {
            ICollection<Sport> sports = new List<Sport>();

            foreach (var id in ids)
            {
                sports.Add(GetSport(id));
            }

            return sports;
        }
    }
}
