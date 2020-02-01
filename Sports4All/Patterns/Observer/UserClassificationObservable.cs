using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Patterns.Observer
{
    public class UserClassificationObservable : Observable, IUserClassification
    {
        private IUserClassification Subject { get; }

        internal UserClassificationObservable(IUserClassification aUserClassification)
        {
            Subject = aUserClassification;
        }

        public double FairplayAverage
        {
            get => Subject.FairplayAverage;
            set { Subject.FairplayAverage = value; Notify(); }
        }
        public double SkillAverage
        {
            get => Subject.SkillAverage;
            set { Subject.SkillAverage = value; Notify();  }
        }

        public User User
        {
            get => Subject.User;
            set { Subject.User = value; }
        }

        public double Ratio { get; internal set; }
        public double Points { get; internal set; }
    }
}
