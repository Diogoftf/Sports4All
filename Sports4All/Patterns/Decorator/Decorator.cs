namespace Sports4All.Decorator
{
    public abstract class Decorator : IPriceEntity
   {
        public int _quantity;
        public double _price = 0.0;
        private IPriceEntity _ground;
        private int quantity;

        protected Decorator(IPriceEntity ground, int quantity, double price)
        {
            _ground = ground;
            this.quantity = quantity;
            _price = price;
        }

        public virtual double getCost()
        {
            return _ground.getCost();
        }
    }
}
