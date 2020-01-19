using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_UserinEventItem : UserControl
    {

        public UC_UserinEventItem()
        {
            InitializeComponent();
        }

        private string _username;
        private string _userAge;
        private string _playerSkill;
        private Image _icon;
        public string PlayerId
        {
            get => _userAge;
            set { _userAge = value;
                lbUserAge.Text = value;
            }
        }

        public string Username
        {
            get => _username;
            set { _username = value; lblUsername.Text = value; }
        }
        public Image Icon
        {
            get => _icon;
            set { _icon = value; cpbPlayer.Image = value; }
        }

        public string PlayerSkill
        {
            get => _playerSkill;
            set { _playerSkill = value;
                lblUserRankingValue.Text = value;
            }
        }



       

       
    }
}