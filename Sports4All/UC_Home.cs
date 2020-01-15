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
    public partial class UC_Home : UserControl
    {
                
        /*
         * MyEvents GUARDA OS EVENTOS QUE TOU INSCRITO E QUE AINDA VAO OU JA FORAM REALIZADOS!
         * 
         * NextEvents Guards os eventos que NAO estou inscrito e só a partir da data atual (HOJE)
         */
        
        private List<UC_HomeMyEventsItem> MyEvents = new List<UC_HomeMyEventsItem>();
        private List<UC_HomeMyEventsItem> NextEvents = new List<UC_HomeMyEventsItem>();

        public UC_Home()
        {
            InitializeComponent();
            InitializateElements();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            UC_CreateEvent1.Visible = true;
        }


        private void lbMySportDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpMySportDate_ValueChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();
            // MessageBox.Show(cbMySport.Text);

            if (cbMySport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    if (MyEvents[i].DateTime == dtpMySportDate.Value.Date)
                    {
                        flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                    }

                }

            }
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            UC_CreateEvent1.Visible = false;
            dtpNextEventDate.MinDate = DateTime.Today;
            PopulateList();

        }

        private void InitializateElements()
        {
           /* var context = new QxP1IZ6nAWEntities();
            var sports = context.Sport.ToList();

            cbMySport.Items.Add("");
            cbNextSport.Items.Add("");
            for (int i = 0; i < sports.Count; i++)
            {
                cbMySport.Items.Add(sports[i].name);
                cbNextSport.Items.Add(sports[i].name);
            }
            */
        }

        private void lbHighlights_Click(object sender, EventArgs e)
        {

        }

        private void lbNextEventDate_Click(object sender, EventArgs e)
        {

        }

        private void PopulateList()
        {
            /*
              FAZER QUERIE PARA OBTER OS EVENTOS QUE JA REALIZEI E QUE VOU REALIZAR
              Onde tem 5 , colocar a quantidade de linhas que correspondem à querie:
              UC_HomeMyEventsItem[] listitems = new UC_HomeMyEventsItem[5];
            */
            UC_HomeMyEventsItem[] listitems = new UC_HomeMyEventsItem[5];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new UC_HomeMyEventsItem();
                /*
                         Quando fores buscar à BD colocar o conteudo de cada item AQUI!!
                          listitems[i].Recinto = "Agua de Pena";
                          listitems[i].Organizador = "Eduardo Gouveia";
                */

                MyEvents.Add(listitems[i]); // MEMBRO DA CLASSE QUE GUARDAR EVENTOS

                flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout

            }

            /* 
             * 
             * SAME LOGIC  
             * FAZER QUERIE PARA OBTER OS PROXIMOS EVENTOS EM QUE NAO ESTOU INSCRITO E AINDA NAO FORAM CONCRETIZADOS
             */

            listitems = new UC_HomeMyEventsItem[5]; // Volto a reescrever a variavel utilizada anteriormente

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new UC_HomeMyEventsItem();
                /*
                         Quando fores buscar à BD colocar o conteudo de cada item AQUI!!
                          listitems[i].Recinto = "Agua de Pena";
                          listitems[i].Organizador = "Eduardo Gouveia";
                */

                NextEvents.Add(listitems[i]);

                flpNextEvents.Controls.Add(listitems[i]); //add to flowlayout

            }


        }

        private void cbMySport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpMyEvents.Controls.Clear();

            if (cbMySport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < MyEvents.Count; i++)
                {
                    if (MyEvents[i].Sport == cbMySport.Text)
                    {
                        flpMyEvents.Controls.Add(MyEvents[i]); //add to flowlayout
                    }

                }

            }

        }

        private void cbNextSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpNextEvents.Controls.Clear();

            if (cbNextSport.SelectedIndex == 0) // Se esta na seleção padrao (ou seja nada foi escolhido)
            {
                for (int i = 0; i < NextEvents.Count; i++)
                {
                    flpNextEvents.Controls.Add(NextEvents[i]); //add to flowlayout
                }
            }
            else
            {
                for (int i = 0; i < NextEvents.Count; i++)
                {
                    if (NextEvents[i].Sport == cbNextSport.Text)
                    {
                        flpNextEvents.Controls.Add(NextEvents[i]); //add to flowlayout
                    }

                }

            }
        }
    }
}
