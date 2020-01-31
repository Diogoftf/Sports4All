using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports4All.Controller;

namespace Sports4All
{
   public class UnregisterCommand : ICommand
    {


        private UC_NextEventsandReserveItem _eventItem;
        private MyEventsController _eventsController;
        private string _username;
        private int _eventid;
        public UnregisterCommand(UC_NextEventsandReserveItem EventItem)
        {
            _eventsController = new MyEventsController();
            this._eventItem = EventItem;
            this._username = this._eventItem.Username;
            this._eventid = Convert.ToInt32(this._eventItem.EventID);

        }
        public void Execute()
        {
            _eventsController.UnregisterUser(_eventid, _username);
        }
    }
}
