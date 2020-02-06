using Sports4All.Controller;
using System.Collections.Generic;

namespace Sports4All
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Ground> Grounds { get; set; }
        public ICollection<Material> Materials { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ParkClassification ParkClassification { get; set; }
        public ICollection<ParkEvaluation> ParkEvaluations { get; set; }

    }
}
