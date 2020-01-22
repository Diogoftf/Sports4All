using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
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

        public int Id { get; set; }
        #endregion

        private void UC_SportsGroundItem_DoubleClick(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_SportsgroundDesc"))
            {
                UC_SportsgroundDesc uc = new UC_SportsgroundDesc { Dock = DockStyle.Fill };
                uc.Id = Id;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }

            Form1.Instance.PnlContainer.Controls["UC_SportsgroundDesc"].BringToFront();

            if (Form1.Instance.PnlContainer.Controls.ContainsKey("UC_SportsgroundDesc"))
            {
                foreach (UserControl x in Form1.Instance.PnlContainer.Controls)
                {
                    if (Form1.Instance.PnlContainer.Controls.GetChildIndex(x) == 0)
                    {
                        Form1.Instance.FrontControl = x;
                        UC_SportsgroundDesc j = (UC_SportsgroundDesc) x;
                        j.Id = Id;
                        j.PopulateUserControl();
                    }
                }
            }



            //NECESSÁRIO ATUALIZAR OS VALORES CASO JÁ TENHA SIDO CARREGADO ANTERIORMENTE
        }
    }
}
