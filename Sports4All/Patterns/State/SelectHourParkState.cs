using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sports4All.Patterns.State
{
    public partial class SelectHourParkState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;

        public SelectHourParkState()
        {
            InitializeComponent();
        }

        public SelectHourParkState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
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
            throw new NotImplementedException();
        }

        private void SelectHourParkState_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
