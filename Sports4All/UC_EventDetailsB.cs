using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sports4All
{
    public partial class UC_EventsDetailsB : UserControl
    {
        public UC_EventsDetailsB()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            UC_UserinEventItem[] listusers = new UC_UserinEventItem[20];

            for (int i = 0; i < listusers.Length; i++)
            {
                listusers[i] = new UC_UserinEventItem();
                listusers[i].Username = "Gouveia";
                listusers[i].PlayerAge = "34 Anos";
                listusers[i].PlayerSkill = "#003";

                if (flpUsersEvent.Controls.Count < 0)
                {

                    flpUsersEvent.Controls.Clear();
                }
                else
                {
                    flpUsersEvent.Controls.Add(listusers[i]);
                }
            }

            pbPark.ImageLocation = @"C:\Users\Tiago.Gouveia\Desktop\ProjectDIS\Sports4All\Images\sportsground1.jpg";
            pbPark.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            btnSaveChanges.Visible = true;
            tbEventDate.ReadOnly = false;
            tbMaxAge.ReadOnly = false;
            tbminAge.ReadOnly = false;
            tbNome.ReadOnly = false;
            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Guardados com Sucesso!");
            btnSaveChanges.Visible = false;
            tbEventDate.ReadOnly = true;
            tbMaxAge.ReadOnly = true;
            tbminAge.ReadOnly = true;
            tbNome.ReadOnly = true;
        }
    }
}
