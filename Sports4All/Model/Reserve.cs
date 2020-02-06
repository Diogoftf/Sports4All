using System;
using System.Collections.Generic;

namespace Sports4All
{
   public class Reserve
   {
        public int ReserveId { get; set; }

        public DateTime Date { get; set; }
        public double Price { get; set; }
        public string UserId { get; set; }
        public int SportId { get; set; }
        public int GroundId { get; set; }
        public Sport Sport { get; set; }
        public virtual User User { get; set; }
        public Ground Ground { get; set; }
        public virtual Event Event { get; set; }
        public ICollection<Use> Uses { get; set; }

    }
}
