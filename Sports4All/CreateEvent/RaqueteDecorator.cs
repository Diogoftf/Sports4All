using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
  public  class RaqueteDecorator: MaterialDecorator
    {
        public RaqueteDecorator(IPriceEntity material, int quantidade) : base(material, quantidade)
        {
            this._price = 8;
            this._quantidade = quantidade;
        }

        public override double getCost()
        {
            return (base.getCost() + this._price) * this._quantidade;
        }

      
    }
}
