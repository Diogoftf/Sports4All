using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsSportsGrounds : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));
        private readonly MyEventsController _eventsController = new MyEventsController();
        private ParkDescriptionController _parkController = new ParkDescriptionController();
        private ICollection<Event> _eventsList = new Collection<Event>();
        public int Id { get; set; }
        private bool _controlSub = false;
        private string _parkName;
        private string _username { get; set; }

        public string ParkName
        {

            get { return _parkName; }
            set { _parkName = value; tbSportsgroundName.Text = value; }

        }
        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
            _username = Session.Instance.LoggedUser;
          // ParkName = _parkController.GetPark(Id).Name;
          btnAllSports.BackColor = Color.LightBlue;
          _eventsList = _eventsController.EventsByGround(Id);
          if (!DesignMode) ListEventsbyGround();

        }
        private void Recintos_Load(object sender, EventArgs e)
        {

            flpEventListSportsground.Controls.Clear();
            
        }
        public void ListEventsbyGround()
        {
            flpEventListSportsground.Controls.Clear();
            var EventsbyGroundCount = _eventsList.Count;
            UC_NextEventsandReserveItem[] listitems = new UC_NextEventsandReserveItem[EventsbyGroundCount];
            var Park = _parkController.GetPark(Id);

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
                    EventID = Convert.ToString(_eventsList.ToList()[i].EventId),
                    Owner = _eventsList.ToList()[i].Reserve.UserId,
                    SportGround = _eventsList.ToList()[i].Reserve.Ground.Park.Name,
                    Hour = _eventsList.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(_eventsList.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers,
                    Sport = _eventsList.ToList()[i].Reserve.Sport.Name
                };

                if (usersCount == maxUsers) listitems[i].ChangeJoinEventbtn(false);  // remove botao para se juntar ao evento
                foreach (var user in users)
                {
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
                }

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
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("sub_Button")));
                showNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            //retira subscrição!
            else
            {
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("subButton.Image")));
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
                _eventsList = _eventsController.EventsbyGroundandSport(Id, btnFootball.Text);
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
                _eventsList = _eventsController.EventsbyGroundandSport(Id, btnTenis.Text);
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
                _eventsList =_eventsController.EventsbyGroundandSport(Id, btnHandball.Text);
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
                _eventsList = _eventsController.EventsByGround(Id);
                ListEventsbyGround();
            }
        }
    }
}
