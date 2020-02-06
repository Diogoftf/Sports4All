using Sports4All.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sports4All.Patterns.State
{
    public partial class SelectLocationState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;
        private CreateEventController _createEventController;

        public SelectLocationState()
        {
            InitializeComponent();
        }

        public SelectLocationState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
            _createEventController = new CreateEventController();
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<SelectLocationState>("SelectLocationState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectHourParkState);
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectSportState);
        }

        public void Populate()
        {
            PopulateComboBox();

            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        public void PopulateComboBox()
        {
            int sportId = EventCreationManager.Instance.SportId;
            IDictionary<int, string> locations = _createEventController.GetLocationsDictionary(sportId);

            cbSelectLocation.DataSource = new BindingSource(locations, null);
            cbSelectLocation.DisplayMember = "Value";
            cbSelectLocation.ValueMember = "Key";

            if (locations.Any())
            {
                foreach (KeyValuePair<int, string> pair in locations)
                {
                    cbSelectLocation.SelectedValue = pair.Key;
                    EventCreationManager.Instance.LocationId = pair.Key;
                    return;
                }
            }
            else
            {
                nextScreenButton.Hide();
            }
        }

        private void SelectLocationState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void cbSelectLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cbSelectLocation.SelectedItem).Key;
            EventCreationManager.Instance.LocationId = id;
        }
    }
}
