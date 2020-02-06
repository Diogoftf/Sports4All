using System.Drawing;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_UserinEventItem : UserControl
    {

        public UC_UserinEventItem()
        {
            InitializeComponent();
        }

        private string _userId;
        private string _userAge;
        private string _playerSkill;
        private Image _image;

        #region Properties
        public string PlayerAge
        {
            get => _userAge;
            set
            {
                _userAge = value;
                lbUserAge.Text = value;
            }
        }

        public string UserId
        {
            get => _userId;
            set { _userId = value; lblUsername.Text = value; }
        }

        public string PlayerSkill
        {
            get => _playerSkill;
            set
            {
                _playerSkill = value;
                lblUserRankingValue.Text = value;
            }
        }
        public Image Image
        {
            get => _image;
            set { _image = value; cpbPlayer.Image = value; }
        }

    } 
    #endregion
}