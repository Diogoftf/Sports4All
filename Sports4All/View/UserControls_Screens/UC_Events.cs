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

            List<string> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
            };

            UC_EventItem[] listItems = new UC_EventItem[sportsWithEvents.Count];


            WebClient w = new WebClient();
            byte[] imageByte = w.DownloadData(imageList[0]);
            MemoryStream stream = new MemoryStream(imageByte);


            for (int i = 0; i < sportsWithEvents.Count; i++)
            {
                listItems[i] = new UC_EventItem
                {
                    Title = sportsWithEvents.ElementAt(i).Name,
                    Image = Image.FromStream(stream),
                    Id = sportsWithEvents.ElementAt(i).SportId
                };

                flpEvents.Controls.Add(listItems[i]);
            }
        }
    }
}
