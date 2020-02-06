using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_SportsgroundEvItem : UserControl
    {
        private string _parkname;
        private Image _parkimage;

        public UC_SportsgroundEvItem()
        {
            InitializeComponent();
            ParkQuality = 3;
            ParkPrice = 3;
        }

        public int ParkId { get; set; }
        public string ParkName
        {
            get => _parkname;
            set { _parkname = value; lblParkName.Text = value; }
        }
        public int ParkQuality { get; set; }
        public int ParkPrice { get; set; }
        public Image Image {
            get => _parkimage;
            set { _parkimage = value; cpbSportsground.Image = value; }
        }

        private void rbtnQuality_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            ParkQuality = Convert.ToInt32(rb.Text);
        }
        private void rbtnPrice_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            ParkPrice = Convert.ToInt32(rb.Text);
        }
    }
}
