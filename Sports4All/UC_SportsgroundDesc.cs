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
        ParkDescriptionController _parkDescriptionController = new ParkDescriptionController();
        public UC_SportsgroundDesc()
        {
            InitializeComponent();
            lbSportsgndName.Text = _parkDescriptionController.GetPark(1).Name;
            tbDescription.Text = _parkDescriptionController.GetPark(1).Description;
            //pbPark.Image = _parkDescriptionController.GetPark(1).Picture;
            lblSportsList.Text = GetFormatedSportsList();

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
    }
}