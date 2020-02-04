using System;
using Sports4All.Controller;

namespace Sports4All
{
    public class JoinButton : IButton
    {
        private readonly int _eventid;

        private readonly UC_NextEventsandReserveItem _eventItem;
        private readonly MyEventsController _eventsController;
        private readonly string _username;

        public JoinButton(UC_NextEventsandReserveItem EventItem)
        {
            _eventsController = new MyEventsController();
            _eventItem = EventItem;
            _username = _eventItem.Username;
            _eventid = Convert.ToInt32(_eventItem.EventID);
        }

        public void Execute()
        {
            _eventsController.JoinEvent(_eventid, _username);
        }
    }
}