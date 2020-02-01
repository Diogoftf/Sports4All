using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Patterns.Observer
{
    public class ParkEvaluationObservable : Observable, IParkEvaluation
    {
        private IParkEvaluation Subject { get; }

        internal ParkEvaluationObservable(IParkEvaluation aParkEvaluation)
        {
            Subject = aParkEvaluation;
        }

        public Park Park 
        {
            get => Subject.Park;
            set { Subject.Park = value; }
        }

        public int ParkId 
        {
            get => Subject.ParkId;
            set { Subject.ParkId = value; }
        }

        public int Price 
        {
            get => Subject.Price;
            set { Subject.Price = value; }
        }

        public int Quality 
        {
            get => Subject.Quality;
            set { Subject.Quality = value; }
        }

        public void UpdateClassification()
        {
            Notify();
        }
    }
}
