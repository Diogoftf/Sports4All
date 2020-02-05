using System;
using System.Windows.Forms;

namespace Sports4All.Patterns.State
{
    public partial class DefineUsersState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;


        public DefineUsersState()
        {
            InitializeComponent();
        }

        public DefineUsersState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<DefineUsersState>("DefineUsersState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.ShowPriceState);
        }

        public void PreviousScreen()
        {
            if (EventCreationManager.Instance.AddMaterial.Equals("rbYes"))
            {
                _reserveNoviceForm.SetState(_reserveNoviceForm.SelectMaterialState);
            }
            else
            {
                _reserveNoviceForm.SetState(_reserveNoviceForm.AskForMaterialState);
            }
        }

        public void Populate()
        {
            PopulateComboBoxes();

            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        private void DefineUsersState_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void PopulateComboBoxes()
        {
            int minPlayers = 2;
            int maxPlayers = 22;
            int minAge = 5;
            int maxAge = 100;

            for (int i = minPlayers; i < maxPlayers; i += 2)
            {
                cbPlayersNumber.Items.Add(i);
            }

            for (int i = minAge; i < maxAge; i += 5)
            {
                cbMaxPlayersAge.Items.Add(i);
                cbMinPlayersAge.Items.Add(i);
            }

            cbPlayersNumber.SelectedIndex = 0;
            cbMaxPlayersAge.SelectedIndex = 0;
            cbMinPlayersAge.SelectedIndex = cbMinPlayersAge.Items.Count - 1;

            SetUsersValues();
        }

        private void SetUsersValues()
        {
            EventCreationManager.Instance.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);
            EventCreationManager.Instance.MinAge = Convert.ToInt32(cbMinPlayersAge.Text);
            EventCreationManager.Instance.MaxAge = Convert.ToInt32(cbMaxPlayersAge.Text);
        }

        private void cbPlayersNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EventCreationManager.Instance.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);
        }

        private void cbMaxPlayersAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventCreationManager.Instance.MaxAge = Convert.ToInt32(cbMaxPlayersAge.Text);
        }

        private void cbMinPlayersAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventCreationManager.Instance.MinAge = Convert.ToInt32(cbMinPlayersAge.Text);
        }
    }
}
