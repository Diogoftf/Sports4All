using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class UserEvaluation : Evaluation, IUserEvaluation
    {
        public int Skill { get; set; }
        public int FairPlay { get; set; }
        public User Evaluated { get; set; }
        public string UserId { get; set; }
    }
}
