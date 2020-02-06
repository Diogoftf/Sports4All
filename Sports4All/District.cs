using System.Collections.Generic;

namespace Sports4All
{
    public class District
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public ICollection<County> Counties { get; set; }
    }
}
