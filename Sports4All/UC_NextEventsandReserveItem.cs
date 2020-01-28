﻿using System;
using System.Windows.Forms;
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
        }

        public void HideJoinButton()
        {
            btnCancel.Visible = false;
        }

        private void btn_CancelEvent(object sender, EventArgs e)
        {

            _eventsController.DeleteEvent(Convert.ToInt32(_eventId));

        }
        public void HideCancelReserve()
        {
            btnCancel.Visible = false;
        }
    }
}
