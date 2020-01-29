using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsSportsGrounds : UserControl, IUserControl
    {
        private ComponentResourceManager _resources;
        private readonly MyEventsController _eventsController;
        private ParkDescriptionController _parkController;
        private ICollection<Event> _eventsList;
        private bool _controlSub = false;
        private string _parkName;
        private int _id;
        private string _username { get; set; }

        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
            _username = Session.Instance.LoggedUser;
            // ParkName = _parkController.GetPark(Id).Name;
            btnAllSports.BackColor = Color.LightBlue;
            _resources = new ComponentResourceManager(typeof(UC_EventsModality));
            _eventsController = new MyEventsController();
            _parkController = new ParkDescriptionController();
            _eventsList = new Collection<Event>();
            
        }

        #region Properties
        public string Id { get; set; }
        public string ParkName
        {

            get { return _parkName; }
            set { _parkName = value; tbSportsgroundName.Text = value; }

        }
        #endregion


        private void UC_EventsSportsGrounds_Load(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(Id);
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
           
            flpEventListSportsground.Controls.Clear();
            _eventsList = _eventsController.EventsByGround(Convert.ToInt32(Id));
            if (!DesignMode) ListEventsbyGround();
        }

        public void ListEventsbyGround()
        {
            flpEventListSportsground.Controls.Clear();
            var EventsbyGroundCount = _eventsList.Count;
            UC_NextEventsandReserveItem[] listitems = new UC_NextEventsandReserveItem[EventsbyGroundCount];
            var Park = _parkController.GetPark(Convert.ToInt32(Id));
            ParkName = Park.Name;

            for (int i = 0; i < EventsbyGroundCount; i++)
            {
                var users = _eventsList.ToList()[i].Users.ToList();
                var usersCount = _eventsList.ToList()[i].Users.Count;
                var maxUsers = _eventsList.ToList()[i].MaxPlayers;
                var hour = _eventsList.ToList()[i].StartDate.ToShortTimeString();
                var month = _eventsList.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    Owner = _eventsList.ToList()[0].Reserve.UserId,
                    SportGround = _eventsList.ToList()[0].Reserve.Ground.Park.Name,
                    Hour = _eventsList.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(_eventsList.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(_eventsList.ToList()[0].EventId)
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

                flpEventListSportsground.Controls.Add(listitems[i]);
            }
        }
        private void mouseHover(object sender, EventArgs e)
        {
            if (!_controlSub) tbSubSportsGroundNotification.Visible = true;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            tbSubSportsGroundNotification.Visible = false;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                tbSubSportsGroundNotification.Visible = false;
                _controlSub = true;
                //this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
                btnSub.Image = ((System.Drawing.Image)(_resources.GetObject("sub_Button")));
                showNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            else
            {
                btnSub.Image = ((System.Drawing.Image)(_resources.GetObject("subButton.Image")));
                _controlSub = false;

            }

        }
        private void showNotification(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;

            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }

            notifyIcon.ShowBalloonTip(30000);
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                btnTenis.BackColor = Color.LightGray;
                btnFootball.BackColor = Color.LightBlue;
                btnHandball.BackColor = Color.LightGray;
                btnAllSports.BackColor = Color.LightGray;
                flpEventListSportsground.Controls.Clear();
                _eventsList = _eventsController.EventsbyGroundandSport(_id, btnFootball.Text);
                ListEventsbyGround();
            }
        }

        private void btnTenis_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                btnTenis.BackColor = Color.LightBlue;
                btnFootball.BackColor = Color.LightGray;
                btnHandball.BackColor = Color.LightGray;
                btnAllSports.BackColor = Color.LightGray;
                flpEventListSportsground.Controls.Clear();
                _eventsList = _eventsController.EventsbyGroundandSport(_id, btnTenis.Text);
                ListEventsbyGround();
            }
        }

        private void btnHandball_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                btnTenis.BackColor = Color.LightGray;
                btnFootball.BackColor = Color.LightGray;
                btnHandball.BackColor = Color.LightBlue;
                btnAllSports.BackColor = Color.LightGray;
                flpEventListSportsground.Controls.Clear();
                _eventsList = _eventsController.EventsbyGroundandSport(_id, btnHandball.Text);
                ListEventsbyGround();
            }
        }

        private void btnAllSports_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                btnAllSports.BackColor = Color.LightBlue;
                btnTenis.BackColor = Color.LightGray;
                btnFootball.BackColor = Color.LightGray;
                btnHandball.BackColor = Color.LightGray;
                flpEventListSportsground.Controls.Clear();
                _eventsList = _eventsController.EventsByGround(_id);
                ListEventsbyGround();
            }
        }
    }
}

