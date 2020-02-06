using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All.Patterns.State
{
    public partial class SelectSportState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;
        private CreateEventController _createEventController;

        public SelectSportState()
        {
            InitializeComponent();
        }

        public SelectSportState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
            _createEventController = new CreateEventController();
        }

        public string Id { get; set; }

        public void NextScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectLocationState);
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.EventNameState);
        }

        public void Populate()
        {
            PopulateComboBox();

            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        public void PopulateComboBox()
        {
            IDictionary<int, string> sports = _createEventController.GetSportsDictionary();

            cbSelectSport.DataSource = new BindingSource(sports, null);
            cbSelectSport.DisplayMember = "Value";
            cbSelectSport.ValueMember = "Key";

            if (sports.Count > 0)
            {
                foreach (KeyValuePair<int, string> pair in sports)
                {
                    cbSelectSport.SelectedValue = pair.Key;
                    EventCreationManager.Instance.SportId = pair.Key;
                    return;
                }
            }
            else
            {
                nextScreenButton.Hide();
            }
        }

        public void Display()
        {
            Form1.Instance.BringUcToFront<SelectSportState>("SelectSportState", "", _reserveNoviceForm);
        }

        private void SelectSportState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void cbSelectSport_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cbSelectSport.SelectedItem).Key;
            EventCreationManager.Instance.SportId = id;
        }

        private void cbSelectSport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextScreenButton_Load(object sender, EventArgs e)
        {

        }
    }
}
