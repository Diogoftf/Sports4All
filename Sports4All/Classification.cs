using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class Classification
    {
        public int idClassification { get; set; }
        public int rankClassification { get; set; }
        public double points { get; set; }
        public double racio { get; set; }
        public double fairplayAverage { get; set; }
        public double skillAverage { get; set; }
        public User userId { get; set; }
    }
}
