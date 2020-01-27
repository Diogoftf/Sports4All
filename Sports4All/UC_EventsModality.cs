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
    public partial class UC_EventsModality : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));
        private readonly MyEventsController _eventsController = new MyEventsController();

        public int Id { get; set; }

        private bool _controlSub = false;

        private string _sportName;

        public string Sport
        {

            get { return _sportName; }
            set { _sportName = value; tbModalityName.Text = value; }

        }
        public UC_EventsModality()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mouseHover(object sender, EventArgs e)
        {
            if (!_controlSub) tbSubNotification.Visible = true;

        }

        private void mouseLeave(object sender, EventArgs e)
        {
            tbSubNotification.Visible = false;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                
                btnSub.Image = Image.FromFile(@"..\..\Images\" + "sub_Button.png");
                _controlSub = true;
                showNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            //retira subscrição!
            else
            {
                btnSub.Image = Image.FromFile(@"..\..\Images\" + "unsub_Button.png");
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

        private void onLoad(object sender, EventArgs e)
        {

            if (!DesignMode) ListEventsBySport();

        }

        public void ListEventsBySport()
        {
            flpEventListModality.Controls.Clear();

            var EventsbySport = _eventsController.EventsBySport(Id);
            var EventsbySportCount = EventsbySport.Count;
            UC_EventModalityItem[] listitems = new UC_EventModalityItem[EventsbySportCount];
            var Sport = _eventsController.RetrieveSingleSport(Id);
            tbModalityName.Text = Sport.ToList()[0].Name;
            for (int i = 0; i < EventsbySportCount; i++)
            {
                var usersCount = EventsbySport.ToList()[i].Users.Count;
                var maxUsers = EventsbySport.ToList()[i].MaxPlayers;
                var hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString();
                var month = EventsbySport.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_EventModalityItem
                {
                    EventId = EventsbySport.ToList()[i].EventId,
                    Owner = EventsbySport.ToList()[i].Reserve.UserId,
                    SportGround = EventsbySport.ToList()[i].Reserve.Ground.Park.Name,
                    Hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(EventsbySport.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers

                };
                if (usersCount == maxUsers) listitems[i].DisableJoinEventbtn(); // remove botao para se juntar ao evento
                flpEventListModality.Controls.Add(listitems[i]);

            }
        }

    }
}
