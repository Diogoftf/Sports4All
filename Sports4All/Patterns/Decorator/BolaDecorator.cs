using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Decorator
{
  public  class BolaDecorator : Decorator
    {
        public BolaDecorator(IPriceEntity ground, int quantidade, double price) : base(ground, quantidade, price)
        {
            this._quantidade = quantidade;
            this._price = price;
        }

        public override double getCost()
        {
            return (base.getCost() + this._price) * this._quantidade;
        }

    }
}
