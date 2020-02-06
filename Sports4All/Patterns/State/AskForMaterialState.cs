using System;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All.Patterns.State
{
    public partial class AskForMaterialState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;
        private CreateEventController _createEventController;

        public AskForMaterialState()
        {
            InitializeComponent();
        }

        public AskForMaterialState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
            _createEventController = new CreateEventController();
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<AskForMaterialState>("AskForMaterialState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            if (EventCreationManager.Instance.AddMaterial.Equals("rbYes"))
            {
                _reserveNoviceForm.SetState(_reserveNoviceForm.SelectMaterialState);
            }
            else
            {
                _reserveNoviceForm.SetState(_reserveNoviceForm.DefineUsersState);
            }
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectHourParkState);
        }

        public void Populate()
        {
            EventCreationManager.Instance.AddMaterial = "rbNo";
            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        private void AskForMaterialState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            EventCreationManager.Instance.AddMaterial = rb.Name;
        }
    }
}
