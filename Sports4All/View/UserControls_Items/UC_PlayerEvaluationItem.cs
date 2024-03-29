﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_PlayerEvaluationItem : UserControl
    {
        public UC_PlayerEvaluationItem()
        {
            InitializeComponent();
            PlayerSkill = 3;
            PlayerFairplay = 3;
        }

        private string _username;
        private Image _image;

        public string Username
        {
            get => _username;
            set { _username = value; lblUsername.Text = value; }
        }
        public Image Image
        {
            get => _image;
            set { _image = value; cpbPlayer.Image = value; }
        }

        public int PlayerSkill { get; set; }

        public int PlayerFairplay { get; set; }

        private void rbtnSkill_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            PlayerSkill = Convert.ToInt32(rb.Text);
        }

        private void rbtnFairplay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            PlayerFairplay = Convert.ToInt32(rb.Text);
        }
    }
}