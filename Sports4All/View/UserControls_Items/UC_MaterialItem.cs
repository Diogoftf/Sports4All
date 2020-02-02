﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.CreateEvent;

namespace Sports4All
{
    public partial class UC_MaterialItem : UserControl
    {
        #region Properties
        private string _material;
        private string _qtty;
        private string _price;

        private Label _totalPrice;
        private IPriceEntity _priceEntity { get; set; }


        public Label TotalQuantidade 
        {
            set { _totalPrice = value; }

            get => _totalPrice;
        }
        public string Preço //
        {
            set
            {
                _price = lblPrice.Text = value;
            }

            get => _price;
        }

        public string Material //
        {
            set
            {
                _material = lblMaterial.Text = value;
            }

            get => lblMaterial.Text;
        }

        public int Quantidade
        {
            //set
            //{
            //    cbQtty.Items.Add(value);
            //}

            get => cbQtty.SelectedIndex;
        }

        #endregion

        public UC_MaterialItem(IPriceEntity _priceEntity)
        {
            InitializeComponent();
            this._priceEntity = _priceEntity;
        }

        private void UC_MaterialItem_Load(object sender, EventArgs e)
        {

        }

        public void PopulateQuantity(int qttd)
        {
            for (int i = 0; i <= qttd; i++)
            {
                cbQtty.Items.Add(i);
            }
           // cbQtty.SelectedIndex = 0;
        }

        private void cbQtty_SelectedIndexChanged(object sender, EventArgs e)
        {

            int quantidade =  cbQtty.SelectedIndex;


           switch (_material)
           {
                case "Raquete": _priceEntity = new Raquete(_priceEntity, quantidade);
                    break;
                case "Bola"   : _priceEntity = new Bola(_priceEntity, quantidade);
                    break;
           }
           MessageBox.Show("Valor:" + _priceEntity.getCost());
           TotalQuantidade.Text = Convert.ToString(_priceEntity.getCost());
        }
    }
}
