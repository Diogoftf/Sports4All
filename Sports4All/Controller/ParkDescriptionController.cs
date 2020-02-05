using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class ParkDescriptionController
    {
        public int ParkId { get; set; }
        public Park GetPark(int ParkId)
        {
            using (var db = new ModelContext())
            {
                var query = db.Parks.Include("Picture").FirstOrDefault(p => p.ParkId == ParkId);
                return query;
            }
        }

        public ICollection<string> GetParkAvailableSports(int ParkId)
        {
            ICollection<string> availableSports = new HashSet<string>();
            using (var db = new ModelContext())
            {
                var query = db.Parks.Include("Grounds.Sports").First(p => p.ParkId == ParkId);
                foreach (var ground in query.Grounds)
                {
                    foreach (var sport in ground.Sports)
                    {
                        availableSports.Add(sport.Name);
                    }
                }
            }
            return availableSports;
        }

        //public bool IsSubscribed(int id)
        //{
        //    using (var db = new ModelContext())
        //    {
        //        var query = db.Users.Find(AuthProperties.LoggedUser);
        //        if (query.Parks)
        //        {

        //        }
        //    }
        //}
    }
}