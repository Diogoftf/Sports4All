﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_MyEvents : UserControl
    {
        private readonly string _username = "andreMx";
        private readonly MyEventsController eventsController = new MyEventsController();


        private ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

        public UC_MyEvents()
        {
            InitializeComponent();
        }

        private int _totalUserEvents { get; set; }

        private void button_EventosTerminados_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_3(object sender, EventArgs e)
        {
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }


        private void button_ProximosEventos_Click(object sender, EventArgs e)
        {
            flpListMyEvents.Controls.Clear();

            // filtrar apenas pelas próximas partidas!
        }

        private void UC_MyEvents_Load(object sender, EventArgs e)
        {
            if (!DesignMode) FinishedEvents();
        }

        private void FinishedEvents()
        {
            if (flpListMyEvents.Controls.Count > 0)
                flpListMyEvents.Controls.Clear();
            var completedEvents = eventsController.RetrieveCompletedEvents(_username);
            var completedEventsCounts = completedEvents.Count;

            var listitems = new UC_EventMyEventsItem[completedEventsCounts];

            for (var i = 0; i < completedEventsCounts; i++)
            {
                //inverter if ; APENAS PARA TESTES, POUCOS DADOS NA BD
                if (eventsController.VerifyEvaluation(completedEvents.ToList()[i].EventId, _username)) { 
                listitems[i] = new UC_EventMyEventsItem
                {
                    Avaliar = "Avaliar",
                    EventID = Convert.ToString(completedEvents.ToList()[i].EventId),
                    Owner = completedEvents.ToList()[i].Reserve.UserId,
                    Sport = completedEvents.ToList()[i].Reserve.Sport.Name,
                    Date = completedEvents.ToList()[i].StartDate.ToLongDateString(),
                    Park = completedEvents.ToList()[i].Reserve.Ground.Park.Name,
                    MessageInfo = "Evento já avaliado!",
                    Change_BackColor = Color.Green
                }; 
                listitems[i].DisableButtonEvaluation();
                flpListMyEvents.Controls.Add(listitems[i]);
            }

            }
        }

        private void MyReserves()
        {
            if (flpListMyEvents.Controls.Count > 0)
                flpListMyEvents.Controls.Clear();
            var myReserves = eventsController.RetrieveUserReserves(_username);
            var myReservesCounts = myReserves.Count;
            var listitems = new UC_NextEventsandReserveItem[myReservesCounts];

            for (var i = 0; i < myReservesCounts; i++)
            {
                var usersCount = myReserves.ToList()[i].Event.Users.Count;
                var maxUsers = myReserves.ToList()[i].Event.MaxPlayers;
                var hour = myReserves.ToList()[i].Event.StartDate.ToShortTimeString();
                var month = myReserves.ToList()[i].Event.StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(myReserves.ToList()[i].Event.StartDate.Day),
                    Month = month,
                    Hour = myReserves.ToList()[i].Event.StartDate.ToShortTimeString(),
                    Owner = myReserves.ToList()[i].UserId,
                    SportGround = myReserves.ToList()[i].Ground.Park.Name,
                    Sport = myReserves.ToList()[i].Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(myReserves.ToList()[i].Event.EventId)
                };
                flpListMyEvents.Controls.Add(listitems[i]);
            }
        }

        private void btnNextEvents_Click(object sender, EventArgs e)
        {
            if (flpListMyEvents.Controls.Count > 0)
                flpListMyEvents.Controls.Clear();

            var nextEvents = eventsController.RetrieveNextEvents(_username);
            var nextEventsCount = nextEvents.Count;
            var listitems = new UC_NextEventsandReserveItem[nextEventsCount];
            for (var i = 0; i < nextEventsCount; i++)
            {
                var usersCount = nextEvents.ToList()[i].Users.Count;
                var maxUsers = nextEvents.ToList()[i].MaxPlayers;
                var hour = nextEvents.ToList()[i].StartDate.ToShortTimeString();
                var month = nextEvents.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_NextEventsandReserveItem
                {
                    Day = Convert.ToString(nextEvents.ToList()[i].StartDate.Day),
                    Month = month,
                    Hour = nextEvents.ToList()[i].StartDate.ToShortTimeString(),
                    Owner = nextEvents.ToList()[i].Reserve.UserId,
                    SportGround = nextEvents.ToList()[i].Reserve.Ground.Park.Name,
                    Sport = nextEvents.ToList()[i].Reserve.Sport.Name,
                    Lotation = usersCount + "/" + maxUsers,
                    EventID = Convert.ToString(nextEvents.ToList()[i].EventId)
                };
                flpListMyEvents.Controls.Add(listitems[i]);
            }
        }

        private void btnFinishedEvents_Click(object sender, EventArgs e)
        {
            if (flpListMyEvents.Controls.Count > 0)
                flpListMyEvents.Controls.Clear();

            if (!DesignMode) FinishedEvents();
        }

        private void btnMinhasReservas_Click(object sender, EventArgs e)
        {
            if (!DesignMode) MyReserves();
        }
    }
}