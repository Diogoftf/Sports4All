using Sports4All.View.UserControls_Items;
using System;
using System.Windows.Forms;

namespace Sports4All.Patterns.State
{
    public partial class EventNameState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;

        public EventNameState()
        {
            InitializeComponent();
        }

        public EventNameState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent(); 
            _reserveNoviceForm = reserveNoviceForm;
        }

        public string Id { get; set; }

        public void NextScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.SelectSportState);
        }

        public void PreviousScreen()
        {
        }

        public void Populate()
        {
            lblEventName.Text = "Olá "+ Session.Instance.LoggedUser + ", indique que nome quer dar ao evento: ";
            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        public void Display()
        {
            Form1.Instance.BringUcToFront<EventNameState>("EventNameState", "", _reserveNoviceForm);
        }

        private void EventNameState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string eventName = textBoxName.Text;
            EventCreationManager.Instance.EventName = eventName;
        }
    }
}
