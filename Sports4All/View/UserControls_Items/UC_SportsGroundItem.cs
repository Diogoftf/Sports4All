using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sports4All.UserControls_Items
{
    public partial class UC_SportsGroundItem : UserControl
    {
        public UC_SportsGroundItem()
        {
            InitializeComponent();

            foreach (Control c in Controls)
            {
                c.DoubleClick += UC_SportsGroundItem_DoubleClick;
            }
        }

        #region Properties

        private string _title;
        private string _quality;
        private Image _image;
        private string _price;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value;
                lblTitle.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Quality
        {
            get { return _quality; }
            set { _quality = value;
                lblQuality.Text = "Qualidade: " + value;
            }
        }

        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                lblPrice.Text = "Preço: " + value;
            }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value;
                pbSportsGround.Image = value;
            }
        }

        public int Id { get; set; }
        #endregion

        private void UC_SportsGroundItem_DoubleClick(object sender, EventArgs e)
        {
            Form1.Instance.BringUcToFront<UC_SportsgroundDesc>("UC_SportsgroundDesc", Id.ToString());
        }
    }
}
