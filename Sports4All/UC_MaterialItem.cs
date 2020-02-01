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
    public partial class UC_MaterialItem : UserControl
    {
        #region Properties
        private string _material;
        private string _qtty;
        private string _price;


        public int Id { get; set; }

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

        public UC_MaterialItem()
        {
            InitializeComponent();
        }

        private void UC_MaterialItem_Load(object sender, EventArgs e)
        {

        }

        public void PopulateQuantity(int qttd)
        {
            for(int i = 0; i <= qttd; i++)
            {
                cbQtty.Items.Add(i);
            }
            cbQtty.SelectedIndex = 0;
        }
    }
}
