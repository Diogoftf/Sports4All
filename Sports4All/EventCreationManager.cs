using Sports4All.Controller;
using Sports4All.Decorator;
using System;

namespace Sports4All
{
    public class EventCreationManager
    {
        private IPriceEntity _priceEntity { get; set; }

        private static EventCreationManager _instance;
        private CreateEventController CreateEventController { get; set; }
        private Reserve _reserve { get; set; }
        private Event Event { get; set; }

        private EventCreationManager()
        {
            _reserve = new Reserve();
            CreateEventController = new CreateEventController();
            _reserve.Price = 0;
            Event = new Event();
        }

        public static EventCreationManager Instance
        {
            get
            {
                if (_instance == null) { _instance = new EventCreationManager(); }

                return _instance;
            }
        }

        public IPriceEntity IPriceEntity { get => _priceEntity; set => _priceEntity = value; }

        public Reserve Reserve { get => _reserve;}

        public string EventName { get; set; }

        public int SportId { get; set; }

        public int LocationId { get; set; }

        public int ParkId { get; set; }

        public DateTime EventStartDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime{ get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int MaxPlayers { get; set; }

        public string AddMaterial { get; set; }

        public void CreateEvent()
        {

        }
    }
}
