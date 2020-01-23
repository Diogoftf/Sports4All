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
    public partial class UC_EventsSportsGrounds : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));
        private readonly MyEventsController _eventsController = new MyEventsController();
        private string _sportGround { get; set; }
        private bool _controlSub = false;
        public UC_EventsSportsGrounds()
        {
            InitializeComponent();
        }
        private void Recintos_Load(object sender, EventArgs e)
        {
            _sportGround = "Agua de Pena";
            if (!DesignMode) ListEventsbyGround();
        }

        private void ListEventsbyGround()
        {
            if (flpEventListSportsground.Controls.Count > 0)
                flpEventListSportsground.Controls.Clear();
            var EventsbyGround = _eventsController.EventsbyGround(_sportGround);
            var EventsbyGroundCount = EventsbyGround.Count;

            UC_EventSportsGroundItem[] listitems = new UC_EventSportsGroundItem[EventsbyGroundCount];

            for (int i = 0; i < EventsbyGroundCount; i++)
            {
                var usersCount = EventsbyGround.ToList()[i].Users.Count;
                var maxUsers = EventsbyGround.ToList()[i].MaxPlayers;
                var hour = EventsbyGround.ToList()[i].StartDate.ToShortTimeString();
                var month = EventsbyGround.ToList()[i].StartDate.ToLongDateString();

                listitems[i] = new UC_EventSportsGroundItem
                {
                Owner = EventsbyGround.ToList()[0].Reserve.UserId,
                SportGround = EventsbyGround.ToList()[0].Reserve.Ground.Park.Name,
                Hour = EventsbyGround.ToList()[i].StartDate.ToShortTimeString(),
                Day = Convert.ToString(EventsbyGround.ToList()[i].StartDate.Day),
                Month = month,
                Lotation = usersCount + "/" + maxUsers
                };

                if (usersCount == maxUsers) listitems[i].DisableJoinEventbtn(); // remove botao para se juntar ao evento
                flpEventListSportsground.Controls.Add(listitems[i]);
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
