using System.Collections.Generic;

namespace Sports4All
{
    public class Use
    {
        public int UseId { get; set; }
        public int Quantity { get; set; }
        public ICollection<Reserve> Reserves {get;set;}
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int ReserveId { get; set; }
        public Reserve Reserve { get; set; }

    }
}
