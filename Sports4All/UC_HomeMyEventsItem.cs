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
    public partial class UC_HomeMyEventsItem : UserControl
    {
        #region Properties
        private string _recinto;
        private string _slots;
        private string _organizador;
        private string _dateTime;
        private string _sport;
        private Color _color;

        public string Sport //Quantidade de jogadores por evento
        {

            get { return _sport; }
            set { _sport = value; lblSport.Text = value; }

        }

        public string Recinto //Quantidade de jogadores por evento
        {

            get { return _recinto; }
            set { _recinto = value; lblSportsGround.Text = value; }

        }

        public string Slots //Quantidade de jogadores por evento
        {

            get { return _slots; }
            set { _slots = value; lblHowManyPlayers.Text = value; }

        }

        public string Organizador
        {

            get { return _organizador; }
            set { _organizador = value; lblEventOwnerValue.Text = value; }

        }

        public string DateTime
        {

            get { return _dateTime; }
            set { _dateTime = value; lblstart_Hour.Text = value.ToString(); }

        }

        public Color Color
        {

            get { return _color; }
            set { _color = value; this.BackColor = value; }

        }

        #endregion

        public UC_HomeMyEventsItem()
        {
            InitializeComponent();
        }
    }
}
