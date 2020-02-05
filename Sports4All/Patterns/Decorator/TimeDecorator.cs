using Sports4All.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.Decorator
{
    class TimeDecorator : Decorator
    {
        public TimeDecorator(IPriceEntity ground, int quantidade, double price) : base(ground, quantidade, price)
        {
            this._quantidade = quantidade;
            this._price = price;
        }

        public override double getCost()
        {
            return base.getCost() + this._price * this._quantidade;
        }

    }
}
