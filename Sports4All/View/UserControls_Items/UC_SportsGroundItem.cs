using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All.UserControls_Items
{
    public partial class UC_SportsGroundItem : UserControl
    {
        public UC_SportsGroundItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _score;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value;
                lblTitle.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Score
        {
            get { return _score; }
            set { _score = value;
                lblScore.Text = "Avaliação: " + value;
            }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value;
                pbSportsGround.Image = value;
            }
        }
        #endregion

    }
}
