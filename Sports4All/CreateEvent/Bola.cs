using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
  public  class Bola : MaterialDecorator
    {
        public Bola(IPriceEntity material, int quantidade) : base(material, quantidade)
        {

        }

        public override double getCost()
        {

            return (base.getCost() + 6) * base._quantidade;
        }

    }
}
