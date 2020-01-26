using System;
using System.Collections.Generic;
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
    public partial class UC_EventSportsGroundItem : UserControl
    {

        #region Properties
        private MyEventsController events = new MyEventsController();
        private string _day;
        private string _month;
        private string _hour;
        private string _sport;
        private string _owner;
        private string _lotation;
        private int _eventId;
        private string _username;

        public int EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }
        public string Lotation
        {
            get { return _lotation; }
            set { _lotation = value; lblSpaceAvailableValue.Text = value; }
        }
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; lblEventOwnerValue.Text = value; }
        }

        public string SportGround
        {
            get { return _sport; }
            set { _sport = value; lblModalityName.Text = value; }
        }

        public string Hour
        {
            get { return _hour; }
            set { _hour = value; lblEventHourValue.Text = value; }
        }
        public string Day
        {

            get { return _day; }
            set { _day = value; lblDay_Event.Text = value; }
        }

        public string Month
        {

            get { return _month; }
            set { _month = value; lblMonth_Event.Text = value; }

        }

        #endregion
        public UC_EventSportsGroundItem()
        {
            InitializeComponent();
            _username = Session.Instance.LoggedUser;
        }

        public void DisableJoinEventbtn()
        {
            btnJoinEvent.Visible = false;
        }

        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
            events.JoinEvent(_eventId, _username);
            MessageBox.Show("Juntou-se ao evento com sucesso!");

        }

        private void UC_EventSportsGroundItem_Load(object sender, EventArgs e)
        {
            if (!events.CheckUserInEvent(_eventId, _username)) btnJoinEvent.Visible = true;
        }
    }
}
