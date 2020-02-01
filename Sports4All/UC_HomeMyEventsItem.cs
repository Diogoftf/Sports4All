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
    public partial class UC_HomeMyEventsItem : UserControl
    {
        #region Properties
        private string _recinto;
        private string _slots;
        private string _organizador;
        private string _dateTime;
        private string _sport;
        private Color _color;
        private Image _SportPicture;
        private MyEventsController _eventsController;
        private Image _image;

        public int Id { get; set; }

        public string resetNameProprieties //
        {
            set { lblDate.Text = lblEventOwner.Text = lblEventOwnerValue.Text = lblSportsGround.Text = lblstart_Hour.Text = lblPlayers.Text = lblPlace.Text = value;
            }
        }

        public Image Image
        {
            get => _image;
            set { _image = value; pbModality.Image = value; }
        }

        public Image DisableDeleteImage //
        {
            set { pbDelete.Image = value; }
        }

        public Image DisableImage //
        {
            set { pbModality.Image = pbMoreDetails.Image = pbDelete.Image = value; }
        }

        public Image SportPicture
        {
            set { _SportPicture = value; } // provisorio
        }

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

        public string NoEvents //Quantidade de jogadores por evento
        {

            get { return _slots; }
            set 
            { 
                _slots = value; 
                lblHowManyPlayers.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                lblHowManyPlayers.Text = value;
            }

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
            _eventsController = new MyEventsController();

            //se for meu evento, mostrar o pbEdit
        }

        private void pbMoreDetails_Click(object sender, EventArgs e)
        {
            Form1.Instance.BringUcToFront<UC_EventDetails>("UC_EventDetails", Id.ToString());
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (_organizador == Session.Instance.LoggedUsername)
            {
                DialogResult result = MessageBox.Show("Deseja apagar o evento?", "Confirme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _eventsController.DeleteEvent(this.Id);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja sair do evento?", "Confirme", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    _eventsController.UnregisterUser(this.Id,Session.Instance.LoggedUsername);
                }
            }
        }
    }
}
