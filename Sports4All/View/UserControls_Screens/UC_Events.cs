using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing;
using System.Linq;
using Sports4All.Controller;
using Sports4All.UserControls_Items;

namespace Sports4All
{
    public partial class UC_Events : UserControl, IUserControl
    {
        private BrowseController _browseController;
        public UC_Events()
        {
            InitializeComponent();
            _browseController = new BrowseController();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_Events_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            ICollection<int> idSportsWithEvents = _browseController.GetSportsIds();
            ICollection<Sport> sportsWithEvents = _browseController.GetSports(idSportsWithEvents);

            flpEvents.Controls.Clear();

            foreach (var sport in sportsWithEvents)
            {
                UC_EventItem uc = new UC_EventItem
                {
                    Title = sport.Name,
                    Image = ImagesController.Instance.GetImageFromID(sport.Picture.PictureId),
                    Id = sport.SportId
                };

                flpEvents.Controls.Add(uc);
            }
        }
    }
}
