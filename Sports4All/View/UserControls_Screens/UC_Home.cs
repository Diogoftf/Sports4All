using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_Home : UserControl, IUserControl
    {
        private IReserveStrategy _reserveStrategy;
        private HomeController _homeController = new HomeController();
        private ICollection<UC_HomeMyEventsItem> _MyEvents = new List<UC_HomeMyEventsItem>();
        private ICollection<UC_HomeMyEventsItem> _EventSuggestions = new List<UC_HomeMyEventsItem>();
        private ICollection<Sport> _availableSports;
        private UC_HomeMyEventsItem _noMyEventsitems = new UC_HomeMyEventsItem();
        private UC_HomeMyEventsItem _noSuggestionsEventsitems = new UC_HomeMyEventsItem();
        private RankController _rankController = new RankController();
        private double _pointsToNextLevel { get; set; }

        private double _pbUnit;
        private int _pbWIDTH, _pbHEIGHT, _pbComplete;
        private Bitmap _bmp;
        private Graphics _graphic;
        private Timer _timerProgressBar = new Timer();

        public UC_Home()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            if (!DesignMode)
            {
                flpInfoStats.Visible = false;
                ProgressBarInitializer();
                dtpNextEventDate.MinDate = dtpMySportDate.MinDate = DateTime.Now;
                dtpMySportDate.Format = dtpNextEventDate.Format = DateTimePickerFormat.Custom;
                dtpMySportDate.CustomFormat = dtpNextEventDate.CustomFormat = "dd-MM-yyyy";

                _noMyEventsitems.Sport = _noMyEventsitems.Recinto = _noMyEventsitems.Owner = _noMyEventsitems.DateTime = "";
                _noMyEventsitems.NoEvents = "Não tens nenhum evento :(";
                _noMyEventsitems.DisableImage = null;
                _noMyEventsitems.resetNameProprieties = "";

                _noSuggestionsEventsitems.Sport = _noMyEventsitems.Recinto = _noMyEventsitems.Owner = _noMyEventsitems.DateTime = "";
                _noSuggestionsEventsitems.NoEvents = "Não existem sugestões :(";
                _noSuggestionsEventsitems.DisableImage = null;
                _noSuggestionsEventsitems.resetNameProprieties = "";

                PopulateMyEventsList();
                PopulateMySuggestionsList();
                PopulateComboBox();
                InfoStatsDescription();
                UserStatsDetails();
                GetTopClassificationDetails();
                PointsRemaining();
            }
        }

        private void GetTopClassificationDetails()
        {
            using (var db = new ModelContext())
            {
                var userQuery = db.Classifications.OfType<UserClassification>().OrderByDescending(e => e.Points).Take(1).FirstOrDefault();
                var parkQuery = db.Classifications.OfType<ParkClassification>().OrderByDescending(e => e.Points).Take(1).FirstOrDefault();

                pbMonthuser.Image = ImagesController.Instance.GetImageFromID(userQuery.User.PictureId);
                pbMonthEnclosure.Image = ImagesController.Instance.GetImageFromID(parkQuery.Park.Picture.PictureId);
                lbUserName.Text = userQuery.User.Username;
                lbParkName.Text = parkQuery.Park.Name;
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            OpenCreateReserveForm();
        }

        private void OpenCreateReserveForm()
        {
            if (Session.Instance.IsExperientUser)
            {
                _reserveStrategy = new ExpertReserveStrategy();
            }
            else
            {
                _reserveStrategy = new NoviceReserveStrategy();
            }
            _reserveStrategy.DisplayReserveForm();
        }

        public void ProgressBarInitializer()
        {
            _pbWIDTH = pbProgressBar.Width;
            _pbHEIGHT = pbProgressBar.Height;
            _pbUnit = _pbWIDTH / 100.0;
            _pbComplete = 0;
            _bmp = new Bitmap(_pbWIDTH, _pbHEIGHT);
            _timerProgressBar.Tick += new EventHandler(FillProgressBar);
            _timerProgressBar.Interval = 10;
            _timerProgressBar.Start();
        }

        private void PointsRemaining()
        {
            var aux = double.Parse(lbNextLevel.Text) * 100.0;

            _pointsToNextLevel = 100 - (aux - double.Parse(_homeController.GetMyStats().ToList()[4]));
        }

        private void FillProgressBar(object sender, EventArgs e)
        {
            _graphic = Graphics.FromImage(_bmp);
            if (_pbComplete >= _pointsToNextLevel)
            {
                _graphic.Dispose();
                _timerProgressBar.Stop();
            }
            else
            {
                _graphic.Clear(Color.LightGray);
                _graphic.FillRectangle(Brushes.LightGreen, new Rectangle(0, 0, (int)(_pbComplete * _pbUnit), _pbHEIGHT));
                _graphic.DrawString(_pbComplete.ToString() + " pts", new Font("Arial", _pbHEIGHT / 2), Brushes.Black, new PointF((_pbWIDTH / 2) - _pbHEIGHT, _pbHEIGHT / 10));
                pbProgressBar.Image = _bmp;
                _pbComplete++;
            }
        }

        private void dtpMySportDate_ValueChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            foreach (var ev in _MyEvents)
            {
                string[] dateStart = ev.DateTime.Split(new string[] { " || " }, StringSplitOptions.None);

                if (DateTime.Parse(dateStart[0]).Date.ToString("dd-MM-yyyy").Equals(dtpMySportDate.Value.Date.ToString("dd-MM-yyyy"))
                    || DateTime.Now.ToString("dd-MM-yyyy").Equals(dtpMySportDate.Value.Date.ToString("dd-MM-yyyy")))
                {
                    flpMyEvents.Controls.Add(ev);
                }
            }

            if (flpMyEvents.Controls.Count == 0)
                flpMyEvents.Controls.Add(_noMyEventsitems);
        }

        private void InfoStatsDescription()
        {
            rtbInfoStats.Clear();
            rtbInfoStats.SelectionFont = new Font("Century Gothic", 11, FontStyle.Bold);
            rtbInfoStats.SelectionColor = Color.Black;
            rtbInfoStats.SelectedText = "Pontuações: \n\n";
            rtbInfoStats.SelectionFont = new Font("Century Gothic", 9);
            rtbInfoStats.SelectionColor = Color.Black;
            rtbInfoStats.SelectedText = "Reservas realizadas: " + _rankController._reservePerformed_Weight + " pontos \n" + "Eventos realizados: " + _rankController._eventPerformed_Weight + " pontos \n" + "Fairplay Global: " + _rankController._fairplay_Weight + " pontos \n" + "Habilidade Global: " + _rankController._skill_Weight + " pontos \n";
        }

        private void UserStatsDetails()
        {

            var current = Math.Truncate(double.Parse(_homeController.GetMyStats().ToList()[4]) / _rankController._levelChange);
            lbCurrentLevel.Text = current.ToString();
            lbNextLevel.Text = (current + 1).ToString();

            if (_homeController.GetMyStats().Any())
            {
                lbMatchesPlayedValue.Text = _homeController.GetMyStats().ToList()[0];
                lbFairplayValue.Text = _homeController.GetMyStats().ToList()[1];
                lbSkillValue.Text = _homeController.GetMyStats().ToList()[2];
                lbRacioValue.Text = _homeController.GetMyStats().ToList()[3];
            }

        }

        private void PopulateComboBox()
        {
            _availableSports = _homeController.GetSports();
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
            ICollection<Event> myEventsList = _homeController.getMyEvents();
            flpMyEvents.Controls.Clear();
            flpEventSuggestions.Controls.Clear();
            _MyEvents.Clear();
            _EventSuggestions.Clear();

            if (myEventsList.Any())
            {
                for (int i = 0; i < myEventsList.Count; i++)
                {
                    if (i < 3)
                    {
                        UC_HomeMyEventsItem ItemMyEvents = new UC_HomeMyEventsItem
                        {
                            DateTime = myEventsList.ToList()[i].StartDate.ToString("dd/MM/yyyy HH:mm")
                            + " || "
                            + myEventsList.ToList()[i].EndDate.ToString("HH:mm"),
                            Owner = myEventsList.ToList()[i].Reserve.UserId,
                            Slots = myEventsList.ToList()[i].Users.Count.ToString() + "/" + myEventsList.ToList()[i].MaxPlayers.ToString(),
                            Recinto = myEventsList.ToList()[i].Reserve.Ground.Park.Name,
                            Sport = myEventsList.ToList()[i].Reserve.Sport.Name,
                            Image = ImagesController.Instance.GetImageFromID(myEventsList.ToList()[i].Reserve.Sport.Picture.PictureId),
                            Id = myEventsList.ToList()[i].EventId
                        };
                        _MyEvents.Add(ItemMyEvents);
                        flpMyEvents.Controls.Add(ItemMyEvents);
                    }
                }
            }
            else
            {
                flpMyEvents.Controls.Add(_noMyEventsitems);
            }
        }

        private void PopulateMySuggestionsList()
        {
            ICollection<Reserve> EventSuggestions = _homeController.GetEventSuggestions();
            flpEventSuggestions.Controls.Clear();

            if (EventSuggestions.Any())
            {
                for (int i = 0; i < EventSuggestions.Count; i++)
                {
                    if (i < 3)
                    {
                        UC_HomeMyEventsItem ItemSuggestion = new UC_HomeMyEventsItem
                        {
                            DateTime = EventSuggestions.ToList()[i].Event.StartDate.ToString()
                            + " || "
                            + EventSuggestions.ToList()[i].Event.EndDate.ToShortTimeString(),
                            Owner = EventSuggestions.ToList()[i].UserId,
                            Slots = EventSuggestions.ToList()[i].Event.Users.Count + "/" + EventSuggestions.ToList()[i].Event.MaxPlayers.ToString(),
                            Recinto = EventSuggestions.ToList()[i].Ground.Park.Name,
                            Sport = EventSuggestions.ToList()[i].Sport.Name,
                            Id = EventSuggestions.ToList()[i].Event.EventId,
                            DisableDeleteImage = null
                        };
                        _EventSuggestions.Add(ItemSuggestion);
                        flpEventSuggestions.Controls.Add(ItemSuggestion);
                    }
                }
            }
            else
            {
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems);
            }
        }

        private void cbMySport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            if (_MyEvents.Any())
            {
                switch (cbMySport.SelectedIndex)
                {
                    case 0:
                        {
                            foreach (var ev in _MyEvents)
                            {
                                flpMyEvents.Controls.Add(ev);
                            }

                            break;
                        }

                    default:
                        {
                            foreach (var ev in _MyEvents)
                            {
                                if (ev.Sport.Equals(cbMySport.Text))
                                {
                                    flpMyEvents.Controls.Add(ev);
                                }
                            }

                            break;
                        }
                }
            }

            if (flpMyEvents.Controls.Count == 0)
                flpMyEvents.Controls.Add(_noMyEventsitems);
        }

        private void cbNextSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpEventSuggestions.Controls.Clear();

            if (_EventSuggestions.Any())
            {
                switch (cbNextSport.SelectedIndex)
                {
                    case 0:
                        {
                            foreach (var ev in _EventSuggestions)
                            {
                                flpEventSuggestions.Controls.Add(ev);
                            }
                            break;
                        }

                    default:
                        {
                            foreach (var ev in _EventSuggestions)
                            {
                                if (ev.Sport.Equals(cbNextSport.Text))
                                {
                                    flpEventSuggestions.Controls.Add(ev);
                                }
                            }

                            break;
                        }
                }
            }
            if (flpEventSuggestions.Controls.Count == 0)
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems);
        }

        private void pbInfo_MouseHover(object sender, EventArgs e)
        {
            flpInfoStats.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flpInfoStats.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            flpInfoStats.Visible = false;
        }

        private void dtpNextEventDate_ValueChanged(object sender, EventArgs e)
        {
            flpEventSuggestions.Controls.Clear();

            foreach (var ev in _EventSuggestions)
            {
                string[] dateStart = ev.DateTime.Split(new string[] { " || " }, StringSplitOptions.None);

                if (DateTime.Parse(dateStart[0]).Date.ToString("dd-MM-yyyy").Equals(dtpNextEventDate.Value.Date.ToString("dd-MM-yyyy"))
                    || DateTime.Now.ToString("dd-MM-yyyy").Equals(dtpNextEventDate.Value.Date.ToString("dd-MM-yyyy")))
                {
                    flpEventSuggestions.Controls.Add(ev);
                }
            }

            if (flpEventSuggestions.Controls.Count == 0)
                flpEventSuggestions.Controls.Add(_noSuggestionsEventsitems);
        }
    }
}
