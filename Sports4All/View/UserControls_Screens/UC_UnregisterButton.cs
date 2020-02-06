using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_UnregisterButton : UserControl
    {
        public UC_UnregisterButton()
        {
            InitializeComponent();
        }

        #region Properties
        public string Username { get; set; }
        public int Eventid { get; set; }
        #endregion
    }
}
