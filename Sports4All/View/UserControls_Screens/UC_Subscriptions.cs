using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Sports4All.UserControls_Items;

namespace Sports4All.UserControls_Screens
{
    public partial class UC_Subscriptions : UserControl, IUserControl
    {
        public UC_Subscriptions()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id { get; set; }
        #endregion
        private void UC_Subscriptions_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            PopulateItemsSports(pnlSports);
        }
        private void PopulateItemsSports(Panel p)
        {
            p.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Space-Debris.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Small-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Island-of-Love.jpg"
            };

            UC_SubscriptionItem[] listItems = new UC_SubscriptionItem[imageList.Count];

            for (int i = 0; i < imageList.Count; i++)
            {
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);

                listItems[i] = new UC_SubscriptionItem
                {
                    Title = "Título do recinto " + i, Image = Image.FromStream(stream)
                };

                p.Controls.Add(listItems[i]);
            }
        }

        private void PopulateItemsFriends(Panel p)
        {
            p.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Dinosaur-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Forest-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Central-Park.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Sea-Turtle.jpg"
            };

            UC_SubscriptionItem[] listItems = new UC_SubscriptionItem[imageList.Count];

            for (int i = 0; i < imageList.Count; i++)
            {
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);

                listItems[i] = new UC_SubscriptionItem
                {
                    Title = "Título do recinto " + i, Image = Image.FromStream(stream)
                };

                p.Controls.Add(listItems[i]);
            }
        }

        private void PopulateItemsParks(Panel p)
        {
            p.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/09/Endless-Fields.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Mountain-Sunrise.jpg"
            };

            UC_SubscriptionItem[] listItems = new UC_SubscriptionItem[imageList.Count];

            for (int i = 0; i < imageList.Count; i++)
            {
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);

                listItems[i] = new UC_SubscriptionItem
                {
                    Title = "Título do recinto " + i, Image = Image.FromStream(stream)
                };

                p.Controls.Add(listItems[i]);
            }
        }

        private void tabSubscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = tabSubscriptions.SelectedTab.Name;

            switch (name)
            {
                case "tabPageSports":
                    PopulateItemsSports(pnlSports);
                    break;
                case "tabPageFriends":
                    PopulateItemsFriends(pnlFriends);
                    break;
                case "tabPageParks":
                    PopulateItemsParks(pnlParks);
                    break;
            }
        }
    }
}
