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
    public partial class UC_SportsGround : UserControl, IUserControl
    {

        private BrowseParksController _browseParksController;
        public UC_SportsGround()
        {
            InitializeComponent();
            _browseParksController = new BrowseParksController();
        }


        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_SportsGround_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            PopulateItems(true, 0);
            PopulateLocationComboBox();
            PopulateScoreComboBox();
        }
        private void PopulateItems(bool ascending, int id)
        {
            ICollection<Park> parks = _browseParksController.GetParksAscending(ascending, id);

            flpSportsGround.Controls.Clear();

            foreach (var park in parks)
            {
                UC_SportsGroundItem item = new UC_SportsGroundItem
                {
                    Title = park.Name,
                    Id = park.ParkId,
                    Score = _browseParksController.GetParkClassification(park.ParkId).QualityAverage + "/5",
                    Image = ImagesController.GetImageFromID(park.Picture.PictureId)
                };

                flpSportsGround.Controls.Add(item);
            }
        }

        public void PopulateScoreComboBox()
        {
            Dictionary<int, string> values = new Dictionary<int, string>
                {
                    {1, "Ascendente"}, {2, "Descendente"}
                };
            cbScore.DataSource = new BindingSource(values, null);
            cbScore.DisplayMember = "Value";
            cbScore.ValueMember = "Key";
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
        }

        private void SortItemChanged(object sender, EventArgs e)
        {
            int key = ((KeyValuePair<int, string>)cbLocation.SelectedItem).Key;
            bool asc = IsAscending();

            PopulateItems(asc, key);
        }

        private bool IsAscending()
        {
            int key = ((KeyValuePair<int, string>)cbScore.SelectedItem).Key;

            return key == 1;
        }
    }
}
