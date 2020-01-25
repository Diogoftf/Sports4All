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
    public partial class UC_EventItem : UserControl
    {
        public UC_EventItem()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                c.DoubleClick += UC_EventItem_DoubleClick;
            }
        }

        #region Properties

        private string _title;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                lblTitle.Text = value;
            }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                pbEvent.Image = value;
            }
        }
        #endregion

        public int Id { get; set; }

        private void UC_EventItem_DoubleClick(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventsModality"))
            {
                UC_EventsModality uc = new UC_EventsModality { Dock = DockStyle.Fill };
                uc.Id = Id;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }

            Form1.Instance.PnlContainer.Controls["UC_EventsModality"].BringToFront();

            if (Form1.Instance.PnlContainer.Controls.ContainsKey("UC_EventsModality"))
            {
                foreach (UserControl x in Form1.Instance.PnlContainer.Controls)
                {
                    if (Form1.Instance.PnlContainer.Controls.GetChildIndex(x) == 0)
                    {
                        Form1.Instance.FrontControl = x;
                        UC_EventsModality j = (UC_EventsModality)x;
                        j.Id = Id;
                        //j.PopulateList();
                    }
                }
            }



            //NECESSÁRIO ATUALIZAR OS VALORES CASO JÁ TENHA SIDO CARREGADO ANTERIORMENTE
        }
    }
}
