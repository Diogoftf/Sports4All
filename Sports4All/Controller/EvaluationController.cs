using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class EvaluationController
    {
        public Park GetEventPark(int eventId)
        {
            using (var db = new ModelContext())
            {
                var queryEvent = db.Events
                    .Include("Reserve.Ground.Park")
                    .FirstOrDefault(x => x.EventId == eventId);

                var eventPark = queryEvent.Reserve.Ground.Park;

                return eventPark;
            }
        }
        public ICollection<User> GetEvaluableUsers(int eventId)
        {
            ICollection<User> usersList;
            using (var db = new ModelContext())
            {   
                
                var queryEvent = db.Events.Include("Users.UserEvaluations").FirstOrDefault();
                usersList = queryEvent.Users;
                return usersList;
            }
        }


        internal void SetUserEvaluation(string playerId, int playerSkill, int playerFairplay, int eventId)
        {
            using (var db = new ModelContext())
            {
                var userEvaluation = new UserEvaluation
                {
                    Skill = playerSkill,
                    FairPlay = playerFairplay,
                    UserId = playerId,
                    EvaluatorId = AuthProperties.LoggedUser,
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
                var parkEvaluation = new ParkEvaluation
                {
                    Quality = parkQuality,
                    Price = parkPrice,
                    ParkId = parkId,
                    EvaluatorId = AuthProperties.LoggedUser,
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
