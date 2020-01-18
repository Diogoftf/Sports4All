using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class County
    {
        public int CountyId { get; set; }
        public string Name { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<User> Users { get; set; }
        public District District { get; set; }
        public int DistrictId { get; set; }
    }
}
