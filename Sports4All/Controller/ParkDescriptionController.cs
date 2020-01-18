using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class ParkDescriptionController
    {
        public Park GetPark()
        {
            Park park;
            using (var db = new ModelContext())
            {
                var query = db.Parks.Find(1);
                return query;
            }
        }
    }
}
