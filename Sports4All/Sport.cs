using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Sport
    {
        public int SportId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ground> Grounds { get; set; }
        public ICollection<Reserve> Reserves { get; set; }
        public virtual Picture Picture { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
