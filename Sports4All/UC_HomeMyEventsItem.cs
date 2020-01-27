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

        public int Id { get; set; }

        public string resetNameProprieties //
        {
            set { lblDate.Text = lblEventOwner.Text = lblEventOwnerValue.Text = lblSportsGround.Text = lblstart_Hour.Text = lblPlayers.Text = lblPlace.Text = value;
            }
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

            //se for meu evento, mostrar o pbEdit
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void pbMoreDetails_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventDetails"))
            {
                UC_EventDetails uc = new UC_EventDetails { Dock = DockStyle.Fill };
                uc.EventId = Id;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }

            Form1.Instance.PnlContainer.Controls["UC_EventDetails"].BringToFront();

            if (Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventDetails"))
            {
                foreach (UserControl x in Form1.Instance.PnlContainer.Controls)
                {
                    if (Form1.Instance.PnlContainer.Controls.GetChildIndex(x) == 0)
                    {
                        Form1.Instance.FrontControl = x;
                        UC_EventDetails j = (UC_EventDetails)x;
                        j.EventId = Id;
                        j.PopulateUserControl();
                    }
                }
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (_organizador == Session.Instance.LoggedUser)
            {
                DialogResult result = MessageBox.Show("Deseja apagar o evento?", "Confirmation", MessageBoxButtons.YesNoCancel);
                
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja sair do evento?", "Confirmation", MessageBoxButtons.YesNoCancel);
            }
        }
    }
}
