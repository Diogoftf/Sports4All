using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_EventModalityItem : UserControl
    {



        #region Properties

        private string _day;
        private string _month;
        private string _hour;
        private string _sportground;
        private string _owner;
        private string _lotation;

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
            get { return _sportground; }
            set { _sportground = value; lblSportsGround.Text = value; }
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
        public UC_EventModalityItem()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
