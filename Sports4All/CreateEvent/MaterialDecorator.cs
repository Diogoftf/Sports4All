using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
   public abstract class MaterialDecorator : IPriceEntity
   {
        public int _quantidade;
        public double _price = 0.0;
        private IPriceEntity _ground;
        private int quantidade;

        protected MaterialDecorator(IPriceEntity ground, int quantidade)
        {
            this._ground = ground;
            this.quantidade = quantidade;
        }

        public virtual double getCost()
        {
            return this._ground.getCost();
        }
    }
}
