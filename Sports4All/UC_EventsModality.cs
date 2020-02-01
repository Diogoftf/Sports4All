using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsModality : UserControl, IUserControl
    {
        private readonly MyEventsController _eventsController;
        private bool _controlSub = false;
        private string _sportName;
        private int _id;
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(UC_EventsModality));

        public UC_EventsModality()
        {
            InitializeComponent();
            _eventsController = new MyEventsController();
            _username = Session.Instance.LoggedUsername;
           
        }

        #region Properties
        public string Sport
        {
            get { return _sportName; }
            set { _sportName = value; tbModalityName.Text = value; }
        }
        private string _username { get; }

        public string Id { get; set; }
        #endregion

        private void onLoad(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(Id);
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            int id = Convert.ToInt32(Id);

            flpEventListModality.Controls.Clear();

            var EventsbySport = _eventsController.EventsBySport(id);
            var EventsbySportCount = EventsbySport.Count;
            UC_NextEventsandReserveItem[] listitems = new UC_NextEventsandReserveItem[EventsbySportCount];
            var Sport = _eventsController.RetrieveSingleSport(id);
            tbModalityName.Text = Sport.ToList()[0].Name;
            for (int i = 0; i < EventsbySportCount; i++)
            {
                var usersCount = EventsbySport.ToList()[i].Users.Count;
                var maxUsers = EventsbySport.ToList()[i].MaxPlayers;
                var hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString();
                var month = EventsbySport.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    EventID = Convert.ToString(EventsbySport.ToList()[i].EventId),
                    Owner = EventsbySport.ToList()[i].Reserve.UserId,
                    SportGround = EventsbySport.ToList()[i].Reserve.Ground.Park.Name,
                    Hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(EventsbySport.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers

                };
                if (usersCount == maxUsers) listitems[i].ChangeJoinEventbtn(false); // remove botao para se juntar ao evento
                flpEventListModality.Controls.Add(listitems[i]);
            }
        }

        private void mouseHover(object sender, EventArgs e)
        {
            if (!_controlSub) tbSubNotification.Visible = true;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            tbSubNotification.Visible = false;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                btnSub.Image = Image.FromFile(@"..\..\Images\" + "sub_Button.png");
                _controlSub = true;
                ShowNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            //retira subscrição!
            else
            {
                btnSub.Image = Image.FromFile(@"..\..\Images\" + "unsub_Button.png");
                _controlSub = false;
            }
        }
        
        private void ShowNotification(string title, string body)
        {
            var notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;

            if (title != null) notifyIcon.BalloonTipTitle = title;

            if (body != null) notifyIcon.BalloonTipText = body;

            notifyIcon.ShowBalloonTip(30000);
        }

        public void ListEventsBySport()
        {
            flpEventListModality.Controls.Clear();
            var EventsbySport = _eventsController.EventsBySport(_id);
            var EventsbySportCount = EventsbySport.Count;
            var listitems = new UC_NextEventsandReserveItem[EventsbySportCount];
            var Sport = _eventsController.RetrieveSingleSport(_id);
            tbModalityName.Text = Sport.ToList()[0].Name;
            for (var i = 0; i < EventsbySportCount; i++)
            {
                var users = EventsbySport.ToList()[i].Users.ToList();
                var usersCount = EventsbySport.ToList()[i].Users.Count;
                var maxUsers = EventsbySport.ToList()[i].MaxPlayers;
                var hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString();
                var month = EventsbySport.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    EventID = Convert.ToString(EventsbySport.ToList()[i].EventId),
                    Owner = EventsbySport.ToList()[i].Reserve.UserId,
                    SportGround = EventsbySport.ToList()[i].Reserve.Ground.Park.Name,
                    Hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(EventsbySport.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers,
                    Sport = EventsbySport.ToList()[i].Reserve.Sport.Name
                };
                if (usersCount == maxUsers)
                    listitems[i].ChangeJoinEventbtn(false); // remove botao para se juntar ao evento

                foreach (var user in users)
                    if (user.Username == _username) // já estou no evento
                    {
                        listitems[i].ChangeJoinEventbtn(false);
                        if (listitems[i].Owner.Equals(_username))
                        {
                            // sou o owner, botao de remover evento
                            listitems[i].ChangeCancelbtn(true);
                        }
                        else
                        {
                            listitems[i].ChangeJoinEventbtn(false);
                            listitems[i].BringToFrontUnregister(true);
                        }

                        break;
                    }
                // se nao encontrar o user nao faz nada, o joinBtn por defeito está a true

                flpEventListModality.Controls.Add(listitems[i]);
            }
        }
    }
}