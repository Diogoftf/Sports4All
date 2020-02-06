using System;
using System.Collections.Generic;

namespace Sports4All
{
    public class Event : ISubject
    {
        public ICollection<IObserver> Observers { get; set; }

        public Event()
        {
            Observers = new List<IObserver>();
        }

        public int EventId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxPlayers { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public string Name { get; set; }
        public virtual Reserve Reserve { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}
