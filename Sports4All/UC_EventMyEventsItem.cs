﻿using System;
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
    public partial class UC_EventMyEventsItem : UserControl
    {
        #region Properties

        private string _day;

        private string _avaliar;
        private int _eventId;
        private Color _color;
        private string _owner;
        private string _sport;
        private string _date;
        private string _Park;
        private string _ButtonEvaluation;
        private string _messageInfo;

        public string MessageInfo
        {

            get { return _messageInfo; }
            set { _messageInfo = value; lblRemainingTimeEvaluation.Text = _messageInfo; }

        }
        public string Park
        {

            get { return _Park; }
            set { _Park = value; lblSportsGround.Text = _Park; }

        }
        public string Date
        {

            get { return _date; }
            set { _date = value; lblstart_Hour.Text = _date; }

        }
        public string Sport
        {

            get { return _sport; }
            set { _sport = value; lblModalityName.Text = _sport; }

        }
        public int EventID
        {

            get { return _eventId; }
            set { _eventId = value; lbEventID.Text = _eventId.ToString(); }

        }
        public string Owner
        {

            get { return _owner; }
            set { _owner = value; lblEventOwnerValue.Text = _owner; }

        }
        public string Avaliar
        {

            get { return _avaliar; }
            set { _avaliar = value; btnEvaluate.Text = value; }

        }

        public Color Change_BackColor
        {

            get { return _color; }
            set { _color = value; plEventEvaluation.BackColor = value; }

        }

        #endregion
        public UC_EventMyEventsItem()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void month_Event_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbRemainingTimeEvaluation_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.MessageBox.Show("My message here");

        }
        public void DisableButtonEvaluation()
        {
            btnEvaluate.Text = "Avaliado!";
            btnEvaluate.Enabled = false;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventEvaluation"))
            {
                UC_EventEvaluation uc = new UC_EventEvaluation { Dock = DockStyle.Fill };
                uc.EventId = EventID;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }

            Form1.Instance.PnlContainer.Controls["UC_EventEvaluation"].BringToFront();

            if (Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventEvaluation"))
            {
                foreach (UserControl x in Form1.Instance.PnlContainer.Controls)
                {
                    if (Form1.Instance.PnlContainer.Controls.GetChildIndex(x) == 0)
                    {
                        Form1.Instance.FrontControl = x;
                        UC_EventEvaluation j = (UC_EventEvaluation)x;
                        j.EventId = EventID;
                    }
                }
            }
        }
    }
}
