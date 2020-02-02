using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_MyEvents : UserControl, IUserControl
    {
        private readonly MyEventsController _eventsController;

        public UC_MyEvents()
        {
            InitializeComponent();

            Username = Session.Instance.LoggedUser;
            _eventsController = new MyEventsController();
        }

        #region Properties

        private string Username { get; set; }
        public string Id { get; set; }

        #endregion

        private void UC_MyEvents_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
            btnFinishedEvents.BackColor = Color.LightSkyBlue;
        }

        public void Populate()
        {
            FinishedEvents();
        }

        private void button_ProximosEventos_Click(object sender, EventArgs e)
        {
            flpListMyEvents.Controls.Clear();
        }

        private void FinishedEvents()
        {
            flpListMyEvents.Controls.Clear();
            var completedEvents = _eventsController.RetrieveCompletedEvents(Username);
            var completedEventsCounts = completedEvents.Count;
            foreach (var completeEvent in completedEvents)
            {
                UC_EventMyEventsItem _finishedEvent = new UC_EventMyEventsItem();
                if (!_eventsController.VerifyEvaluation(completeEvent.EventId, Username))
                {
                    _finishedEvent.Avaliar = "Avaliar";
                    _finishedEvent.EventID = completeEvent.EventId;
                    _finishedEvent.Owner = completeEvent.Reserve.UserId;
                    _finishedEvent.Sport = completeEvent.Reserve.Sport.Name;
                    _finishedEvent.Date = completeEvent.StartDate.ToLongDateString();
                    _finishedEvent.Park = completeEvent.Reserve.Ground.Park.Name;
                    _finishedEvent.MessageInfo = "Avalie este evento!";
                    _finishedEvent.Change_BackColor = Color.LightCoral;
                    _finishedEvent.Image = ImagesController.Instance.GetImageFromID(completeEvent.Reserve.Sport.Picture.PictureId);
                }
                else
                {
                        _finishedEvent.Avaliar = "Avaliado";
                        _finishedEvent.EventID = completeEvent.EventId;
                        _finishedEvent.Owner = completeEvent.Reserve.UserId;
                        _finishedEvent.Sport = completeEvent.Reserve.Sport.Name;
                        _finishedEvent.Date = completeEvent.StartDate.ToLongDateString();
                        _finishedEvent.Park = completeEvent.Reserve.Ground.Park.Name;
                        _finishedEvent.MessageInfo = "Já avaliou este evento!";
                        _finishedEvent.Change_BackColor = Color.LightCoral;
                        flpListMyEvents.Controls.Add(_finishedEvent);
                        _finishedEvent.Image = ImagesController.Instance.GetImageFromID(completeEvent.Reserve.Sport.Picture.PictureId);
                 }
                    _finishedEvent.DisableButtonEvaluation();
                    flpListMyEvents.Controls.Add(_finishedEvent);
                }
            }
        

        private void MyReserves()
        {
            flpListMyEvents.Controls.Clear();
            var myReserves = _eventsController.RetrieveUserReserves(Username);
            var myReservesCounts = myReserves.Count;
            foreach (var reserves in myReserves)
            {
                var usersCount = reserves.Event.Users.Count;
                var maxUsers   =   reserves.Event.MaxPlayers;
                var hour     =     reserves.Event.StartDate.ToShortTimeString();
                var date = reserves.Event.StartDate.ToLongDateString();
                var partsOfDate = date.Split();
                var month = partsOfDate[2].Substring(0, 3).ToUpper();

                UC_NextEventsandReserveItem _reserve = new UC_NextEventsandReserveItem();
                _reserve.Day = Convert.ToString(reserves.Event.StartDate.Day);
                _reserve.Month = month;
                _reserve.Hour = reserves.Event.StartDate.ToShortTimeString();
                _reserve.Owner = reserves.UserId;
                _reserve.SportGround = reserves.Ground.Park.Name;
                _reserve.Sport = reserves.Sport.Name;
                _reserve.Lotation = usersCount + "/" + maxUsers;
                _reserve.EventID = Convert.ToString(reserves.Event.EventId);

                var events = _eventsController.ChangeButtonsReserve(Username, _reserve);
                flpListMyEvents.Controls.Add(events);
            }
        }

        private void btnNextEvents_Click(object sender, EventArgs e)
        {
            flpListMyEvents.Controls.Clear();
            btnNextEvents.BackColor = Color.LightSkyBlue;
            btnFinishedEvents.BackColor = Color.LightGray;
            btnMinhasReservas.BackColor = Color.LightGray;
            var nextEvents = _eventsController.RetrieveNextEvents(Username);
            var nextEventsCount = nextEvents.Count;
            foreach (var nextEvent in nextEvents)
            {
                var users = nextEvent.Users.ToList();
                var usersCount = nextEvent.Users.Count;
                var maxUsers = nextEvent.MaxPlayers;
                var hour = nextEvent.StartDate.ToShortTimeString();
                var date = nextEvent.StartDate.ToLongDateString();
                var partsOfDate = date.Split();
                var month = partsOfDate[2].Substring(0, 3).ToUpper();
                UC_NextEventsandReserveItem _nextEvent = new UC_NextEventsandReserveItem();
                _nextEvent.Day = Convert.ToString(nextEvent.StartDate.Day);
                _nextEvent.Month = month;
                _nextEvent.Hour = nextEvent.StartDate.ToShortTimeString();
                _nextEvent.Owner = nextEvent.Reserve.UserId;
                _nextEvent.SportGround = nextEvent.Reserve.Ground.Park.Name;
                _nextEvent.Sport = nextEvent.Reserve.Sport.Name;
                _nextEvent.Lotation = usersCount + "/" + maxUsers;
                _nextEvent.EventID = Convert.ToString(nextEvent.EventId);
                var eventItem = _eventsController.ChangeButtons(usersCount, maxUsers, _nextEvent, users, Username);
                flpListMyEvents.Controls.Add(eventItem);
            }
        }
        private void btnFinishedEvents_Click(object sender, EventArgs e)
        {
            flpListMyEvents.Controls.Clear();
            btnFinishedEvents.BackColor = Color.LightSkyBlue;
            btnNextEvents.BackColor = Color.LightGray;
            btnMinhasReservas.BackColor = Color.LightGray;
            if (!DesignMode) FinishedEvents();
        }

        private void btnMinhasReservas_Click(object sender, EventArgs e)
        {
            btnMinhasReservas.BackColor = Color.LightSkyBlue;
            btnNextEvents.BackColor = Color.LightGray;
            btnFinishedEvents.BackColor = Color.LightGray;
            flpListMyEvents.Controls.Clear();
            if (!DesignMode) MyReserves();
        }


    }
}