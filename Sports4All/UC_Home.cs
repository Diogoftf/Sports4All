﻿using System;
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
        private HomeController _homeController;
        private ICollection<UC_HomeMyEventsItem> _MyEvents = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private ICollection<UC_HomeMyEventsItem> _EventSuggestions = new List<UC_HomeMyEventsItem>(); // pensar se fica ou nao
        private ICollection<Sport> _availableSports;
        private UC_HomeMyEventsItem _noMyEventsitems = new UC_HomeMyEventsItem();
        private UC_HomeMyEventsItem _noSuggestionsEventsitems = new UC_HomeMyEventsItem();

        // Progress Bar//
        private double _pbUnit;
        private int _pbWIDTH, _pbHEIGHT, _pbComplete;
        private Bitmap _bmp;
        private Graphics _graphic;
        private Timer _timerProgressBar = new Timer();

        public UC_Home()
        {
            InitializeComponent();


        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            UC_CreateEvent1.Visible = true;
        }


        private void lbMySportDate_Click(object sender, EventArgs e)
        {

        }

        public void ProgressBarInitializer()
        {
            _pbWIDTH = pbProgressBar.Width;
            _pbHEIGHT = pbProgressBar.Height;
            _pbUnit = _pbWIDTH / 100.0;
            _pbComplete = 0;
            _bmp = new Bitmap(_pbWIDTH, _pbHEIGHT);  
            _timerProgressBar.Tick += new EventHandler(this.FillProgressBar);
            _timerProgressBar.Interval = 10;
            _timerProgressBar.Start();
        }

        private void FillProgressBar(object sender, EventArgs e)
        {
            _graphic = Graphics.FromImage(_bmp);
            _graphic.Clear(Color.LightGray);
            _graphic.FillRectangle(Brushes.LightGreen, new Rectangle(0, 0, (int)(_pbComplete * _pbUnit), _pbHEIGHT));
            _graphic.DrawString(_pbComplete.ToString() + " pts", new Font("Arial", _pbHEIGHT / 2), Brushes.Black, new PointF(_pbWIDTH / 2 - _pbHEIGHT, _pbHEIGHT / 10));
            pbProgressBar.Image = _bmp;
            _pbComplete++;
            if (_pbComplete > double.Parse(_homeController.getMyStats().ToList()[4]))
            {
                _graphic.Dispose();
                _timerProgressBar.Stop();
            }

        }

        private void dtpMySportDate_ValueChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            for (int i = 0; i < _MyEvents.Count; i++)
            {
                string[] dateStart = _MyEvents.ToList()[i].DateTime.Split(new string[] { " || " }, StringSplitOptions.None);

                if (DateTime.Parse(dateStart[0]).Date.ToString("dd-MM-yyyy") == dtpMySportDate.Value.Date.ToString("dd-MM-yyyy") || DateTime.Now.ToString("dd-MM-yyyy") == dtpMySportDate.Value.Date.ToString("dd-MM-yyyy"))
                {
                    flpMyEvents.Controls.Add(_MyEvents.ToList()[i]); //add to flowlayout
                }

            }

            if(flpMyEvents.Controls.Count == 0)
                flpMyEvents.Controls.Add(_noMyEventsitems);
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                
                _homeController = new HomeController();
                InitializateElements();
            }

        }

        private void InitializateElements()
        {
            UC_CreateEvent1.Visible = false;
            flpInfoStats.Visible = false;
            ProgressBarInitializer();
            dtpNextEventDate.MinDate = dtpMySportDate.MinDate = DateTime.Now;
            dtpMySportDate.Format = dtpNextEventDate.Format = DateTimePickerFormat.Custom;
            dtpMySportDate.CustomFormat = dtpNextEventDate.CustomFormat = "dd-MM-yyyy";

            _noMyEventsitems.Sport = _noMyEventsitems.Recinto = _noMyEventsitems.Organizador = _noMyEventsitems.DateTime = "";
            _noMyEventsitems.NoEvents = "Não tens nenhum evento :(";
            _noMyEventsitems.DisableImage = null;
            _noMyEventsitems.resetNameProprieties = "";

            _noSuggestionsEventsitems.Sport = _noMyEventsitems.Recinto = _noMyEventsitems.Organizador = _noMyEventsitems.DateTime = "";
            _noSuggestionsEventsitems.NoEvents = "Não existem sugestões :(";
            _noSuggestionsEventsitems.DisableImage = null;
            _noSuggestionsEventsitems.resetNameProprieties = "";

            PopulateMyEventsList();
            PopulateMySuggestionsList();
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
            rtbInfoStats.SelectedText = "Reservas realizadas: " + Points._reservePerformed_Weight + " pontos \n" + "Eventos realizados: " + Points._eventPerformed_Weight + " pontos \n" + "Fairplay Global: " + Points._fairplay_Weight + " pontos \n" + "Habilidade Global: " + Points._skill_Weight + " pontos \n";
        }

        private void userStatsDetails()
        {
            var current = Convert.ToInt32(double.Parse(_homeController.getMyStats().ToList()[4]) / Points._levelChange);
            lbCurrentLevel.Text = current.ToString();
            lbNextLevel.Text = (current+1).ToString();
            if (_homeController.getMyStats().ToList().Count > 0)
            {
                lbMatchesPlayedValue.Text = _homeController.getMyStats().ToList()[0];
                lbFairplayValue.Text = _homeController.getMyStats().ToList()[1];
                lbSkillValue.Text = _homeController.getMyStats().ToList()[2];
                lbRacioValue.Text = _homeController.getMyStats().ToList()[3];
            }

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

        private void PopulateMyEventsList()
        {
            ICollection<Event> myEvent = _homeController.getMyEvents(); // passar scarf para username
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
                        ItemMyEvents.DateTime = myEvent.ToList()[i].StartDate.ToString() + " || " + myEvent.ToList()[i].EndDate.ToString("HH:mm");
                        ItemMyEvents.Organizador = myEvent.ToList()[i].Reserve.UserId;
                        ItemMyEvents.Slots = myEvent.ToList()[i].Users.Count.ToString() + "/" + myEvent.ToList()[i].MaxPlayers.ToString();
                        ItemMyEvents.Recinto = myEvent.ToList()[i].Reserve.Ground.Park.Name;
                        ItemMyEvents.Sport = myEvent.ToList()[i].Reserve.Sport.Name;
                        ItemMyEvents.Id = myEvent.ToList()[i].EventId;
                        _MyEvents.Add(ItemMyEvents);
                        flpMyEvents.Controls.Add(ItemMyEvents); //add to flowlayout
                    }
                }
            }
            else
            {
                flpMyEvents.Controls.Add(_noMyEventsitems); //add to flowlayout
            }
        }

        private void PopulateMySuggestionsList()
        {
            ICollection<Reserve> EventSuggestions = _homeController.getEventSuggestions();
            flpEventSuggestions.Controls.Clear();

            if (EventSuggestions.Count > 0)
            {
                for (int i = 0; i < EventSuggestions.Count; i++)
                {
                    if (i < 3)
                    {
                        UC_HomeMyEventsItem ItemSuggestion = new UC_HomeMyEventsItem();
                        ItemSuggestion.DateTime = EventSuggestions.ToList()[i].Event.StartDate.ToString() + " || " + EventSuggestions.ToList()[i].Event.EndDate.ToShortTimeString();
                        ItemSuggestion.Organizador = EventSuggestions.ToList()[i].UserId;
                        ItemSuggestion.Slots = EventSuggestions.ToList()[i].Event.Users.Count + "/" + EventSuggestions.ToList()[i].Event.MaxPlayers.ToString();
                        ItemSuggestion.Recinto = EventSuggestions.ToList()[i].Ground.Park.Name;
                        ItemSuggestion.Sport = EventSuggestions.ToList()[i].Sport.Name;
                        _EventSuggestions.Add(ItemSuggestion);
                        flpEventSuggestions.Controls.Add(ItemSuggestion); //add to flowlayout
                    }
                }
            }
            else
            {
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems); //add to flowlayout
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
                        flpMyEvents.Controls.Add(_MyEvents.ToList()[i]); //add to flowlayout
                    }
                }
                else
                {
                    for (int i = 0; i < _MyEvents.Count; i++)
                    {
                        if (_MyEvents.ToList()[i].Sport == cbMySport.Text)
                        {
                            flpMyEvents.Controls.Add(_MyEvents.ToList()[i]); //add to flowlayout
                        }

                    }
                }
            }

            if(flpMyEvents.Controls.Count == 0 )
                flpMyEvents.Controls.Add(_noMyEventsitems);
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
                        flpEventSuggestions.Controls.Add(_EventSuggestions.ToList()[i]); //add to flowlayout
                    }
                }
                else
                {
                    for (int i = 0; i < _EventSuggestions.Count; i++)
                    {
                        if (_EventSuggestions.ToList()[i].Sport == cbNextSport.Text)
                        {
                            flpEventSuggestions.Controls.Add(_EventSuggestions.ToList()[i]); //add to flowlayout
                        }

                    }
                }
            }

            if (flpEventSuggestions.Controls.Count == 0)
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems);
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

        private void lbNextLevel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpNextEventDate_ValueChanged(object sender, EventArgs e)
        {
            flpEventSuggestions.Controls.Clear();

            for (int i = 0; i < _EventSuggestions.Count; i++)
            {
                string[] dateStart = _EventSuggestions.ToList()[i].DateTime.Split(new string[] { " || " }, StringSplitOptions.None);

                if (DateTime.Parse(dateStart[0]).Date.ToString("dd-MM-yyyy") == dtpNextEventDate.Value.Date.ToString("dd-MM-yyyy") || DateTime.Now.ToString("dd-MM-yyyy") == dtpNextEventDate.Value.Date.ToString("dd-MM-yyyy"))
                {
                    flpEventSuggestions.Controls.Add(_EventSuggestions.ToList()[i]); //add to flowlayout
                }

            }

            if (flpEventSuggestions.Controls.Count == 0)
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems);
        }
    }
}
