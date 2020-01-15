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
    public partial class UC_PlayerEvaluationItem : UserControl
    {
        public UC_PlayerEvaluationItem()
        {
            InitializeComponent();
        }

        private int _playerId;
        private string _username;
        private Image _icon;
        private int _playerSkill;
        private int _playerFairplay;

        public int PlayerId
        {
            get => _playerId;
            set { _playerId = value; }
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

        public int PlayerSkill
        {
            get => _playerSkill;
            set { _playerSkill = value; }
        }

        public int PlayerFairplay
        {
            get => _playerFairplay;
            set { _playerFairplay = value; }
        }

        private void radioButtonSkill_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;

                PlayerSkill = Convert.ToInt32(rb.Text);
            }
        }

        private void rbFairplay_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;

                PlayerFairplay = Convert.ToInt32(rb.Text);
            }
        }
    }
}