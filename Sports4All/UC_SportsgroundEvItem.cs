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
    public partial class UC_SportsgroundEvItem : UserControl
    {
        private string _parkname;

        public UC_SportsgroundEvItem()
        {
            InitializeComponent();
        }

        public int ParkId { get; set; }
        public string ParkName
        {
            get => _parkname;
            set { _parkname = value; lblParkName.Text = value; }
        }
        public int ParkQuality { get; set; }
        public int ParkPrice { get; set; }
        public string ParkPicture { get; set; }
    }
}
