using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsDetailsB : UserControl
    {
        private MyEventsController eventsController;


        public UC_EventsDetailsB()
        {
            InitializeComponent();
            //eventsController = new MyEventsController();
            //PopulateList();
        }

        private void PopulateList()
        {
            ICollection<User> enrolledUsers = eventsController.RetrieveEnrolledUsers(1);
            int enrolledUsersCount = enrolledUsers.Count;
            UC_UserinEventItem[] listusers = new UC_UserinEventItem[enrolledUsersCount];

            for (int i = 0; i < enrolledUsersCount; i++)
            {
                listusers[i] = new UC_UserinEventItem()
                {
                    Username = enrolledUsers.ToList()[i].Username,
                    PlayerAge = enrolledUsers.ToList()[i].Age + "Anos",
                    //PlayerSkill = enrolledUsers.ToList()[i].myStats.rankClassification.ToString()
                };

                flpUsersEvent.Controls.Add(listusers[i]);
            }

            //pbPark.ImageLocation = @"C:\Users\Tiago.Gouveia\Desktop\ProjectDIS\Sports4All\Images\sportsground1.jpg";
            //pbPark.SizeMode = PictureBoxSizeMode.StretchImage;
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



        private void UC_EventsDetailsB_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                eventsController = new MyEventsController();
                PopulateList();
            }
          
        }
    }
}
