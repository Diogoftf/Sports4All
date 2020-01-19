using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Controller
{
    class BrowseParksController
    {
        public ICollection<int> GetReservesCountyIds()
        {
            ICollection<int> countyIds = new HashSet<int>();
            using (var db = new ModelContext())
            {
                var reservesList = db.Reserves.ToList();

                foreach (var reserve in reservesList)
                {
                    int countyId = reserve.Ground.Park.Adress.CountyId;
                    countyIds.Add(countyId);
                }
            }
            return countyIds;
        }
    }
}
