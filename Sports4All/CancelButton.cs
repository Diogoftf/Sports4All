using System;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public class CancelButton : IButton
    {
        private readonly int _eventid;

        private readonly UC_NextEventsandReserveItem _eventItem;
        private readonly MyEventsController _eventsController;

        public CancelButton(UC_NextEventsandReserveItem EventItem)
        {
            _eventsController = new MyEventsController();
            _eventItem = EventItem;
            _eventid = Convert.ToInt32(_eventItem.EventID);
        }

        public void Execute()
        {
            var result = MessageBox.Show("Deseja cancelar a Reserva?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _eventsController.DeleteEvent(_eventid);
                Form1.Instance.BringUcToFront<UC_Home>("UC_Home", "");
            }
        }
    }
}