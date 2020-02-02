using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class CreateEventController
    {
        public ICollection<Park> GetAllParks()
        {
            using (ModelContext context = new ModelContext())
            {
                return context.Parks.ToList();
            }
        }

        public Park GetPark(string parkName)
        {
            using (ModelContext db = new ModelContext())
            {
                var Park = db.Parks
                    .Include("Address.County")
                    .Include("Grounds.Sports")
                    .Include("Materials")
                    .Where(f => f.Name.Equals(parkName)).FirstOrDefault();

                return Park;
            }
        }

        public Sport GetSport(string sportName)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Sports.Where(f => f.Name.Equals(sportName)).First();

            }
        }

        public ICollection<Ground> GetGrounds(string parkName)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Grounds.Include("Sports").Where(f => f.Park.Name.Equals(parkName)).ToList();
            }
        }

        public ICollection<Material> GetMaterialsFromSport(int sportId, int parkId)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Materials.Where(f => f.Sport.SportId == sportId && f.ParkId == parkId).ToList();
            }
        }
    }
}
