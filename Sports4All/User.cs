using Sports4All.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class User : IObserver
    {
        private readonly RankController rankController;
        public string Username { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public int PhoneNumber { get; set; }
        public int CountyId { get; set; }
        public int PictureId { get; set; }
        public County County { get; set; }
        public virtual UserClassification UserClassification { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<UserEvaluation> UserEvaluations { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual Picture Picture { get; set; }
        public User()
        {
            rankController = new RankController();
        }

        public void Update(ISubject subject)
        {
            rankController.UpdateUserClassification(Username);
        }
    }
}
