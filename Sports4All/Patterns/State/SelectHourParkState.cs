using Sports4All.Controller;
using System;
using System.Windows.Forms;

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
            _reserveNoviceForm = reserveNoviceForm;
            _createEventController = new CreateEventController();
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<SelectHourParkState>("SelectHourParkState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.AskForMaterialState);
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectLocationState);
        }

        public void Populate()
        {

        }

        public void PopulateComboBox()
        {
            int locationId = EventCreationManager.Instance.LocationId;
            //IDictionary<int, string> sports = _createEventController.GetLocationsDictionary(sportId);

            //cbSelectLocation.DataSource = new BindingSource(sports, null);
            //cbSelectLocation.DisplayMember = "Value";
            //cbSelectLocation.ValueMember = "Key";
            //cbSelectLocation.SelectedValue = 0;
        }

        private void SelectHourParkState_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
