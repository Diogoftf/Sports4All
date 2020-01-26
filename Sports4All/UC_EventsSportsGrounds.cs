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

        public string ParkName
        {

            get { return _parkName; }
            set { _parkName = value; tbSportsgroundName.Text = value; }

        }
        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
          // ParkName = _parkController.GetPark(Id).Name;
          btnAllSports.BackColor = Color.LightBlue;
        }
        private void Recintos_Load(object sender, EventArgs e)
        {

            flpEventListSportsground.Controls.Clear();
            _eventsList = _eventsController.EventsByGround(Id);
            if (!DesignMode) ListEventsbyGround();


        }

        public void ListEventsbyGround()
        {
            flpEventListSportsground.Controls.Clear();
            var EventsbyGroundCount = _eventsList.Count;
            UC_EventSportsGroundItem[] listitems = new UC_EventSportsGroundItem[EventsbyGroundCount];
            var Park = _eventsController.RetrieveSinglePark(Id);
            tbSportsgroundName.Text = Park.ToList()[0].Name;
    
            for (int i = 0; i < EventsbyGroundCount; i++)
            {
                var usersCount = _eventsList.ToList()[i].Users.Count;
                var maxUsers = _eventsList.ToList()[i].MaxPlayers;
                var hour = _eventsList.ToList()[i].StartDate.ToShortTimeString();
                var month = _eventsList.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_EventSportsGroundItem
                {
                Owner = _eventsList.ToList()[0].Reserve.UserId,
                SportGround = _eventsList.ToList()[0].Reserve.Ground.Park.Name,
                Hour = _eventsList.ToList()[i].StartDate.ToShortTimeString(),
                Day = Convert.ToString(_eventsList.ToList()[i].StartDate.Day),
                Month = month,
                Lotation = usersCount + "/" + maxUsers,
                EventId = _eventsList.ToList()[0].EventId
                };

                if (usersCount == maxUsers) listitems[i].DisableJoinEventbtn(); // remove botao para se juntar ao evento
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
