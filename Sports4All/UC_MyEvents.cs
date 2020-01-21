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
    public partial class UC_MyEvents : UserControl
    {
     
        private int _totalUserEvents { get; set; }

        
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
        private void PopulateList()
        {
            //int TotalEvents =  eventsController


           UC_EventMyEventsItem[] listitems = new UC_EventMyEventsItem[10];

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


    }
}
