using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_MyEvents : UserControl, IUserControl
    {
        private readonly MyEventsController _eventsController;

        private const int _numberEventsShow = 5;
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

        private void FinishedEvents()
        {
            flpListMyEvents.Controls.Clear();
            var completedEvents = _eventsController.RetrieveCompletedEvents(Username);

            foreach (var completeEvent in completedEvents.Take(_numberEventsShow))
            {
                UC_EventMyEventsItem _finishedEvent = new UC_EventMyEventsItem
                {
                    EventID = completeEvent.EventId,
                    Owner = completeEvent.Reserve.UserId,
                    Sport = completeEvent.Reserve.Sport.Name,
                    Date = completeEvent.StartDate.ToLongDateString(),
                    Park = completeEvent.Reserve.Ground.Park.Name,
                    Image = ImagesController.Instance.GetImageFromID(completeEvent.Reserve.Sport.Picture.PictureId)
                };

                if (!_eventsController.VerifyEvaluation(completeEvent.EventId, Username))
                {
                    _finishedEvent.Avaliar = "Avaliar";
                    _finishedEvent.MessageInfo = "Avalie este evento!";
                    _finishedEvent.Change_BackColor = Color.LightCoral;
                }
                else
                {
                    _finishedEvent.Avaliar = "Avaliado";
                    _finishedEvent.MessageInfo = "Já avaliou este evento!";
                    _finishedEvent.Change_BackColor = Color.Green;
                    _finishedEvent.DisableButtonEvaluation();
                }
                flpListMyEvents.Controls.Add(_finishedEvent);
                }
            }

        private void MyReserves()
        {
            flpListMyEvents.Controls.Clear();
            var myReserves = _eventsController.RetrieveUserReserves(Username);
            
            foreach (var reserves in myReserves.Take(_numberEventsShow))
            {
                var usersCount = reserves.Event.Users.Count;
                var maxUsers   =   reserves.Event.MaxPlayers;
                var hour     =     reserves.Event.StartDate.ToShortTimeString();
                var date = reserves.Event.StartDate.ToLongDateString();
                var partsOfDate = date.Split();
                var month = partsOfDate[2].Substring(0, 3).ToUpper();

                UC_NextEventsandReserveItem _reserve = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(reserves.Event.StartDate.Day),
                    Month = month,
                    Hour = reserves.Event.StartDate.ToShortTimeString(),
                    Owner = reserves.UserId,
                    SportGround = reserves.Ground.Park.Name,
                    Sport = reserves.Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(reserves.Event.EventId)
                };

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

            foreach (var nextEvent in nextEvents.Take(_numberEventsShow))
            {
                var users = nextEvent.Users.ToList();
                var usersCount = nextEvent.Users.Count;
                var maxUsers = nextEvent.MaxPlayers;
                var hour = nextEvent.StartDate.ToShortTimeString();
                var date = nextEvent.StartDate.ToLongDateString();
                var partsOfDate = date.Split();
                var month = partsOfDate[2].Substring(0, 3).ToUpper();

                UC_NextEventsandReserveItem _nextEvent = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(nextEvent.StartDate.Day),
                    Month = month,
                    Hour = nextEvent.StartDate.ToShortTimeString(),
                    Owner = nextEvent.Reserve.UserId,
                    SportGround = nextEvent.Reserve.Ground.Park.Name,
                    Sport = nextEvent.Reserve.Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(nextEvent.EventId)
                };

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