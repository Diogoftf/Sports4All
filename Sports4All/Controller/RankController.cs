using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        // !!!corrigir!!!!
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
