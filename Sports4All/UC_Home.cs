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
    public partial class UC_Home : UserControl
    {
        private readonly HomeController _homeController;
        private List<UC_HomeMyEventsItem> _MyEvents = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private List<UC_HomeMyEventsItem> _EventSuggestions = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private List<Sport> _availableSports;
        private UC_HomeMyEventsItem noMyEventsitems = new UC_HomeMyEventsItem();
        private UC_HomeMyEventsItem noSuggestionsEventsitems = new UC_HomeMyEventsItem();
  

        public UC_Home()
        {
            InitializeComponent();
            _homeController = new HomeController();
            InitializateElements();   // COMENTADO AS QUERYS DO HOME PORQUE SE ATIVADO AO ACEDER O FORM1 DESIGN APARECE ERROS DA CONNECTIONSTRING !!!
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

            noMyEventsitems.Sport = noMyEventsitems.Recinto = noMyEventsitems.Organizador = noMyEventsitems.DateTime = "";
            noMyEventsitems.NoEvents = AuthProperties.LoggedUser + " não estás em nenhum evento :(";
            noMyEventsitems.DisableImage = null;
            noMyEventsitems.resetNameProprieties = "";

            noSuggestionsEventsitems.Sport = noMyEventsitems.Recinto = noMyEventsitems.Organizador = noMyEventsitems.DateTime = "";
            noSuggestionsEventsitems.NoEvents = "Não existem sugestões :(";
            noSuggestionsEventsitems.DisableImage = null;
            noSuggestionsEventsitems.resetNameProprieties = "";

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
            lbMatchesPlayedValue.Text = _homeController.getMyStats(AuthProperties.LoggedUser)[0];
            lbFairplayValue.Text = _homeController.getMyStats(AuthProperties.LoggedUser)[1];
            lbSkillValue.Text = _homeController.getMyStats(AuthProperties.LoggedUser)[2];
            lbRacioValue.Text = _homeController.getMyStats(AuthProperties.LoggedUser)[3];
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
            // Array auxiliar de meus eventos
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
                        UC_HomeMyEventsItem ItemMyEvents = new UC_HomeMyEventsItem();
                        ItemMyEvents.DateTime = myEvent[i].StartDate.ToString() + " || " + myEvent[i].EndDate.ToShortTimeString();
                        ItemMyEvents.Organizador = myEvent[i].Reserve.UserId;
                        ItemMyEvents.Slots = /* myEvent[i].Users.Count + */ "/" + myEvent[i].MaxPlayers.ToString();
                        ItemMyEvents.Recinto = /* myEvent[i].Reserve.Ground.Park.Name; */ "Espera da criação de eventos";
                        ItemMyEvents.Sport = /* myEvent[i].Reserve.Sport.Name;*/ "Espera da criação de eventos";
                        _MyEvents.Add(ItemMyEvents);
                        flpMyEvents.Controls.Add(ItemMyEvents); //add to flowlayout
                    }
                }
            }
            else
            {
                flpMyEvents.Controls.Add(noMyEventsitems); //add to flowlayout
            }


            //Preenche lista de sugestoes de eventos
            List<Reserve> EventSuggestions = new List<Reserve>(); // _homeController.getEventSuggestions(username);
            flpEventSuggestions.Controls.Clear();

            if (EventSuggestions.Count > 0)
            {
                for (int i = 0; i < EventSuggestions.Count; i++)
                {
                    if (i < 3)
                    {
                        UC_HomeMyEventsItem ItemSuggestion = new UC_HomeMyEventsItem();
                        /*  ItemSuggestion.DateTime = EventSuggestions[i].StartDate.ToString() + " || " + EventSuggestions[i].EndDate.ToShortTimeString();
                          ItemSuggestion.Organizador = EventSuggestions[i].Reserve.UserId;
                          ItemSuggestion.Slots =  EventSuggestions[i].Users.Count +  "/" + EventSuggestions[i].MaxPlayers.ToString();
                          ItemSuggestion.Recinto =  EventSuggestions[i].Reserve.Ground.Park.Name;  "Espera da criação de eventos";
                          ItemSuggestion.Sport =  EventSuggestions[i].Reserve.Sport.Name; "Espera da criação de eventos";*/
                        _EventSuggestions.Add(ItemSuggestion);
                        flpEventSuggestions.Controls.Add(ItemSuggestion); //add to flowlayout
                    }
                }
            }
            else
            {
                flpEventSuggestions.Controls.Add(noSuggestionsEventsitems); //add to flowlayout
            }


        }

        private void cbMySport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            if (_MyEvents.Count > 0)
            {
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

            if(flpMyEvents.Controls.Count == 0 )
                flpMyEvents.Controls.Add(noMyEventsitems);
        }

        private void cbNextSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpEventSuggestions.Controls.Clear();

            if (_EventSuggestions.Count > 0)
            {
                if (cbNextSport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
                {
                    for (int i = 0; i < _EventSuggestions.Count; i++)
                    {
                        flpEventSuggestions.Controls.Add(_EventSuggestions[i]); //add to flowlayout
                    }
                }
                else
                {
                    for (int i = 0; i < _MyEvents.Count; i++)
                    {
                        if (_EventSuggestions[i].Sport == cbNextSport.Text)
                        {
                            flpEventSuggestions.Controls.Add(_EventSuggestions[i]); //add to flowlayout
                        }

                    }
                }
            }

            if (flpEventSuggestions.Controls.Count == 0)
                flpEventSuggestions.Controls.Add(noSuggestionsEventsitems);
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
