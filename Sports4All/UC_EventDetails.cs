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
    public partial class UC_EventDetails : UserControl
    {
        public UC_EventDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void UC_EventDetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMaxPlayers_Click(object sender, EventArgs e)
        {

        }


        private void PopulateList()
        {
            UC_UserinEventItem[] listusers = new UC_UserinEventItem[20];

            for (int i = 0; i < listusers.Length; i++)
            {
                listusers[i] = new UC_UserinEventItem();
                listusers[i].Username = "Gouveia";
                listusers[i].PlayerId = "gouveia_user";
                //add to flowlayout
                if (flpUsersEvent.Controls.Count < 0)
                {

                    flpUsersEvent.Controls.Clear();
                }
                else
                {
                    flpUsersEvent.Controls.Add(listusers[i]);
                }
            }


        }
    }

}
