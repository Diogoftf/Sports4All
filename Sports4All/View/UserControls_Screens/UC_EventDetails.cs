using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventDetails : UserControl, IUserControl
    {
        private MyEventsController _eventsController;
        private string _maxPlayers;
        private string _maxPlayerAge;
        private string _minPlayerAge;
        private string _eventDate;
        private string _startHour;
        private string _endHour;
        private int _eventID;
        private string _parkname;
        private Image _image;
        private string _eventName;

        public string EventName
        {
            get => _eventName;
            set
            {
                _eventName = value;
                lbEventId.Text ="Evento:"+ value;
                tbNameEvent.Text = value;
            }
        }

        public string ParkName
        {
            get => _parkname;
            set
            {
                _parkname = value;
                lbParkName.Text = value;
            }
        }

        #region  EventDetails
        public int EventId
        {
            get => _eventID;
            set
            {
                _eventID = value;
                //lbEventIDValue.Text = Convert.ToString(value);
            }
        }
        public string StartHour
        {
            get => _startHour;
            set
            {
                _startHour = value;
                dtpStartEventTime.Text = value;
            }
        }

        public string EndHour
        {
            get => _endHour;
            set
            {
                _endHour = value;
                dtpEndEventTime.Text = value;
            }
        }
        public string MaxPlayers
        {
            get => _maxPlayers;
            set
            {
                _maxPlayers = value;
                tbMaxPlayers.Text = value;
            }
        }
        public string MaxAge
        {
            get => _maxPlayerAge;
            set
            {
                _maxPlayerAge = value;
                tbMaxAge.Text = value;
            }
        }
        public string MinAge
        {
            get => _minPlayerAge;
            set
            {
                _minPlayerAge = value;
                tbminAge.Text = value;
            }
        }

        public string EventDate
        {
            get => _eventDate;
            set
            {
                _eventDate = value;
                dtpNextEventDate.Text = value;
            }
        }

        public Image Image
        {
            get => _image;
            set { _image = value; pbPark.Image = value; }
        }

        public string Id { get; set; }
        #endregion

        public UC_EventDetails()
        {
            InitializeComponent();
            PickDateTimeOnly();
            _eventsController = new MyEventsController();
        }


        private void UC_EventsDetails_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            EventId = Convert.ToInt32(Id);
            Populate();
        }

        public void Populate()
        {
            PopulateUsersList();
            PopulateEventDetails();
            CheckOwner();
        }

        private void PickDateTimeOnly()
        {
            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.ShowUpDown = true;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = false;
            PropertiesformEventDetails(false, BorderStyle.None, true);
            string format = "dd/MM/yyyy HH:mm";
            int EventID = Convert.ToInt32(_eventID);
            int MaxPlayes = Convert.ToInt32(_maxPlayers);
            int MaxAge = Convert.ToInt32(_maxPlayerAge);
            int MinAge = Convert.ToInt32(_minPlayerAge);
            string startdateTime = dtpNextEventDate.Text +" "+ dtpStartEventTime.Text;
            string enddatetime = dtpNextEventDate.Text + " " + dtpEndEventTime.Text;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NewStartDate = DateTime.ParseExact(startdateTime, format, provider);
            DateTime NewEndDate = DateTime.ParseExact(enddatetime, format, provider);
           // string Name = EventName;
            _eventsController.UpdateEventRecord(EventID, MaxAge, MinAge, MaxPlayes, NewStartDate, NewEndDate, EventName);
        
        }
        private void PropertiesformEventDetails(bool Enabled, BorderStyle border, bool ReadOnly)
        {
            dtpNextEventDate.Enabled = Enabled;
            tbMaxAge.ReadOnly = ReadOnly;
            tbMaxAge.Enabled = Enabled;
            tbMaxAge.BorderStyle = border;
            tbminAge.ReadOnly = ReadOnly;
            tbminAge.Enabled = Enabled;
            tbminAge.BorderStyle = border;
            tbMaxPlayers.ReadOnly = ReadOnly;
            tbMaxPlayers.Enabled = Enabled;
            tbMaxPlayers.BorderStyle = border;
            dtpNextEventDate.Enabled = Enabled;
            dtpStartEventTime.Enabled = Enabled;
            dtpEndEventTime.Enabled = Enabled;
            tbNameEvent.BorderStyle = border;
            tbNameEvent.Enabled = Enabled;
            tbNameEvent.ReadOnly = ReadOnly;
            UpdateFormFields();
        }

        private void UpdateFormFields()
        {
            _maxPlayerAge = tbMaxAge.Text;
            _maxPlayers = tbMaxPlayers.Text;
            _minPlayerAge = tbminAge.Text;
            _eventName = tbNameEvent.Text;
        }

        private void PopulateUsersList()
        {
            flpUsersEvent.Controls.Clear();
            ICollection<User> enrolledUsers = _eventsController.RetrieveEnrolledUsers(_eventID);
            foreach (var user in enrolledUsers)
            {
                UC_UserinEventItem _userInEvent = new UC_UserinEventItem()
                {
                    UserId = user.Username,
                    PlayerAge = user.Age + "Anos",
                    PlayerSkill = Convert.ToString(user.UserClassification.Points),
                    Image = ImagesController.Instance.GetImageFromID(user.PictureId)
                };
                flpUsersEvent.Controls.Add(_userInEvent);
            }

        }
        private void PopulateEventDetails()
        {
            var singleEvent = _eventsController.RetrieveSingleEvent(_eventID);
            lbEventId.Text = "Evento #" + singleEvent.EventId;
            lblOwnerValue.Text = singleEvent.Reserve.UserId;
            lblUserPhoneValue.Text = Convert.ToString(singleEvent.Reserve.User.PhoneNumber);
            dtpNextEventDate.Text = singleEvent.StartDate.ToLongDateString();
            dtpStartEventTime.Text = singleEvent.StartDate.ToShortTimeString();
            dtpEndEventTime.Text = singleEvent.EndDate.ToShortTimeString();
            tbMaxPlayers.Text = Convert.ToString(singleEvent.MaxPlayers);
            pbPark.Image = ImagesController.Instance.GetImageFromID(singleEvent.Reserve.Ground.Park.Picture.PictureId);
            tbMaxAge.Text = Convert.ToString(singleEvent.MaxAge);
            tbminAge.Text = Convert.ToString(singleEvent.MinAge);
            ParkName = singleEvent.Reserve.Ground.Park.Name;
            EventName = singleEvent.Name;
        }

        public void CheckOwner()
        {
            if (lblOwnerValue.Text != Session.Instance.LoggedUser) btnEdit.Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
            PropertiesformEventDetails(true, BorderStyle.Fixed3D, false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}
