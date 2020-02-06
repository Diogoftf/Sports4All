using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;
using Sports4All.Decorator;

namespace Sports4All.Patterns.State
{
    public partial class SelectHourParkState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;
        private CreateEventController _createEventController;
        public SelectHourParkState()
        {
            InitializeComponent();
        }

        public SelectHourParkState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _createEventController = new CreateEventController();
            _reserveNoviceForm = reserveNoviceForm;
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<SelectHourParkState>("SelectHourParkState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            SetDateTimeValues();
            DecorateGroundFromParkSelected();
            _reserveNoviceForm.SetState(_reserveNoviceForm.AskForMaterialState);
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectLocationState);
        }

        public void DecorateGroundFromParkSelected()
        {
                var sport = _createEventController.GetSportFromId(EventCreationManager.Instance.SportId);
                var parkId = _createEventController.GetParkFromId(EventCreationManager.Instance.ParkId).ParkId;
                var parkGrounds = _createEventController.GetGroundsFromId(EventCreationManager.Instance.ParkId).ToList();

                foreach (var ground in parkGrounds)
                {
                    foreach (var s in ground.Sports)
                    {
                        if (s.SportId == sport.SportId)
                        {
                            EventCreationManager.Instance.Reserve.GroundId = ground.GroundId;
                            EventCreationManager.Instance.Reserve.SportId = sport.SportId;
                            EventCreationManager.Instance.IPriceEntity = ground;
                        }
                    }
                }

            int NumberOfHoursPlaying = Convert.ToInt32(dtpEventEndTime.Value.Subtract(dtpEventStartTime.Value).TotalHours);

            if (NumberOfHoursPlaying > 1)
            {
                NumberOfHoursPlaying -= 1;
                EventCreationManager.Instance.IPriceEntity = new TimeDecorator(EventCreationManager.Instance.IPriceEntity, NumberOfHoursPlaying, _createEventController.GetGround(EventCreationManager.Instance.Reserve.GroundId).Price);
            }
        }

        public void Populate()
        {
            PopulateDateTime();
            PopulateComboBox();

            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        public void PopulateComboBox()
        {
            int locationId = EventCreationManager.Instance.LocationId;
            IDictionary<int, string> parks = _createEventController.GetParksOfLocation(locationId);

            cbSelectPark.DataSource = new BindingSource(parks, null);
            cbSelectPark.DisplayMember = "Value";
            cbSelectPark.ValueMember = "Key";


            if (parks.Any())
            {
                foreach (KeyValuePair<int, string> pair in parks)
                {
                    cbSelectPark.SelectedValue = pair.Key;
                    EventCreationManager.Instance.ParkId = pair.Key;
                    return;
                }
            }
            else
            {
                nextScreenButton.Hide();
            }
        }

        private void SelectHourParkState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void PopulateDateTime()
        {
            dtpEventStartDate.MinDate = DateTime.Today;

            dtpEventStartTime.CustomFormat = "HH:mm";
            dtpEventStartTime.Format = DateTimePickerFormat.Custom;
            dtpEventStartTime.ShowUpDown = true;
            dtpEventStartTime.MinDate = DateTime.Now;

            dtpEventEndTime.CustomFormat = "HH:mm";
            dtpEventEndTime.Format = DateTimePickerFormat.Custom;
            dtpEventEndTime.ShowUpDown = true;
            dtpEventEndTime.MinDate = DateTime.Now.AddHours(1.0);
        }

        private void SetDateTimeValues()
        {
            EventCreationManager.Instance.EventStartDate = dtpEventStartDate.Value;
            EventCreationManager.Instance.EventStartTime = dtpEventStartTime.Value;
            EventCreationManager.Instance.EventEndTime = dtpEventEndTime.Value;
        }

        private void cbSelectPark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
