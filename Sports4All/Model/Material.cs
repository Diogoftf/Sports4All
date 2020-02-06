using System.Collections.Generic;

namespace Sports4All
{
  public  class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int Available { get; set; }
        public double Price { get; set; }
        public int SportId { get; set; }
        public int ParkId { get; set; }
        public  Park Park { get; set; }
        public  Sport Sport { get; set; }
        public ICollection<Use> Uses { get; set; }

    }
}
