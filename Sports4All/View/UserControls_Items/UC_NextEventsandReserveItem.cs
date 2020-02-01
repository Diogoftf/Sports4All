using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using Renci.SshNet;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_NextEventsandReserveItem : UserControl
    {

        #region Properties

        private MyEventsController _eventsController = new MyEventsController();
        private string _day;
        private string _month;
        private string _hour;
        private string _owner;
        private string _sportground;
        private string _sport;
        private string _lotation;
        private string _eventId;
        private string _username;
        private ICommand Icommand;

        public string Username
        {
            get { return _username; }
            set { _username = value;}
        }
        public string EventID
        {
            get { return _eventId; }
            set { _eventId = value; lbEventID.Text = value; }
        }
        public string Lotation
        {
            get { return _lotation; }
            set { _lotation = value; lblSpaceAvailableValue.Text = value; }
        }
        public string Sport
        {
            get { return _sport; }
            set { _sport = value; lblModalityName.Text = value; }
        }
        public string SportGround
        {
            get { return _sportground; }
            set { _sportground = value; lblSportsGround.Text = value; }
        }
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; lblEventOwnerValue.Text = value; }
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
        public UC_NextEventsandReserveItem()
        {
           
            InitializeComponent();
            _username = Session.Instance.LoggedUser;
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

        private void Unregister(object sender, EventArgs e)
        {

            Icommand = new UnregisterCommand(this);
            Icommand.Execute();
            //_eventsController.UnregisterUser(Convert.ToInt32(_eventId), _username);
        }
        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
            Icommand = new JoinCommand(this);
            Icommand.Execute();
           // _eventsController.JoinEvent(Convert.ToInt32(EventID), _username);
            MessageBox.Show("Juntou-se ao evento com sucesso!");
            btnJoinEvent.Enabled = false;
            uC_UnregisterButton1.Visible = true;
        }

        private void btn_CancelEvent(object sender, EventArgs e)
        {
            Icommand = new CancelCommand(this);
            Icommand.Execute();
            //_eventsController.DeleteEvent(Convert.ToInt32(_eventId));
        }
    }
}
