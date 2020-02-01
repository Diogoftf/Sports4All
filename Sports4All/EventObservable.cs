using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class EventObservable : Observable, IEvent
    {
        private IEvent Subject { get; }

        internal EventObservable(IEvent aEvent)
        {
            Subject = aEvent;
        }

        public DateTime EndDate { 
            get => Subject.EndDate; 
            set { Subject.EndDate = value;} 
        }

        public ICollection<Evaluation> Evaluations { 
            get => Subject?.Evaluations; 
            set { Subject.Evaluations = value; Notify(); }
        }

        public int EventId { 
            get => Subject.EventId;
            set { Subject.EventId = value; }
        }

        public int MaxAge { 
            get => Subject.MaxAge;
            set { Subject.MaxAge = value;}
        }

        public int MaxPlayers { 
            get => Subject.MaxPlayers;
            set { Subject.MaxPlayers = value; }
        }

        public int MinAge { 
            get => Subject.MinAge;
            set { Subject.MinAge = value; }
        }

        public string Name { 
            get => Subject?.Name;
            set { Subject.Name = value; }
        }

        public Reserve Reserve { 
            get => Subject?.Reserve;
            set { Subject.Reserve = value; Notify(); }
        }

        public DateTime StartDate { 
            get => Subject.StartDate;
            set { Subject.StartDate = value; Notify(); }
        }

        public ICollection<User> Users { 
            get => Subject.Users;
            set { Subject.Users = value; Notify(); }
        }
    }
}
