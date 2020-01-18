using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Quality { get; set; }
        public virtual Address Adress { get; set; }
        public virtual ICollection<Ground> Grounds { get; set; }
        public ICollection<Material> Materials { get; set; }
        public virtual Picture Picture { get; set; }

    }
}
