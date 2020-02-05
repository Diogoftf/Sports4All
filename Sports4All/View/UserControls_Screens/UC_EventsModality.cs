using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsModality : UserControl, IUserControl
    {
        private readonly MyEventsController _eventsController;
        private bool _controlSub;
        private int _id;
        private string _sportName;
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(UC_EventsModality));
        private BrowseParksController _browseParksController;
        public UC_EventsModality()
        {
            InitializeComponent();
            _browseParksController = new BrowseParksController();
            _eventsController = new MyEventsController();
            _username = Session.Instance.LoggedUser;
        }

        #region Properties

        public string Sport
        {
            get => _sportName;
            set
            {
                _sportName = value;
                tbModalityName.Text = value;
            }
        }
        private string _username { get; }

        public string Id { get; set; }

        #endregion

        public void PopulateItems(int key)
        {
            _id = Convert.ToInt32(Id);
            flpEventListModality.Controls.Clear();
            var EventsbySport = _eventsController.EventsBySport(_id,key);
            var EventsbySportCount = EventsbySport.Count;
            var Sport = _eventsController.RetrieveSingleSport(_id);
            tbModalityName.Text = Sport.ToList()[0].Name;
            foreach (var eventsportj in EventsbySport)
            {
                var _eventSport = new UC_NextEventsandReserveItem();
                var users = eventsportj.Users.ToList();
                var usersCount = eventsportj.Users.Count;
                var maxUsers = eventsportj.MaxPlayers;
                var hour = eventsportj.StartDate.ToShortTimeString();
                var date = eventsportj.StartDate.ToLongDateString();
                var partsOfDate = date.Split( );
                var month = partsOfDate[2].Substring(0, 3).ToUpper();
                _eventSport.EventID = Convert.ToString(eventsportj.EventId);
                _eventSport.Owner = eventsportj.Reserve.UserId;
                _eventSport.SportGround = eventsportj.Reserve.Ground.Park.Name;
                _eventSport.Hour = eventsportj.StartDate.ToShortTimeString();
                _eventSport.Day = Convert.ToString(eventsportj.StartDate.Day);
                _eventSport.Month = month;
                _eventSport.Sport = eventsportj.Reserve.Sport.Name;
                _eventSport.Lotation = usersCount + "/" + maxUsers;
                var eventItem = _eventsController.ChangeButtons(usersCount, maxUsers, _eventSport, users, _username);
                flpEventListModality.Controls.Add(_eventSport);
            }
        }

        private void onLoad(object sender, EventArgs e)
        {
           
            if (DesignMode) return;
            _id = Convert.ToInt32(Id);
            Populate();
        }
  
        public void PopulateLocationComboBox()
        {
            ICollection<int> countyIds = _browseParksController.GetReservesCountyIds();
            IDictionary<int, string> values = _browseParksController.GetLocationsDictionary(countyIds);

            values.Add(0, "");

            cbLocationFilter.DataSource = new BindingSource(values, null);
            cbLocationFilter.DisplayMember = "Value";
            cbLocationFilter.ValueMember = "Key";
            cbLocationFilter.SelectedValue = 0;
        }

        private void SortItemChanged(object sender, EventArgs e)
        {
            int key = ((KeyValuePair<int, string>)cbLocationFilter.SelectedItem).Key;
            PopulateItems(key);
        }

        public void Populate()
        {
            PopulateLocationComboBox();
            PopulateItems(0);
        }
    }
}