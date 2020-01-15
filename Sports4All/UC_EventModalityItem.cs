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
