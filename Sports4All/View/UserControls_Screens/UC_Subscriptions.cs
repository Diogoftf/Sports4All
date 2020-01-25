using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.UserControls_Items;

namespace Sports4All.UserControls_Screens
{
    public partial class UC_Subscriptions : UserControl
    {
        public UC_Subscriptions()
        {
            InitializeComponent();
        }

        private void UC_Subscriptions_Load(object sender, EventArgs e)
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

            ImageList img = new ImageList {ImageSize = new Size(140, 140), ColorDepth = ColorDepth.Depth32Bit};

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

            ImageList img = new ImageList {ImageSize = new Size(140, 140), ColorDepth = ColorDepth.Depth32Bit};

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

            ImageList img = new ImageList {ImageSize = new Size(140, 140), ColorDepth = ColorDepth.Depth32Bit};

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
