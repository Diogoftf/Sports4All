using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
  public class Event
    {
        public int EventId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxPlayers { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public string Name { get; set; }
        public virtual Reserve Reserve { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
    }
}
