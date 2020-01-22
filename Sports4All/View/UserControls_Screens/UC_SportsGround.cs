using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Linq;
using Sports4All.Controller;
using Sports4All.UserControls_Items;

namespace Sports4All
{
    public partial class UC_SportsGround : UserControl
    {

        private BrowseParksController _browseParksController;
        private bool _handle = true;

        public UC_SportsGround()
        {
            InitializeComponent();
            _browseParksController = new BrowseParksController();
        }

        private void UC_SportsGround_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            PopulateItems(true, 0);
            PopulateLocationComboBox();
            PopulateScoreComboBox();
        }

        private void PopulateItems(bool ascending, int id)
        {
            ICollection<Park> parks = _browseParksController.GetParksAscending(ascending, id);

            flpSportsGround.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
            };

            UC_SportsGroundItem[] listItems = new UC_SportsGroundItem[parks.Count];

            WebClient w = new WebClient();
            byte[] imageByte = w.DownloadData(imageList[0]);
            MemoryStream stream = new MemoryStream(imageByte);
           

            for (int i = 0; i < parks.Count; i++)
            {
                listItems[i] = new UC_SportsGroundItem
                {
                    Title = parks.ElementAt(i).Name, 
                    Id = parks.ElementAt(i).ParkId, 
                    Score = (parks.ElementAt(i).Quality == null ? "0" 
                                : parks.ElementAt(i).Quality) + "/5",
                    Image = Image.FromStream(stream)
                };

                flpSportsGround.Controls.Add(listItems[i]);
            }
        }

        public void PopulateScoreComboBox()
        {
            // Bind combobox to dictionary
            Dictionary<int, string> values = new Dictionary<int, string>
            {
                {1, "Ascendente"}, {2, "Descendente"}
            };
            cbScore.DataSource = new BindingSource(values, null);
            cbScore.DisplayMember = "Value";
            cbScore.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<int, string>)cbScore.SelectedItem).Value;
        }

        public void PopulateLocationComboBox()
        {
            ICollection<int> countyIds = _browseParksController.GetReservesCountyIds();
            IDictionary<int, string> values = _browseParksController.GetLocationsDictionary(countyIds);

            values.Add(0, "");

            cbLocation.DataSource = new BindingSource(values, null);
            cbLocation.DisplayMember = "Value";
            cbLocation.ValueMember = "Key";

            cbLocation.SelectedValue = 0;

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<int, string>)cbLocation.SelectedItem).Value;
        }

        private void SortItemChanged(object sender, EventArgs e)
        {
            int key = ((KeyValuePair<int, string>)cbLocation.SelectedItem).Key;
            bool asc = IsAscending();

            PopulateItems(true, key);
        }

        private bool IsAscending()
        {
            int key = ((KeyValuePair<int, string>)cbScore.SelectedItem).Key;

            return key == 1;
        }

    }
}
