﻿using System;
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
    public partial class UC_Home : UserControl
    {
        private readonly HomeController _homeController;
        private List<UC_HomeMyEventsItem> _MyEvents = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private List<UC_HomeMyEventsItem> _EventSuggestions = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private List<Sport> _availableSports;
        //private LabelX lbStatsInfo = new LabelX("Pontuações: | Eventos Realizados: " + "\r\n" + "Eventos Realizados: 3" + "\r\n" + "Eventos Realizados: 3");

        public UC_Home()
        {
            InitializeComponent();
            _homeController = new HomeController();
            //InitializateElements();   // COMENTADO AS QUERYS DO HOME PORQUE SE ATIVADO AO ACEDER O FORM1 DESIGN APARECE ERROS DA CONNECTIONSTRING !!!
            flpInfoStats.Visible = false;
            infoStatsDescription(); // PROVISORIO

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            UC_CreateEvent1.Visible = true;
        }


        private void lbMySportDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpMySportDate_ValueChanged(object sender, EventArgs e)
        {
        /*    flpMyEvents.Controls.Clear();
            // MessageBox.Show(cbMySport.Text);

            if (cbMySport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < MyEvents.Count; i++)
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    if (MyEvents[i].DateTime == dtpMySportDate.Value.Date)
                    {
                        flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                    }

                }

            }*/
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            UC_CreateEvent1.Visible = false;
            dtpNextEventDate.MinDate = DateTime.Today;
            //InitializateElements();
            
        }

        private void InitializateElements()
        {
            PopulateLists(AuthProperties.LoggedUser);
            PopulateComboBox();
            infoStatsDescription();
            userStatsDetails();
        }

        private void infoStatsDescription()
        {
            rtbInfoStats.SelectionFont = new Font("Century Gothic", 11, FontStyle.Bold);
            rtbInfoStats.SelectionColor = Color.Black;
            rtbInfoStats.SelectedText = "Pontuações: \n\n";
            rtbInfoStats.SelectionFont = new Font("Century Gothic", 9);
            rtbInfoStats.SelectionColor = Color.Black;
            rtbInfoStats.SelectedText = "Reservas realizadas: " + Points._reservePerformed_Height + " pontos \n" + "Eventos realizados: " + Points._eventPerformed_Height + " pontos \n" + "Fairplay Global: " + Points._fairplay_Height + " pontos \n" + "Habilidade Global: " + Points._skill_Height + " pontos \n";
        }

        private void userStatsDetails()
        {
            lbMatchesPlayed.Text = _homeController.getMyStats(AuthProperties.LoggedUser);
        }

        private void lbHighlights_Click(object sender, EventArgs e)
        {

        }

        private void lbNextEventDate_Click(object sender, EventArgs e)
        {

        }

        private void PopulateComboBox()
        {
            _availableSports = _homeController.getSports();
            cbMySport.Items.Clear();
            cbNextSport.Items.Clear();

            cbMySport.Items.Add("");
            cbNextSport.Items.Add("");
            foreach (Sport s in _availableSports)
            {
                cbMySport.Items.Add(s.Name);
                cbNextSport.Items.Add(s.Name);
            }
        }

        private void PopulateLists(string username)
        {
            // Preenche list de meus eventos
            
            List<UC_HomeMyEventsItem> myEventsitems = new List<UC_HomeMyEventsItem>();
            List<Event> myEvent = _homeController.getMyEvents(username); // passar scarf para username
            flpMyEvents.Controls.Clear();
            flpEventSuggestions.Controls.Clear();
            _MyEvents.Clear();
            _EventSuggestions.Clear();

            if (myEvent.Count > 0)
            {
                for (int i = 0; i < myEvent.Count; i++)
                {
                    if (i < 3)
                    {
                        myEventsitems[i] = new UC_HomeMyEventsItem();
                        myEventsitems[i].DateTime = myEvent[i].StartDate.ToString() + " || " + myEvent[i].EndDate.ToShortTimeString();
                        myEventsitems[i].Organizador = myEvent[i].Reserve.UserId;
                        myEventsitems[i].Slots = myEvent[i].Users.Count + "/" + myEvent[i].MaxPlayers.ToString();
                        myEventsitems[i].Recinto = myEvent[i].Reserve.Ground.Park.Name;
                        myEventsitems[i].Sport = myEvent[i].Reserve.Sport.Name;

                        _MyEvents.Add(myEventsitems[i]);
                        flpMyEvents.Controls.Add(myEventsitems[i]); //add to flowlayout
                    }
                }
            }
            else
            {
                UC_HomeMyEventsItem noMyEventsitems = new UC_HomeMyEventsItem();
                noMyEventsitems.Sport = noMyEventsitems.Recinto = noMyEventsitems.Organizador = noMyEventsitems.DateTime = "";
                noMyEventsitems.NoEvents = username + " não estás em nenhum evento. :(";
                noMyEventsitems.DisableImage = null;
                noMyEventsitems.resetNameProprieties = "";
                flpMyEvents.Controls.Add(noMyEventsitems); //add to flowlayout
            }

            /*
            //Preenche lista de sugestoes de eventos
            List<UC_HomeMyEventsItem> myEventSuggestions = new List<UC_HomeMyEventsItem>();
            List<Reserve> EventSuggestions = _homeController.getEventSuggestions(username);
            flpEventSuggestions.Controls.Clear();

            for (int i = 0; i < EventSuggestions.Count; i++)
            {
                if (i < 3)
                {
                    myEventSuggestions[i] = new UC_HomeMyEventsItem();
                    myEventSuggestions[i].DateTime = myEvent[i].StartDate.ToString() + " || " + myEvent[i].EndDate.ToShortTimeString();
                    myEventSuggestions[i].Organizador = myEvent[i].Reserve.UserId;
                    myEventSuggestions[i].Slots = myEvent[i].Users.Count + "/" + myEvent[i].MaxPlayers.ToString();
                    myEventSuggestions[i].Recinto = myEvent[i].Reserve.Ground.Park.Name;
                    myEventSuggestions[i].Sport = myEvent[i].Reserve.Sport.Name;

                    _EventSuggestions.Add(myEventSuggestions[i]);
                    flpEventSuggestions.Controls.Add(myEventSuggestions[i]); //add to flowlayout
                }
            }
            */
        }

        private void cbMySport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            if (cbMySport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < _MyEvents.Count; i++)
                {
                    flpMyEvents.Controls.Add(_MyEvents[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < _MyEvents.Count; i++)
                {
                    if (_MyEvents[i].Sport == cbMySport.Text)
                    {
                        flpMyEvents.Controls.Add(_MyEvents[i]); //add to flowlayout
                    }

                }

            }

        }

        private void cbNextSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpEventSuggestions.Controls.Clear();

            if (cbNextSport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < _EventSuggestions.Count; i++)
                {
                    flpEventSuggestions.Controls.Add(_EventSuggestions[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < _EventSuggestions.Count; i++)
                {
                    if (_EventSuggestions[i].Sport == cbNextSport.Text)
                    {
                        flpEventSuggestions.Controls.Add(_EventSuggestions[i]); //add to flowlayout
                    }

                }

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pbInfo_MouseHover(object sender, EventArgs e)
        {
            flpInfoStats.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flpInfoStats.Visible = false;
        }

        private void rtbInfoStats_Click(object sender, EventArgs e)
        {

        }

        private void lbMatchesPlayed_Click(object sender, EventArgs e)
        {

        }

        private void pbInfo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            flpInfoStats.Visible = false;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
