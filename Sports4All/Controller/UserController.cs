using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class UserController
    {
        public string UserId { get; set; }
        public User GetUser(string userId)
        {
            using (var db = new ModelContext())
            {
                var query = db.Users.Find(userId);
                return query;
            }
        }
        public string GetUserEvents(string userId)
        {
            using (var db = new ModelContext())
            {
                var query = db.Users.Find(userId);
                return query.Events.Count.ToString();
            }
        }
        public IDictionary<string,string> GetUserClassification(string userId)
        {
            IDictionary<string, string> userClassifications = new Dictionary<string, string>();
            //using (var db = new ModelContext())
            //{
            //    var query = db.Users.Find(userId);
            //    var userSkill = query.myStats.skillAverage.ToString();
            //    var userFairPlay = query.myStats.fairplayAverage.ToString();
            //    userClassifications.Add("Skill",userSkill);
            //    userClassifications.Add("FairPlay", userFairPlay);
            //    return userClassifications;
            //}
            return null;
        }
    }
}
