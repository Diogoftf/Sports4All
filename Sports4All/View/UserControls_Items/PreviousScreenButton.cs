using System;
using System.Windows.Forms;
using Sports4All.Patterns.State;

namespace Sports4All.View.UserControls_Items
{
    public partial class PreviousScreenButton : UserControl
    {
        public ReserveNoviceForm ReserveNoviceForm { get; set; }

        public PreviousScreenButton()
        {
            InitializeComponent();
        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            ReserveNoviceForm.PreviousScreen();
        }
    }
}
