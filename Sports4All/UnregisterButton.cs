using System;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public class UnregisterButton : IButton
    {
        private readonly int _eventid;
        private readonly UC_NextEventsandReserveItem _eventItem;
        private readonly MyEventsController _eventsController;
        private readonly string _username;

        public UnregisterButton(UC_NextEventsandReserveItem EventItem)
        {
            _eventsController = new MyEventsController();
            _eventItem = EventItem;
            _username = _eventItem.Username;
            _eventid = Convert.ToInt32(_eventItem.EventID);
        }

        public void Execute()
        {
            var result = MessageBox.Show("Quer mesmo sair deste Evento?",
                "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _eventsController.UnregisterUser(_eventid, _username);
                Form1.Instance.BringUcToFront<UC_Home>("UC_Home", "");
            }
        }
    }
}