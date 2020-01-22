using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_SportsgroundDesc : UserControl
    {
        private ParkDescriptionController _parkDescriptionController;
        public int Id { get; set; }

        public UC_SportsgroundDesc()
        {
            _parkDescriptionController = new ParkDescriptionController();

            InitializeComponent();
        }


        public String GetFormatedSportsList()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var sport in _parkDescriptionController.GetParkAvailableSports(1))
            {
                builder.Append(sport).Append("|");
            }

            string result = builder.ToString();
            string trimmed = result.TrimEnd('|');

            return trimmed;
        }

        private void UC_SportsgroundDesc_Load(object sender, EventArgs e)
        {
            PopulateUserControl();
        }

        public void PopulateUserControl()
        {
            lbSportsgndName.Text = _parkDescriptionController.GetPark(Id).Name;
            tbDescription.Text = _parkDescriptionController.GetPark(Id).Description;
            //pbPark.Image = _parkDescriptionController.GetPark(Id).Picture;
            lblSportsList.Text = GetFormatedSportsList();
        }
    }
}