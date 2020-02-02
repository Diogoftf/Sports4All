using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
  public  class Raquete: MaterialDecorator
    {
        public Raquete(IPriceEntity material, int quantidade) : base(material, quantidade)
        {
        }
        public override double getCost()
        {
            return (base.getCost() + 8)*  base._quantidade;
        }

      
    }
}
