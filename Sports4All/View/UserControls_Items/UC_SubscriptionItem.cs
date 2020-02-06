using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sports4All.UserControls_Items
{
    public partial class UC_SubscriptionItem : UserControl
    {
        public UC_SubscriptionItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                lblTitle.Text = value;
            }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                pbSubscription.Image = value;
            }
        }
        #endregion
    }
}
