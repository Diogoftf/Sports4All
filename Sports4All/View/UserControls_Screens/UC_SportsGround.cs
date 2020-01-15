using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Sports4All.UserControls_Items;

namespace Sports4All
{
    public partial class UC_SportsGround : UserControl
    {
        public UC_SportsGround()
        {
            InitializeComponent();
        }

        private void UC_SportsGround_Load(object sender, EventArgs e)
        {
            PopulateItems();
            PopulateScoreComboBox();
            PopulateLocationComboBox();
        }

        private void PopulateItems()
        {
            flpSportsGround.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Space-Debris.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Small-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Island-of-Love.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Dinosaur-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Forest-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Central-Park.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Sea-Turtle.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Endless-Fields.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Mountain-Sunrise.jpg"
            };

            ImageList img = new ImageList {ImageSize = new Size(140, 140), ColorDepth = ColorDepth.Depth32Bit};

            UC_SportsGroundItem[] listItems = new UC_SportsGroundItem[imageList.Count];

            for (int i = 0; i < imageList.Count; i++)
            {
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);

                listItems[i] = new UC_SportsGroundItem
                {
                    Title = "Título do recinto " + i, Score = i.ToString(), Image = Image.FromStream(stream)
                };

                flpSportsGround.Controls.Add(listItems[i]);
            }
        }

        public void PopulateScoreComboBox()
        {
            // Bind combobox to dictionary
            Dictionary<string, string> test = new Dictionary<string, string>
            {
                {"1", "dfdfdf"}, {"2", "dfdfdf"}, {"3", "dfdfdf"}
            };
            cbScore.DataSource = new BindingSource(test, null);
            cbScore.DisplayMember = "Value";
            cbScore.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)cbScore.SelectedItem).Value;
        }

        public void PopulateLocationComboBox()
        {
            // Bind combobox to dictionary
            Dictionary<string, string> test = new Dictionary<string, string>
            {
                {"1", "dfdfdf"}, {"2", "dfdfdf"}, {"3", "dfdfdf"}
            };
            cbLocation.DataSource = new BindingSource(test, null);
            cbLocation.DisplayMember = "Value";
            cbLocation.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)cbLocation.SelectedItem).Value;
        }

    }
}
