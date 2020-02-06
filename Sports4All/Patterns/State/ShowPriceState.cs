using System;
using System.Windows.Forms;

namespace Sports4All.Patterns.State
{
    public partial class ShowPriceState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;

        public ShowPriceState()
        {
            InitializeComponent();
        }

        public ShowPriceState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<ShowPriceState>("ShowPriceState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            EventCreationManager.Instance.CreateEvent();
            MessageBox.Show("Reserva criada com sucesso!");
            Form1.Instance.BringUcToFront<UC_Home>("UC_Home", "");
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.DefineUsersState);
        }

        public void Populate()
        {
            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        private void ShowPriceState_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
