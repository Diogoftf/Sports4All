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
    public partial class UC_EventsSportsGrounds : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));

        private bool _controlSub = false;
        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
        }
        private void Recintos_Load(object sender, EventArgs e)
        {

            PopulateList();

        }

        private void PopulateList()
        {
            UC_EventSportsGroundItem[] listitems = new UC_EventSportsGroundItem[20];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new UC_EventSportsGroundItem();
                listitems[i].Day = "01";
                listitems[i].Month = "Fev";
                //add to flowlayout
                if (flpEventListSportsground.Controls.Count < 0)
                {

                    flpEventListSportsground.Controls.Clear();
                }
                else
                {
                    flpEventListSportsground.Controls.Add(listitems[i]);
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mouseHover(object sender, EventArgs e)
        {
            if (!_controlSub) tbSubSportsGroundNotification.Visible = true;

        }

        private void mouseLeave(object sender, EventArgs e)
        {
            tbSubSportsGroundNotification.Visible = false;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                tbSubSportsGroundNotification.Visible = false;
                _controlSub = true;
                //this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("sub_Button")));
                showNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            //retira subscrição!
            else
            {
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("subButton.Image")));
                _controlSub = false;

            }

        }

        private void showNotification(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;

            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }

            notifyIcon.ShowBalloonTip(30000);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void button_Tenis_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Events_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
