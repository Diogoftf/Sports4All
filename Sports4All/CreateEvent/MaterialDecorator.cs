using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All.CreateEvent
{
   public abstract class MaterialDecorator : IPriceEntity
   {

       protected IPriceEntity _material;
       protected int _quantidade;

        public MaterialDecorator(IPriceEntity material, int quantidade)
       {

           this._material = material;
           this._quantidade = quantidade;

        }


        public virtual double getCost()
        {
            return this._material.getCost();
        }
    }
}
