using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class District
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<County> Counties { get; set; }
    }
}
