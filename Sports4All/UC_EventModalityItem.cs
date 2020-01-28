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
    public partial class UC_EventModalityItem : UserControl
    {
        private MyEventsController _events;

        #region Properties
        private string _day;
        private string _month;
        private string _hour;
        private string _sportground;
        private string _owner;
        private string _lotation;
        private string _username;

        public int EventId { get; set; }

        public string Lotation
        {
            get { return _lotation; }
            set
            {
                _lotation = value;
                lblSpaceAvailableValue.Text = value;
            }
        }

        public string Owner
        {
            get { return _owner; }
            set
            {
                _owner = value;
                lblEventOwnerValue.Text = value;
            }
        }

        public string SportGround
        {
            get { return _sportground; }
            set
            {
                _sportground = value;
                lblSportsGround.Text = value;
            }
        }

        public string Hour
        {
            get { return _hour; }
            set
            {
                _hour = value;
                lblEventHourValue.Text = value;
            }
        }

        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
                lblDay_Event.Text = value;
            }
        }

        public string Month
        {
            get { return _month; }
            set
            {
                _month = value;
                lblMonth_Event.Text = value;
            }
        }
        #endregion

        public UC_EventModalityItem()
        {
            InitializeComponent();
            _username =  Session.Instance.LoggedUser;
            _events = new MyEventsController();

            foreach (Control c in uC_UnregisterButton1.Controls)
            {
                c.Click += Unregister;
            }

        }
        public void BringToFrontUnregister(bool state)
        {
            uC_UnregisterButton1.Visible = state;
        }

        public void ChangeJoinEventbtn(bool state)
        {
            btnJoinEvent.Visible = state;
        }

        public void ChangeCancelbtn(bool state)
        {
            btnCancel.Visible = state;
        }


        private void UC_EventModalityItem_Load(object sender, EventArgs e)
        {
            if (!events.CheckUserInEvent(EventId, _username))
            {
                btnJoinEvent.Visible = true;
               
            }
            else
            {
                btnJoinEvent.Visible = false;
                uC_UnregisterButton1.Visible = true;
            }

        }

        public void DisableJoinEventbtn()
        {
            btnJoinEvent.Visible = false;
        }

        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
            _events.JoinEvent(EventId, _username);
            MessageBox.Show("Juntou-se ao evento com sucesso!");
            btnJoinEvent.Enabled = false;
            uC_UnregisterButton1.Visible = true;
        }

        private void Unregister(object sender, EventArgs e)
        {
            _events.UnregisterUser(EventId, _username);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            events.DeleteEvent(Convert.ToInt32(EventId));
        }
    }
}
