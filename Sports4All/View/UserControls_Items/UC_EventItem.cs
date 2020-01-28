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

            foreach (Control c in Controls)
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
            Form1.Instance.BringUcToFront<UC_EventsModality>("UC_EventsModality", Id.ToString());
        }
    }
}
