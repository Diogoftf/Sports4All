using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Decorator;

namespace Sports4All
{
    public partial class UC_MaterialItem : UserControl
    {
        #region Properties
        private string _material;
        private string _price;
        private Label _totalPrice;
        private IPriceEntity _priceEntity { get; set; }

        public ComboBox CbQuantity
        {
            get => cbQtty;
        }

        public Label TotalPrice
        {
            set { _totalPrice = value; }

            get => _totalPrice;
        }
        public string Price
        {
            set => _price = lblPrice.Text = value;

            get => _price;
        }

        public string Material
        {
            set => _material = lblMaterial.Text = value;

            get => lblMaterial.Text;
        }

        public int Quantity
        {
            get => cbQtty.SelectedIndex;
        }

        #endregion

        public UC_MaterialItem(IPriceEntity _priceEntity)
        {
            InitializeComponent();
            this._priceEntity = _priceEntity;
        }

        public void PopulateQuantity(int quantity)
        {
            for (int i = 0; i <= quantity; i++)
            {
                cbQtty.Items.Add(i);
            }
        }
    }
}
