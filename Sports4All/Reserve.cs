using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Reserve
   {
        public int ReserveId { get; set; }

        public double Price { get; set; }
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public virtual Sport Sport { get; set; }
        public int SportId { get; set; }
        public virtual Ground Ground { get; set; }
        public int GroundId { get; set; }
        public virtual Event Event { get; set; }


   }
}
