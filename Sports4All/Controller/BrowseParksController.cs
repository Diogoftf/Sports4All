using System.Collections.Generic;
using System.Linq;

namespace Sports4All.Controller
{
    class BrowseParksController
    {
        //a funcionar, retorna os Ids dos concelhos que têm reservas| tanto faço isto com ids como com names, é ver o que preferes
        public ICollection<int> GetReservesCountyIds()
        {
            ICollection<int> countyIds = new HashSet<int>();
            using (var db = new ModelContext())
            {
                var reservesList = db.Reserves.Include("Ground").ToList();

                foreach (var reserve in reservesList)
                {
                    int countyId = reserve.Ground.Park.Address.CountyId;
                    countyIds.Add(countyId);
                }
            }
            return countyIds;
        }

        public IDictionary<int, string> GetLocationsDictionary(ICollection<int> countyIds)
        {
            IDictionary<int, string> locations = new Dictionary<int, string>();

            using (var db = new ModelContext())
            {
                var countyList = db.Counties.ToList();

                foreach (var county in countyList)
                {
                    if (countyIds.Contains(county.CountyId))
                    {
                        var countyId = county.CountyId;
                        var countyName = county.Name;
                        locations.Add(countyId, countyName);
                    }
                }
            }

            return locations;
        }

        public ICollection<Park> GetParksAscending(bool value, int idLocation)
        {
            List<Park> parkList;

            using (var db = new ModelContext())
            {
                if (idLocation == 0)
                {
                    parkList = value
                        ? db.Parks
                        .Include("Picture")
                        .OrderBy(x => x.ParkClassification.QualityAverage).ToList()
                        : db.Parks
                        .Include("Picture")
                        .OrderByDescending(x => x.ParkClassification.QualityAverage).ToList();
                }
                
                else
                {
                    parkList = value ? db.Parks
                            .Include("Picture")
                            .Where(a => a.Address.CountyId == idLocation)
                            .OrderBy(x => x.ParkClassification.QualityAverage).ToList()
                        : db.Parks
                            .Include("Picture")
                            .Where(a => a.Address.CountyId == idLocation)
                            .OrderByDescending(x => x.ParkClassification.QualityAverage).ToList();
                }
            }
            return parkList;
        }
        public ParkClassification GetParkClassification(int id)
        {
            ParkClassification classification;

            using (var db = new ModelContext())
            {
                var classifications = db.Classifications.Include("Park");
                classification = classifications.OfType<ParkClassification>().Where(x => x.Park.ParkId == id).FirstOrDefault();
            }
            return classification;
        }
    }
}