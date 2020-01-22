using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
                    .Where(c => c.StartDate <= _todayDate)
                    .Include("Evaluations")
                    .Include("Reserve.Sport")
                    .Include("Reserve.Ground.Park")
                    .Include("Users")
                    .ToList();

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
                    .Where(c => c.StartDate >= _todayDate)
                    .Include("Evaluations")
                    .Include("Reserve.Sport")
                    .Include("Reserve.Ground.Park")
                    .Include("Users")
                    .ToList();
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
                    .Where(c => c.Event != null || c.Event.EndDate >= _todayDate)
                    .Include("Event.Users")
                    .Include("Sport")
                    .Include("Ground.Park").ToList();
                Console.WriteLine("Reservas:" + UserReserves.ToList());
                _userReservesCount = UserReserves.Count;
                return UserReserves;
            }
        }


        public bool VerifyEvaluation(int eventId, string username)
        {
            bool state = false;
            using (var db = new ModelContext())
            {
                var Evaluations = db.Evaluations
                    .Where(c => c.EvaluatorId == username && c.EventId == eventId)
                    .ToList();
                if (Evaluations.Count != 0) state = true;
            }

            return state;
        }

        /*UC_EVentDetails*
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

        public Event RetrieveSingleEvent(int eventId)
        {
            using (var db = new ModelContext())
            {
                var SingleEvent = db.Events
                    .Where(c => c.EventId == eventId)
                    .Include("Reserve")
                    .FirstOrDefault();
                return SingleEvent;
            }
        }
    }
}