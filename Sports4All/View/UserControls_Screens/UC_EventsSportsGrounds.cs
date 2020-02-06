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
        private string Username { get; set; }

        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
            Username = Session.Instance.LoggedUser;
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
            UC_NextEventsandReserveItem _eventGround = new UC_NextEventsandReserveItem();

            foreach (var eventGround in _eventsList)
            {
                var users = eventGround.Users.ToList();
                var usersCount = eventGround.Users.Count;
                var maxUsers = eventGround.MaxPlayers;
                var hour = eventGround.StartDate.ToShortTimeString();
                var date = eventGround.StartDate.ToLongDateString();
                var partsOfDate = date.Split();
                var month = partsOfDate[2].Substring(0, 3).ToUpper();
                _eventGround.Owner = _eventsList.ToList()[0].Reserve.UserId;
                _eventGround.SportGround = _eventsList.ToList()[0].Reserve.Ground.Park.Name;
                _eventGround.Hour = eventGround.StartDate.ToShortTimeString();
                _eventGround.Day = Convert.ToString(eventGround.StartDate.Day);
                _eventGround.Month = month;
                _eventGround.Lotation = usersCount + "/" + maxUsers;
                _eventGround.EventID = Convert.ToString(eventGround.EventId);
               
                var eventItem = _eventsController.ChangeButtons(usersCount, maxUsers, _eventGround, users, Username);
                flpEventListSportsground.Controls.Add(eventItem);
            }
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

