using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Patterns.Observer
{
    public class UserEvaluationObservable : Observable, IUserEvaluation
    {
        private IUserEvaluation Subject { get; }

        internal UserEvaluationObservable(IUserEvaluation aUserEvaluation)
        {
            Subject = aUserEvaluation;
        }

        public User Evaluated 
        {
            get => Subject.Evaluated;
            set { Subject.Evaluated = value; }
        }

        public int FairPlay 
        {
            get => Subject.FairPlay;
            set { Subject.FairPlay = value; }
        }

        public int Skill 
        {
            get => Subject.Skill;
            set { Subject.Skill = value; }
        }

        public string UserId 
        {
            get => Subject.UserId;
            set { Subject.UserId = value; }
        }

        public void UpdateClassification()
        {
            Notify();
        }
    }
}
