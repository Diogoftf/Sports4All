using System;
using System.Windows.Forms;
using Sports4All.Patterns.State;

namespace Sports4All.View.UserControls_Items
{
    public partial class NextScreenButton : UserControl
    {
        public ReserveNoviceForm ReserveNoviceForm { get; set; }

        public NextScreenButton()
        {
            InitializeComponent();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            ReserveNoviceForm.NextScreen();
        }
    }
}
