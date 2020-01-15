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

        private string _day;

        private string _avaliar;

        private Color _color;




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
    }
}
