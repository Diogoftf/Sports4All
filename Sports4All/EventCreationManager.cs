using Sports4All.Controller;
using Sports4All.Decorator;
using System;
using System.Collections.Generic;

namespace Sports4All
{
    public class EventCreationManager
    {
        List<UC_MaterialItem> _materialItems;
        private IPriceEntity _priceEntity { get; set; }

        private static EventCreationManager _instance;
        private CreateEventController _createEventController;
        private Reserve _reserve { get; set; }
        private Event Event { get; set; }

        private EventCreationManager()
        {
            _reserve = new Reserve();
            _createEventController = new CreateEventController();
            _reserve.Price = 0;
            Event = new Event();
            _materialItems = new List<UC_MaterialItem>();
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

        public Reserve Reserve { get => _reserve; }

        public string EventName { get; set; }

        public int SportId { get; set; }

        public int LocationId { get; set; }

        public int ParkId { get; set; }

        public DateTime EventStartDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int MaxPlayers { get; set; }

        public string AddMaterial { get; set; }

        public void CreateEvent()
        {
            ICollection<Use> materialUsage = new HashSet<Use>();

            _createEventController.RetrieveMaterial(_materialItems, materialUsage, _reserve);
            _createEventController.InsertDataReserve(_reserve, Event, materialUsage);
            _reserve.Price = _priceEntity.getCost();

            Event.Name = EventName;
            Event.StartDate = EventStartDate.Date + EventStartTime.TimeOfDay;
            Event.EndDate = EventStartDate.Date + EventEndTime.TimeOfDay;

            Event.MinAge = MinAge;
            Event.MaxAge = MaxAge;
            Event.MaxPlayers = MaxPlayers;

            _createEventController.CreateReserve(materialUsage, _reserve, Event);
            _createEventController.InsertUserNewEvent(Event);
        }

        public void SetMaterialsItems(List<UC_MaterialItem> materialItems)
        {
            _materialItems.Clear();

            _materialItems = materialItems;
        }

        public void DecorateGroundFromMaterialSelected()
        {
            foreach (UC_MaterialItem uc_material in _materialItems)
            {
                switch (uc_material.Material)
                {
                    case "Raquete":
                        _priceEntity = new RacketDecorator(Instance.IPriceEntity, uc_material.Quantity, Convert.ToDouble(uc_material.Price));
                        break;
                    case "Bola":
                        _priceEntity = new BallDecorator(Instance.IPriceEntity, uc_material.Quantity, Convert.ToDouble(uc_material.Price));
                        break;
                    default:
                        break;
                }
            }
        }

        public void DecorateGroundFromParkSelected()
        {
            var sport = _createEventController.GetSportFromId(Instance.SportId);
            var parkGrounds = _createEventController.GetGroundsFromId(Instance.ParkId);

            foreach (var ground in parkGrounds)
            {
                foreach (var s in ground.Sports)
                {
                    if (s.SportId == sport.SportId)
                    {
                        Instance.Reserve.GroundId = ground.GroundId;
                        Instance.Reserve.SportId = sport.SportId;
                        Instance.IPriceEntity = ground;
                    }
                }
            }

            int NumberOfHoursPlaying = Convert.ToInt32(EventEndTime.Subtract(EventStartTime).TotalHours);

            if (NumberOfHoursPlaying > 1)
            {
                NumberOfHoursPlaying -= 1;
                Instance.IPriceEntity = new TimeDecorator(Instance.IPriceEntity, NumberOfHoursPlaying, _createEventController.GetGround(EventCreationManager.Instance.Reserve.GroundId).Price);
            }
        }
    }
}
