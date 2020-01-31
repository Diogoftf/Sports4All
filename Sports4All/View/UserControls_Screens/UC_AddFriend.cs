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
    public partial class UC_AddFriend : UserControl, IUserControl
    {
        public UC_AddFriend()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        public void Populate()
        {
        }
    }
}
