using Sports4All.Controller;
using System;

namespace Sports4All
{
    public class EventCreationManager
    {
        private static EventCreationManager _instance;
        private CreateEventController _createEventController { get; set; }
        private Reserve _reserve { get; set; }
        private Event _event { get; set; }

        private EventCreationManager()
        {
            _reserve = new Reserve();
            _createEventController = new CreateEventController();
            _reserve.Price = 0;
            _event = new Event();
        }

        public static EventCreationManager Instance
        {
            get
            {
                if (_instance == null) { _instance = new EventCreationManager(); }

                return _instance;
            }
        }

        public string EventName { get; set; }

        public int SportId { get; set; }

        public int LocationId { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime EventEndDate { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int MaxPlayers { get; set; }

        public void CreateReserve()
        {

        }

        public void CreateEvent()
        {

        }
    }
}
