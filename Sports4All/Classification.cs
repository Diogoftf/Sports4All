using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public abstract class Classification
    {
        public int ClassificationId { get; set; }
        public double Points { get; set; }
        public double Ratio { get; set; }

    }
}
