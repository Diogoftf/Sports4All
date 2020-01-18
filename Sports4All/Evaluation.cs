using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public abstract class Evaluation
    {
        public int EvaluationId { get; set; }
        public User Evaluator { get; set; }
        public string EvaluatorId { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}
