using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
  public  class BolaDecorator : MaterialDecorator
    {
        public BolaDecorator(IPriceEntity ground, int quantidade) : base(ground, quantidade)
        {
            this._price = 6;
            this._quantidade = quantidade;
        }

        public override double getCost()
        {
            return (base.getCost() + this._price) * this._quantidade;
        }

    }
}
