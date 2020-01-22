using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class ParkClassification : Classification
    {
        public double QualityAverage { get; set; }
        public double PriceAverage { get; set; }
        public virtual Park Park { get; set; }
    }
}
