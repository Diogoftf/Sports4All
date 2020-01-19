using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class ParkDescriptionController
    {
        public Park GetPark(int id)
        {
            using (var db = new ModelContext())
            {
                var query = db.Parks.Find(id);
                return query;
            }
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
