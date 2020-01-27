using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsModality : UserControl
    {
        private readonly MyEventsController _eventsController = new MyEventsController();

        private bool _controlSub;

        private string _sportName;
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(UC_EventsModality));

        public UC_EventsModality()
        {
            _username = Session.Instance.LoggedUser;
            InitializeComponent();
        }

        public int Id { get; set; }
        private string _username { get; }

        public string Sport
        {
            get => _sportName;
            set
            {
                _sportName = value;
                tbModalityName.Text = value;
            }
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
                showNotification("Recinto Subscrito!",
                    "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
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
            var notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;

            if (title != null) notifyIcon.BalloonTipTitle = title;

            if (body != null) notifyIcon.BalloonTipText = body;

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
            var listitems = new UC_EventModalityItem[EventsbySportCount];
            var Sport = _eventsController.RetrieveSingleSport(Id);
            tbModalityName.Text = Sport.ToList()[0].Name;
            for (var i = 0; i < EventsbySportCount; i++)
            {
                var users = EventsbySport.ToList()[i].Users.ToList();
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
                if (usersCount == maxUsers)
                    listitems[i].ChangeJoinEventbtn(false); // remove botao para se juntar ao evento

                foreach (var user in users)
                {
                    if (user.Username == _username) // já estou no evento
                    {
                        listitems[i].ChangeJoinEventbtn(false);
                        if (listitems[i].Owner.Equals(_username))
                        {
                            // sou o owner, botao de remover evento
                            listitems[i].ChangeCancelbtn(true);
                           
                        }
                        else
                        {
                            listitems[i].ChangeJoinEventbtn(false);
                            listitems[i].BringToFrontUnregister(true);
                        }
                        break;
                    }
                    // se nao encontrar o user nao faz nada, o joinBtn por defeito está a true
                }
                flpEventListModality.Controls.Add(listitems[i]);
            }
        }

        private void lblTitleFilter_Click(object sender, EventArgs e)
        {
        }
    }
}