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
    public partial class UC_EventMyEventsItem : UserControl
    {
        #region Properties
        private string _evaluate;
        private int _eventId;
        private Color _color;
        private string _owner;
        private string _sport;
        private string _date;
        private string _park;
        private string _messageInfo;

        public string MessageInfo
        {

            get => _messageInfo;
            set { _messageInfo = value; lblRemainingTimeEvaluation.Text = _messageInfo; }

        }
        public string Park
        {
            get { return _park; }
            set { _park = value; lblSportsGround.Text = _park; }
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
            get { return _evaluate; }
            set { _evaluate = value; btnEvaluate.Text = value; }
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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My message here");
        }

        public void DisableButtonEvaluation()
        {
            btnEvaluate.Text = "Avaliado!";
            btnEvaluate.Enabled = false;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Form1.Instance.BringUcToFront<UC_EventEvaluation>("UC_EventEvaluation", EventID.ToString());
        }
    }
}
