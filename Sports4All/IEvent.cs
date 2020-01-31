using System;
using System.Collections.Generic;

namespace Sports4All
{
    public interface IEvent
    {
        DateTime EndDate { get; set; }
        ICollection<Evaluation> Evaluations { get; set; }
        int EventId { get; set; }
        int MaxAge { get; set; }
        int MaxPlayers { get; set; }
        int MinAge { get; set; }
        string Name { get; set; }
        Reserve Reserve { get; set; }
        DateTime StartDate { get; set; }
        ICollection<User> Users { get; set; }
    }
}