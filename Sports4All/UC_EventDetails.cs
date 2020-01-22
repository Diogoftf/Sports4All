using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsDetails : UserControl
    {
        private MyEventsController eventsController;

        private string _maxPlayers;
        private string _maxPlayerAge;
        private string _minPlayerAge;
        private string _eventDate;
        #region  EventDetails
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
                tbEventDate.Text = value;
            }
        }
        #endregion

        public UC_EventsDetails()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
            formEventDetails(true, BorderStyle.Fixed3D, false);
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Guardados com Sucesso!");
            btnSaveChanges.Visible = false;
            formEventDetails(false, BorderStyle.None, true);
        }
        private void formEventDetails(bool Enabled, BorderStyle border, bool ReadOnly)
        {
            tbEventDate.ReadOnly = ReadOnly;
            tbEventDate.Enabled = Enabled;
            tbEventDate.BorderStyle = border;
            tbMaxAge.ReadOnly = ReadOnly;
            tbMaxAge.Enabled = Enabled;
            tbMaxAge.BorderStyle = border;
            tbminAge.ReadOnly = ReadOnly;
            tbminAge.Enabled = Enabled;
            tbminAge.BorderStyle = border;
            tbMaxPlayers.ReadOnly = ReadOnly;
            tbMaxPlayers.Enabled = Enabled;
            tbMaxPlayers.BorderStyle = border;
        }

        private void UC_EventsDetailsB_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                eventsController = new MyEventsController();
                PopulateEventDetails();
                PopulateUsersList();
            }
        }

        private void PopulateUsersList()
        {
            ICollection<User> enrolledUsers = eventsController.RetrieveEnrolledUsers(1);
            int enrolledUsersCount = enrolledUsers.Count;
            UC_UserinEventItem[] listusers = new UC_UserinEventItem[enrolledUsersCount];

            for (int i = 0; i < enrolledUsersCount; i++)
            {
                listusers[i] = new UC_UserinEventItem()
                {
                    Username = enrolledUsers.ToList()[i].Username,
                    PlayerAge = enrolledUsers.ToList()[i].Age + "Anos",
                    //PlayerSkill = enrolledUsers.ToList()[i].myStats.rankClassification.ToString()
                };
                flpUsersEvent.Controls.Add(listusers[i]);
            }
        }

        private void PopulateEventDetails()
        {
            var SingleEvent = eventsController.RetrieveSingleEvent(1);
            lbEventId.Text = "Evento #" + SingleEvent.EventId;
            lblOwnerValue.Text = SingleEvent.Reserve.UserId;
            //lblUserPhoneValue.Text = Convert.ToString(SingleEvent.Reserve.User.PhoneNumber); campo está a Null na BD ainda, propriedade navegação.
            tbEventDate.Text = SingleEvent.StartDate.ToShortDateString();
            tbMaxPlayers.Text =Convert.ToString(SingleEvent.MaxPlayers);
            tbMaxAge.Text = SingleEvent.MaxAge + "anos";
            tbminAge.Text = SingleEvent.MinAge + "anos";
            //**Ver Nome do Parque ainda**

        }

    }
}
