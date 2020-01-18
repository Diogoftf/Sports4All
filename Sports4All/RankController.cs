using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class RankController
    {
        public List<Classification> getTopUsers()
        {

            using (var db = new ModelContext())
            {
                return db.Classifications.OrderByDescending(c => c.rankClassification).ToList();
            }
            
        }

        public void getTopRecintos()
        {
            List<GroundEvaluation> teste = new List<GroundEvaluation>();
            GroundEvaluation a = new GroundEvaluation();
         //   a.
            using (var db = new ModelContext())
            {
                var query = db.Evaluations.OfType<GroundEvaluation>().ToList();
            }

        }
    }
}
