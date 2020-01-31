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
            var listitems = new UC_EventMyEventsItem[completedEventsCounts];

            for (var i = 0; i < completedEventsCounts; i++)
            {
                if (!_eventsController.VerifyEvaluation(completedEvents.ToList()[i].EventId, Username))
                {
                    listitems[i] = new UC_EventMyEventsItem
                    {
                        Avaliar = "Avaliar",
                        EventID = completedEvents.ToList()[i].EventId,
                        Owner = completedEvents.ToList()[i].Reserve.UserId,
                        Sport = completedEvents.ToList()[i].Reserve.Sport.Name,
                        Date = completedEvents.ToList()[i].StartDate.ToLongDateString(),
                        Park = completedEvents.ToList()[i].Reserve.Ground.Park.Name,
                        MessageInfo = "Avalie este evento!",
                        Change_BackColor = Color.LightCoral
                    };
                    flpListMyEvents.Controls.Add(listitems[i]);
                }
                else {
                    listitems[i] = new UC_EventMyEventsItem 
                    {
                        Avaliar = "Avaliado",
                        EventID = completedEvents.ToList()[i].EventId,
                        Owner = completedEvents.ToList()[i].Reserve.UserId,
                        Sport = completedEvents.ToList()[i].Reserve.Sport.Name,
                        Date = completedEvents.ToList()[i].StartDate.ToLongDateString(),
                        Park = completedEvents.ToList()[i].Reserve.Ground.Park.Name,
                        MessageInfo = "Já avaliou este evento!",
                        Change_BackColor = Color.Green
                    };
                    listitems[i].DisableButtonEvaluation();
                    flpListMyEvents.Controls.Add(listitems[i]);
                }
            }
        }
        private void MyReserves()
        {
            flpListMyEvents.Controls.Clear();
            var myReserves = _eventsController.RetrieveUserReserves(Username);
            var myReservesCounts = myReserves.Count;
            var listitems = new UC_NextEventsandReserveItem[myReservesCounts];

            for (var i = 0; i < myReservesCounts; i++)
            {
                var usersCount = myReserves.ToList()[i].Event.Users.Count;
                var maxUsers = myReserves.ToList()[i].Event.MaxPlayers;
                var hour = myReserves.ToList()[i].Event.StartDate.ToShortTimeString();
                var month = myReserves.ToList()[i].Event.StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(myReserves.ToList()[i].Event.StartDate.Day),
                    Month = month,
                    Hour = myReserves.ToList()[i].Event.StartDate.ToShortTimeString(),
                    Owner = myReserves.ToList()[i].UserId,
                    SportGround = myReserves.ToList()[i].Ground.Park.Name,
                    Sport = myReserves.ToList()[i].Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(myReserves.ToList()[i].Event.EventId)
                };
                if (Username.Equals(listitems[i].Owner))
                {
                    listitems[i].ChangeJoinEventbtn(false);
                }
                else
                {
                    listitems[i].ChangeCancelbtn(false);
                    listitems[i].ChangeJoinEventbtn(true);
                }
                flpListMyEvents.Controls.Add(listitems[i]);
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
            var listitems = new UC_NextEventsandReserveItem[nextEventsCount];
            for (var i = 0; i < nextEventsCount; i++)
            {
                var users = nextEvents.ToList()[i].Users.ToList();
                var usersCount = nextEvents.ToList()[i].Users.Count;
                var maxUsers = nextEvents.ToList()[i].MaxPlayers;
                var hour = nextEvents.ToList()[i].StartDate.ToShortTimeString();
                var month = nextEvents.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(nextEvents.ToList()[i].StartDate.Day),
                    Month = month,
                    Hour = nextEvents.ToList()[i].StartDate.ToShortTimeString(),
                    Owner = nextEvents.ToList()[i].Reserve.UserId,
                    SportGround = nextEvents.ToList()[i].Reserve.Ground.Park.Name,
                    Sport = nextEvents.ToList()[i].Reserve.Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(nextEvents.ToList()[i].EventId)
                };
                var eventItem = _eventsController.ChangeButtons(usersCount, maxUsers, listitems[i], users, i, Username);
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