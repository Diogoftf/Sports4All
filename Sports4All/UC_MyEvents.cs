using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_MyEvents : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public UC_MyEvents()
        {
            InitializeComponent();
            btnFinishedEvents.Select();
            btnFinishedEvents.Focus();
        }


        private void button_EventosTerminados_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minhas_Partidas_Load(object sender, EventArgs e)
        {

            PopulateList();


        }



        private void PopulateList()
        {
            UC_EventMyEventsItem[] listitems = new UC_EventMyEventsItem[20];

            for (int i = 0; i < listitems.Length; i++)
            {
                if (i % 2 == 0)
                {



                    listitems[i] = new UC_EventMyEventsItem();
                    // listitems[i].Day = "01";
                    listitems[i].Avaliar = "Avaliar";

                    //add to flowlayout
                    if (flpListMyEvents.Controls.Count < 0)
                    {

                        flpListMyEvents.Controls.Clear();
                    }
                    else
                    {
                        flpListMyEvents.Controls.Add(listitems[i]);
                    }

                    //*********************lbRemainingTimeEvaluation
                }
                else
                {
                    listitems[i] = new UC_EventMyEventsItem();
                    // listitems[i].Day = "01";
                    listitems[i].Avaliar = "Avaliado!";
                    listitems[i].Change_BackColor = Color.LightGreen;
                    listitems[i].Name = "uc_uniqueRow_MinhasPartidas" + i;



                    //add to flowlayout
                    if (flpListMyEvents.Controls.Count < 0)
                    {

                        flpListMyEvents.Controls.Clear();
                    }
                    else
                    {
                        flpListMyEvents.Controls.Add(listitems[i]);
                    }


                }

            }
        }


        private void button_ProximosEventos_Click(object sender, EventArgs e)
        {

            flpListMyEvents.Controls.Clear();

            // filtrar apenas pelas próximas partidas!

        }

        private void btnNextEvents_Click(object sender, EventArgs e)
        {
/*
            using (QxP1IZ6nAWEntities db = new QxP1IZ6nAWEntities())
            {
                User art = db.User.Where((x) => x.id == 1).FirstOrDefault();

                MessageBox.Show("Teste Query ao User" + art.Address_id);
            }
            */

            //testeQuery();
        }

        /*
        public void testeQuery()
        {

            using (QxP1IZ6nAWEntities db = new QxP1IZ6nAWEntities())
            {
                Event art = db.Event.Where((x) => x.id == 1).FirstOrDefault();

                MessageBox.Show("Teste Query ao Evento" + art.Address_id);
            }


        }
        */
    }
}
