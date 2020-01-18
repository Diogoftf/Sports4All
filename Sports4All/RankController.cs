using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class RankController
    {
        public List<User> getUsersTop10(string username)
        {
            List<User> top10users = new List<User>();
           // top10users[0].
            using (var db = new ModelContext())
            {
                // Pego todos os users que ja fizeram pelo menos 1 reserva ou participaram em pelo menos 1 evento
                var query = db.Users.Where(e => e.Events.Count > 0 || e.Reserves.Count > 0).ToList();

                foreach (User e in query)
                {
                    if (e.Reserves.Count > 0)
                    { 
                        
                    }
                
                }
                // Por corrigir a query
              //  var query = db.Reserves.ToList()[0].Event.Evaluations.OfType<UserEvaluation>().ToList()[0].

            }
            return top10users;
        }
    }
}
