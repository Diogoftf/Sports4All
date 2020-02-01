using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class ParkEvaluation : Evaluation, IParkEvaluation
    {
        public int Quality { get; set; }
        public int Price { get; set; }
        public Park Park { get; set; }
        public int ParkId { get; set; }

    }
}
