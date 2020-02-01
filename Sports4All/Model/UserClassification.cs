using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class UserClassification : Classification, IUserClassification
    {
        public double FairplayAverage { get; set; }
        public double SkillAverage { get; set; }
        public virtual User User { get; set; }
    }
}
