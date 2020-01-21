using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sports4All.Controller
{
    public class MyEventsController
    {
        private readonly DateTime _todayDate = DateTime.Now;
        private ICollection<Event> _userEvents = new Collection<Event>();
        private ICollection<User> User = new Collection<User>(); 
        private int _userCompletedEventsCount { get; set; }
        private int _userNextEventsCount { get; set; }
        private int _userReservesCount { get; set; }

        public ICollection<Event> RetrieveCompletedEvents(string username)
        {
            using (var db = new ModelContext())
            {
                var UserCompletedEvents = db.Events.Where(c => c.Users.Any(i => i.Username == username))
                    .Where(c => c.StartDate <= _todayDate).ToList();

                Console.WriteLine("Completed Eventos:" + UserCompletedEvents.ToList());
                _userCompletedEventsCount = UserCompletedEvents.Count;
                return UserCompletedEvents;
            }
        }
        public ICollection<Event> RetrieveNextEvents(string username)
        {
            using (var db = new ModelContext())
            {
                var UserEvents = db.Events.Where(c => c.Users.Any(i => i.Username == username))
                    .Where(c => c.StartDate >= _todayDate).ToList();
                Console.WriteLine("Proximos Eventos:" + UserEvents.ToList());
                _userNextEventsCount = UserEvents.Count;
                return UserEvents;
            }
        }

        public ICollection<Reserve> RetrieveUserReserves(string username)
        {
            using (var db = new ModelContext())
            {
                var UserReserves = db.Reserves.Where(c => c.User.Username == username)
                    .Where(c => c.Event != null || c.Event.EndDate >= _todayDate).ToList();
                Console.WriteLine("Reservas:" + UserReserves.ToList());
                _userReservesCount = UserReserves.Count;
                return UserReserves;
            }
        }

        /*
         *Função que retorna todos os utilizadores presentes no evento. Argumento:EventID.
         */
        public ICollection<User> RetrieveEnrolledUsers(int eventId)
        {
            using (var db = new ModelContext())
            {
                var EnrolledUsers = db.Users
                    .Where(c => c.Events.Any(i => i.EventId == eventId))
                    .ToList();

                return EnrolledUsers;
            }
        }
    }
}