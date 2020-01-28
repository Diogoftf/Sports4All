using System;
using System.Collections.Generic;
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
                lbEventIDValue.Text = Convert.ToString(value);
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

        public string Id { get; set; }
        #endregion

        public UC_EventDetails()
        {
            InitializeComponent();
            PickDateTimeOnly();
            _eventsController = new MyEventsController();
            Id = _eventID.ToString();
            // _eventID = 1;// VALOR PARA TESTE!!!!!!!!!!
        }


        private void UC_EventsDetails_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
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


        }

        private void PropertiesformEventDetails(bool Enabled, BorderStyle border, bool ReadOnly)
        {
            dtpNextEventDate.Enabled = Enabled;
            // tbEventDate.Enabled = Enabled;
            //dtpNextEventDate.BorderStyle = border;
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
            UpdateFormFields();
        }

        private void UpdateFormFields()
        {
            _maxPlayerAge = tbMaxAge.Text;
            _maxPlayers = tbMaxPlayers.Text;
            _minPlayerAge = tbminAge.Text;
        }

        private void PopulateUsersList()
        {
            flpUsersEvent.Controls.Clear();
            ICollection<User> enrolledUsers = _eventsController.RetrieveEnrolledUsers(_eventID);
            int enrolledUsersCount = enrolledUsers.Count;
            UC_UserinEventItem[] listusers = new UC_UserinEventItem[enrolledUsersCount];

            for (int i = 0; i < enrolledUsersCount; i++)
            {
                listusers[i] = new UC_UserinEventItem()
                {
                    Username = enrolledUsers.ToList()[i].Username,
                    PlayerAge = enrolledUsers.ToList()[i].Age + "Anos",
                    UserID = enrolledUsers.ToList()[i].Username
                    //PlayerSkill = enrolledUsers.ToList()[i].myStats.rankClassification.ToString()
                };
                flpUsersEvent.Controls.Add(listusers[i]);
            }

        }
        private void PopulateEventDetails()
        {

            var SingleEvent = _eventsController.RetrieveSingleEvent(_eventID);
            lbEventId.Text = "Evento #" + SingleEvent.EventId;
            lblOwnerValue.Text = SingleEvent.Reserve.UserId;
            //lblUserPhoneValue.Text = Convert.ToString(SingleEvent.Reserve.User.PhoneNumber); campo está a Null na BD ainda, propriedade navegação.
            dtpNextEventDate.Text = SingleEvent.StartDate.ToLongDateString();
            dtpStartEventTime.Text = SingleEvent.StartDate.ToShortTimeString();
            dtpEndEventTime.Text = SingleEvent.EndDate.ToShortTimeString();
            tbMaxPlayers.Text = Convert.ToString(SingleEvent.MaxPlayers);
            tbMaxAge.Text = Convert.ToString(SingleEvent.MaxAge);
            tbminAge.Text = Convert.ToString(SingleEvent.MinAge);
            //**Ver Nome do Parque ainda**
            ParkName = SingleEvent.Reserve.Ground.Park.Name;

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
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Dados Guardados com Sucesso!");
            btnSaveChanges.Visible = false;
            PropertiesformEventDetails(false, BorderStyle.None, true);
            string format = "dd/MM/yyyy HH:mm:ss";
            int EventID = Convert.ToInt32(_eventID);
            int MaxPlayes = Convert.ToInt32(_maxPlayers);
            int MaxAge = Convert.ToInt32(_maxPlayerAge);
            int MinAge = Convert.ToInt32(_minPlayerAge);
            string startdateTime = dtpNextEventDate.Text + " " + dtpStartEventTime.Text;
            string enddatetime = dtpNextEventDate.Text + " " + dtpEndEventTime.Text;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NewStartDate = DateTime.ParseExact(startdateTime, format, provider);
            DateTime NewEndDate = DateTime.ParseExact(enddatetime, format, provider);
            // DateTime NewDate = new DateTime();
            _eventsController.UpdateEventRecord(EventID, MaxAge, MinAge, MaxPlayes, NewStartDate, NewEndDate);

        }
    } 
}
