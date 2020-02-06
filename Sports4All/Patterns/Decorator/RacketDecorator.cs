﻿namespace Sports4All.Decorator
{
  public  class RacketDecorator: Decorator
    {
        public RacketDecorator(IPriceEntity ground, int quantity, double price) : base(ground, quantity, price)
        {
            _quantity = quantity;
            _price = price;
        }

        public override double getCost()
        {
            return base.getCost() + _price * _quantity;
        }

      
    }
}
