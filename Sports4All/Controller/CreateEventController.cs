using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

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

        public Material GetMaterial(string materialName)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Materials.Where(f => f.Name == materialName).First();
            }
        }

        public User WhoAmI(string username)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Users.First(f => f.Username.Equals(username));
            }
        }

        public void createReserve(ICollection<Use> materialUsage, Reserve Reserve, Event Event)
        {
            using (var db = new ModelContext())
            {
                foreach (var material in materialUsage)
                {
                    db.Uses.Add(material);
                }
                db.Reserves.Add(Reserve);
                db.Events.Add(Event);
                db.SaveChanges();
            }
        }

        public void RetrieveMaterial(FlowLayoutPanel flp, ICollection<Use> materialUsage, Reserve Reserve)
        {
            using (var db = new ModelContext())
            {
                var WhoAmI = db.Users.First(f => f.Username.Equals(Session.Instance.LoggedUser));

                for (var i = 0; i < flp.Controls.Count; i++)
                {
                    var item = flp.Controls[i] as UC_MaterialItem;
                    if (item.Quantidade > 0)
                    {
                        var use = new Use();
                        var query = db.Materials.Where(f => f.Name == item.Material).First();
                        use.MaterialId = query.MaterialId;
                        use.Quantity = item.Quantidade;
                        use.Reserve = Reserve;
                        materialUsage.Add(use);
                    }
                }
            }
        }
        public void InsertDataReserve(Reserve Reserve, Event Event, ICollection<Use> materialUsage)
        {
            Reserve.Date = DateTime.Now;
            Reserve.Price = 10;
            Reserve.UserId = Session.Instance.LoggedUser;
            Reserve.Event = Event;

            if (materialUsage.Count > 0) Reserve.Uses = materialUsage;
        }

        public void InsertUserNewEvent(Event Event)
        {
            using (var context = new ModelContext())
            {

                var events = context.Events.Find(Event.EventId);
                var users = context.Users.Find(Session.Instance.LoggedUser);

                context.Entry(events).Collection("Users").Load();
                events.Users.Add(users);
                context.SaveChanges();
            }
        }

        public int getIdReserve()
        {
            using (ModelContext db = new ModelContext())
            {
                return ++db.Reserves.OrderByDescending(e => e.ReserveId).ToList()[0].ReserveId;
            }
        }

        public int getIdEvent()
        {
            using (ModelContext db = new ModelContext())
            {
                return ++db.Events.OrderByDescending(e => e.EventId).ToList()[0].EventId;
            }
        }
    }
}
