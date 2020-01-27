using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_PlayerEvaluationItem : UserControl
    {
        private EvaluationController _evaluationController = new EvaluationController();
        public UC_PlayerEvaluationItem()
        {
            InitializeComponent();
        }

        private string _username;
        private Image _icon;

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

        public int PlayerSkill { get; set; }

        public int PlayerFairplay { get; set; }

        private void rbtnSkill_CheckedChanged(object sender, EventArgs e)
        {
            // This is the correct control.
            RadioButton rb = (RadioButton)sender;

            PlayerSkill = Convert.ToInt32(rb.Text);
        }

        private void rbtnFairplay_CheckedChanged(object sender, EventArgs e)
        {
            // This is the correct control.
            RadioButton rb = (RadioButton)sender;

            PlayerFairplay = Convert.ToInt32(rb.Text);
        }
    }
}