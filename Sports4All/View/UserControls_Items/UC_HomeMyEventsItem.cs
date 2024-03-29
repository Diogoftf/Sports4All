﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_HomeMyEventsItem : UserControl
    {
        #region Properties
        private string _recinto;
        private string _slots;
        private string _owner;
        private string _dateTime;
        private string _sport;
        private MyEventsController _eventsController;
        private Image _image;

        public int Id { get; set; }

        public string resetNameProprieties
        {
            set { lblDate.Text = lblEventOwner.Text = lblEventOwnerValue.Text = lblSportsGround.Text = lblstart_Hour.Text = lblPlayers.Text = lblPlace.Text = value;
            }
        }

        public Image Image
        {
            get => _image;
            set { _image = value; pbModality.Image = value; }
        }

        public Image DisableDeleteImage
        {
            set { pbDelete.Image = value; }
        }

        public Image DisableImage
        {
            set { pbModality.Image = pbMoreDetails.Image = pbDelete.Image = value; }
        }

        public string Sport
        {

            get { return _sport; }
            set { _sport = value; lblSport.Text = value; }

        }

        public string Recinto
        {

            get { return _recinto; }
            set { _recinto = value; lblSportsGround.Text = value; }

        }

        public string Slots
        {

            get { return _slots; }
            set { _slots = value; lblHowManyPlayers.Text = value; }

        }

        public string NoEvents
        {

            get { return _slots; }
            set 
            { 
                _slots = value; 
                lblHowManyPlayers.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                lblHowManyPlayers.Text = value;
            }

        }

        public string Owner
        {

            get { return _owner; }
            set { _owner = value; lblEventOwnerValue.Text = value; }

        }

        public string DateTime
        {

            get { return _dateTime; }
            set { _dateTime = value; lblstart_Hour.Text = value.ToString(); }

        }

        #endregion

        public UC_HomeMyEventsItem()
        {
            InitializeComponent();
            _eventsController = new MyEventsController();
        }

        private void pbMoreDetails_Click(object sender, EventArgs e)
        {
            Form1.Instance.BringUcToFront<UC_EventDetails>("UC_EventDetails", Id.ToString());
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (_owner == Session.Instance.LoggedUser)
            {
                result = MessageBox.Show("Deseja apagar o evento?", "Confirme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _eventsController.DeleteEvent(this.Id);
                    MessageBox.Show("Reserva eliminada com sucesso");
                    Form1.Instance.BringUcToFront<UC_Home>("UC_Home", Id.ToString());
                }
            }
            else
            {
                result = MessageBox.Show("Deseja sair do evento?", "Confirme", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    _eventsController.UnregisterUser(this.Id,Session.Instance.LoggedUser);
                    MessageBox.Show("Saíste com sucesso do Evento");
                    Form1.Instance.BringUcToFront<UC_Home>("UC_Home", Id.ToString());
                }
            }
        }
    }
}
