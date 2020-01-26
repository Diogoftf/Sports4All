using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Park : IObserver
    {
        private readonly RankController rankController;
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }  
        public virtual Address Address { get; set; }
        public virtual ICollection<Ground> Grounds { get; set; }
        public ICollection<Material> Materials { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ParkClassification ParkClassification { get; set; }
        public ICollection<ParkEvaluation> ParkEvaluations { get; set; }

        public Park()
        {
            rankController = new RankController();
        }

        public void Update(ISubject subject)
        {
            rankController.UpdateParkClassification(ParkId);
        }
    }
}
