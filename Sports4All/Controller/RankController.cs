using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    class RankController
    {
        public ICollection<Classification> getTopUsers()
        {

            using (var db = new ModelContext())
            {
                return db.Classifications.Include("userId.Events").OrderBy(c => c.rankClassification).ToList();
            }
            
        }

        public IOrderedEnumerable<UC_RankItems> getTopRecintos()
        {
            var auxQuality = 0;
            var auxPrice = 0;
            var auxRacio = 0;
            ICollection<UC_RankItems> rankParkitems = new HashSet<UC_RankItems>();
            
            using (var db = new ModelContext())
            {
                var allParks = db.Parks.ToList();

                for(int i = 0; i < allParks.Count; i++)
                {
                    auxQuality = auxPrice = 0;
                    var parkName = allParks[i].Name;
                    var howManyReviews = db.Evaluations.Include("Ground").OfType<GroundEvaluation>().Where(e => e.Ground.Park.Name == parkName).ToList();

                    for (int j = 0; j < howManyReviews.Count; j++) // percorro todas as avaliações de parques
                    {
                        auxQuality += howManyReviews[j].Price;
                        auxPrice += howManyReviews[j].Quality;
                    }

                    if (howManyReviews.Count > 0)
                    {
                        auxQuality /= howManyReviews.Count;
                        auxPrice /= howManyReviews.Count;
                        auxRacio = auxQuality / auxPrice;
                        UC_RankItems item = new UC_RankItems();
                        item.Classificacao = auxRacio.ToString();
                        item.Utilizador = parkName;
                        item.PartidasJogadas = auxPrice.ToString();
                        item.Pontos = auxQuality.ToString();
                        rankParkitems.Add(item);
                    }

                }

                var auxRankItems = rankParkitems.OrderByDescending(e => float.Parse(e.Classificacao));
                for (int i = 0; i < auxRankItems.ToList().Count; i++)
                {
                    auxRankItems.ToList()[i].Classificacao = (i + 1).ToString();
                }
                return auxRankItems;
            }   
        }

    }
    
}
