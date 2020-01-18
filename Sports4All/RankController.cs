using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class RankController
    {
        public List<User> getUsersTop10(string email, string password, string username, string age, string cellphone)
        {
            List<User> top10users = new List<User>();

            using (var db = new ModelContext())
            {
                // Por corrigir a query
                var query = db.Users.ToList();

            }
            return top10users;
        }
    }
}
