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
    public partial class UC_CreateEvent : UserControl
    {
        private Event eventoNovo;

        public UC_CreateEvent()
        {
            InitializeComponent();
            InitializeElements();
            eventoNovo = new Event();
        }

        private void InitializeElements()
        {
            using (ModelContext context = new ModelContext())
            {
                /* List<SportsGround> recintos = context.Events.ToList();

                 cbEnclosure.Items.Clear();
                 for (int i = 0; i < recintos.Count; i++)
                 {
                     cbEnclosure.Items.Add(recintos[i].name);
                 }
                  */
            }

            dtpEventDate.MinDate = DateTime.Today;

            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.ShowUpDown = true;

            for (int i = 1; i < 21; i++)
            {
                cbPlayersNumber.Items.Add(i);
            }
            
            for (int i = 5; i < 80; i++)
            {
                cbMinAge.Items.Add(i);
                cbMaxAge.Items.Add(i);
            }
           
        }

        private bool verificadorDeCamposEventos()
        {
            bool verificador = false;

            // FALTA VERIFICAR OS HORARIOS DOS EVENTOS
            if (cbEnclosure.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar o recinto.");
            }
            else if (cbSport.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar o desporto.");

            }
            else if (dtpStartEventTime.Value.TimeOfDay >= dtpEndEventTime.Value.TimeOfDay || dtpEndEventTime.Value.TimeOfDay <= dtpStartEventTime.Value.TimeOfDay)
            {
                MessageBox.Show("As datas do evento são incoerentes.");
            }
            else if (cbPlayersNumber.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar o numero de jogadores.");
            }
            else if (cbMaxAge.SelectedIndex < 0 || cbMinAge.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar a Idade de jogadores.");
            }
            else if (Int32.Parse(cbMaxAge.SelectedItem.ToString()) <= Int32.Parse(cbMinAge.SelectedItem.ToString()) || Int32.Parse(cbMinAge.SelectedItem.ToString()) >= Int32.Parse(cbMaxAge.SelectedItem.ToString()))
            {
                MessageBox.Show("A idade dos jogadores que irao participar nao é valida");
            }
            else
            {
                verificador = true;
            }

            return verificador;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
                //Se nao ocorreu nenhum erro ao verificar os campos da criação de um evento no Home
            if (verificadorDeCamposEventos())
            {

                // Event EventHome = new Event();  done
                //EventHome.SportsGround_id = ;   done
                //EventHome.Sport_id = ;        done
                //EventHome.startTime = ;      done
                //EventHome.endTime = ; done

                var context = new ModelContext();
               // eventoNovo.id = default;
               // context.Event.Add(eventoNovo);
                context.SaveChanges();
                MessageBox.Show("Evento criado com sucesso!");
                this.Visible = false;
            }
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void checkIntregrityAgePlayers()
        {
            int valueMin = Int32.Parse(cbMinAge.Text);
            int valueMax = Int32.Parse(cbMaxAge.Text);

            cbMinAge.Items.Clear();
            cbMaxAge.Items.Clear();
            if (valueMin > valueMax)
            {
                valueMin++;
                for (int i = valueMin; i < 80; i++)
                {
                    cbMaxAge.Items.Add(i);
                }
            }
            else
            {
                valueMax++;
                for (int i = valueMax; i < 80; i++)
                {
                    cbMinAge.Items.Add(i);
                }
            }
        }

        private void cbMinAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkIntregrityAgePlayers();

        }

        private void cbEnclosure_SelectedIndexChanged(object sender, EventArgs e)
        {
         /*   var context = new ModelContext();

            var localizacaoRecinto = (from a in context.SportsGround
                                      join c in context.Address on a.Address_id equals c.id
                                      where a.name == cbEnclosure.Text
                                      select new
                                      {
                                          a.id,
                                          a.Address_id,
                                          c.street,
                                          c.postalCode,
                                          c.county
                                      }).SingleOrDefault();

            eventoNovo.Address_id = localizacaoRecinto.Address_id;
            tbLocation.Text = localizacaoRecinto.street + ", " + localizacaoRecinto.postalCode + ", " + localizacaoRecinto.county;

            var desportosRecinto = (from a in context.SportsGround_has_Sport
                                      join c in context.Sport on a.SportsGround_id equals localizacaoRecinto.id
                                    where c.id == a.Sport_id
                                    select new
                                      {
                                          c.name,
                                          c.id
                                      }).ToList();

            cbSport.Items.Clear();
            for (int i = 0; i < desportosRecinto.Count; i++)
            {
                cbSport.Items.Add(desportosRecinto[i].name);
            }

            /// !!! TEMPORARIO !!!
            eventoNovo.SportsGround_id = localizacaoRecinto.id;*/
        }

        private void cbMaxAge_SelectedIndexChanged(object sender, EventArgs e)
        {
           //checkIntregrityAgePlayers();
        }

        private void UC_CreateEvent_Load(object sender, EventArgs e)
        {
            //InitializeElements();
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var context = new ModelContext();
          var desportoRecinto = (from a in context.SportsGround_has_Sport
                                   join c in context.Sport on a.SportsGround_id equals eventoNovo.SportsGround_id
                                   where c.id == a.Sport_id && c.name == cbSport.Text
                                  select new
                                   {
                                       c.name,
                                       c.id
                                   }).FirstOrDefault();*/

            //  eventoNovo.Sport_id = desportoRecinto.id;
        }

        private void dtpStartEventTime_ValueChanged(object sender, EventArgs e)
        {
           // eventoNovo.startTime = TimeSpan.Parse(dtpEndEventTime.Value.TimeOfDay.ToString());
        }

        private void dtpEndEventTime_ValueChanged(object sender, EventArgs e)
        {
           // eventoNovo.endTime = TimeSpan.Parse(dtpEndEventTime.Value.TimeOfDay.ToString());
        }
    }
}
