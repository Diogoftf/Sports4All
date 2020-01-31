using Sports4All.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
  public class CancelCommand : ICommand
    {

        private UC_NextEventsandReserveItem _eventItem;
        private MyEventsController _eventsController;
        private int _eventid;

        public CancelCommand(UC_NextEventsandReserveItem EventItem)
        {
            _eventsController = new MyEventsController();
            this._eventItem = EventItem;
            this._eventid = Convert.ToInt32(this._eventItem.EventID);

        }
        public void Execute()
        {
            _eventsController.DeleteEvent(_eventid);
        }
    }
}
