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
        private readonly Color _darkBtnColor = Color.DarkGray;
        private readonly Color _lightBtnColor = Color.Gainsboro;

        public UC_Subscriptions()
        {
            InitializeComponent();
        }

        private void UC_Subscriptions_Load(object sender, EventArgs e)
        {
            changeButtonColor(btnSports);
            PopulateItemsSports();
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnSports);
            PopulateItemsSports();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnFriends);
            PopulateItemsFriends();
        }

        private void btnSportsGround_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnSportsGround);
            PopulateItemsSportsGround();
        }

        private void changeButtonColor(Button btn)
        {
            if (btn == btnSports)
            {
                btnFriends.BackColor = _lightBtnColor; btnSportsGround.BackColor = _lightBtnColor;
                btnSports.BackColor = _darkBtnColor;
            }
            else if (btn == btnFriends)
            {
                btnSports.BackColor = _lightBtnColor; btnSportsGround.BackColor = _lightBtnColor;
                btnFriends.BackColor = _darkBtnColor;
            }
            else if (btn == btnSportsGround)
            {
                btnFriends.BackColor = _lightBtnColor; btnSports.BackColor = _lightBtnColor;
                btnSportsGround.BackColor = _darkBtnColor;
            }
        }

        private void PopulateItemsSports()
        {
            flpSubscriptions.Controls.Clear();

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

                flpSubscriptions.Controls.Add(listItems[i]);
            }
        }

        private void PopulateItemsFriends()
        {
            flpSubscriptions.Controls.Clear();

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

                flpSubscriptions.Controls.Add(listItems[i]);
            }
        }

        private void PopulateItemsSportsGround()
        {
            flpSubscriptions.Controls.Clear();

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

                flpSubscriptions.Controls.Add(listItems[i]);
            }
        }
    }
}
