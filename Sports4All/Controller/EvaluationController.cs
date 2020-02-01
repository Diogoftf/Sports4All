using System.Collections.Generic;
using System.Linq;

namespace Sports4All.Controller
{
    class EvaluationController
    {
        //private List<IObserver> _observers = new List<IObserver>();

        public Park GetEventPark(int eventId)
        {
            using (var db = new ModelContext())
            {
                var queryEvent = db.Events
                    .Include("Reserve.Ground.Park.Picture")
                    .FirstOrDefault(x => x.EventId == eventId);

                var eventPark = queryEvent.Reserve.Ground.Park;

                return eventPark;
            }
        }

        public Event GetEvent(int eventId)
        {
            using (var db = new ModelContext())
            {
                var queryEvent = db.Events
                    .FirstOrDefault(x => x.EventId == eventId);

                return queryEvent;
            }
        }

        public User GetUser(string userId)
        {
            using (var db = new ModelContext())
            {
                var queryUser = db.Users.FirstOrDefault(x => x.Username.Equals(userId));

                return queryUser;
            }
        }

       
        public ICollection<User> GetEvaluableUsers(int eventId)
        {
            ICollection<User> usersList;

            using (var db = new ModelContext())
            {
                var loggedUser = Session.Instance.LoggedUser;

                var queryEvent = db.Events.Include("Users.UserEvaluations").FirstOrDefault( x => x.EventId == eventId);
                usersList = queryEvent.Users;

                foreach(var user in usersList)
                {
                    if(user.Username.Equals(loggedUser)) { usersList.Remove(user); break; }
                }

                return usersList;
            }
        }


        internal void SetUserEvaluation(string playerId, int playerSkill, int playerFairplay, int eventId)
        {
            using (var db = new ModelContext())
            {
                var query = db.Evaluations;
                int evaluationId = 0;

                if (query.Any())
                {
                    var biggestEvaluationId = query.OrderByDescending(u => u.EvaluationId).FirstOrDefault().EvaluationId;
                    evaluationId = biggestEvaluationId + 1;
                }

                var userEvaluation = new UserEvaluation
                {
                    EvaluationId = evaluationId,
                    Skill = playerSkill,
                    FairPlay = playerFairplay,
                    UserId = playerId,
                    EvaluatorId = Session.Instance.LoggedUser,
                    EventId = eventId
                };
                db.Evaluations.Add(userEvaluation);
                db.SaveChanges();
            }
        }

        internal void SetParkEvaluation(int parkId, int parkQuality, int parkPrice, int eventId)
        {
            using (var db = new ModelContext())
            {

                var query = db.Evaluations;
                int evaluationId = 0;

                if(query.Any())
                {
                    var biggestEvaluationId = query.OrderByDescending(u => u.EvaluationId).FirstOrDefault().EvaluationId;
                    evaluationId = biggestEvaluationId + 1;
                }

                var parkEvaluation = new ParkEvaluation
                {
                    EvaluationId = evaluationId,
                    Quality = parkQuality,
                    Price = parkPrice,
                    ParkId = parkId,
                    EvaluatorId = Session.Instance.LoggedUser,
                    EventId = eventId
                };
                db.Evaluations.Add(parkEvaluation);
                db.SaveChanges();
            }
        }

        //public  GetUserEvaluation(int eventId)
        //{
        //    ICollection<User> usersList;
        //    using (var db = new ModelContext())
        //    {

        //        var queryEvent = db.Events.Include("Users.Evaluation").FirstOrDefault();
        //        usersList = queryEvent.Users;
        //        return usersList;
        //    }
        //}
    }
}
