using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class GroundEvaluation : Evaluation
    {
        public int Quality { get; set; }
        public int Price { get; set; }
        public Ground Ground { get; set; }
        public int GroundId { get; set; }

    }
}
