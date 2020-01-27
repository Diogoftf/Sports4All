using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Sports4All
{
    public partial class UC_CreateEvent : UserControl
    {
        private Reserve _reserve { get; set; }
        private Event _evento { get; set; }
        public UC_CreateEvent()
        {
            InitializeComponent();
            _reserve = new Reserve();
            _evento = new Event();
        }

        private void InitializeElements()
        {
            using (ModelContext context = new ModelContext())
            {
                 List<Park> recintos = context.Parks.ToList();

                 cbEnclosure.Items.Clear();
                 for (int i = 0; i < recintos.Count; i++)
                 {
                     cbEnclosure.Items.Add(recintos[i].Name);
                 }
                  
            }

            dtpEventDate.MinDate = DateTime.Today;

            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.ShowUpDown = true;

            for (int i = 1; i < 21; i++)
            {
                cbPlayersNumber.Items.Add(i);
            }
            
            for (int i = 5; i < 60; i++)
            {
                cbMinAge.Items.Add(i);
                cbMaxAge.Items.Add(i);
            }
           
        }

        private bool checkIntegrity()
        {
            bool verificador = false;

            if (txtEventName.TextLength < 1)
            {
                MessageBox.Show("Devera inserir o nome do evento");
            }
            else if (cbEnclosure.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar o parque desportivo.");
            }
            else if (cbSport.SelectedIndex < 0)
            {
                MessageBox.Show("Devera selecionar o desporto.");

            }
          /*  else if (dtpStartEventTime.Value.Date.Hour == dtpEndEventTime.Value.Date.Hour && dtpStartEventTime.Value.Date.Minute == dtpEndEventTime.Value.Date.Minute)
            {
                MessageBox.Show("As datas do evento são incoerentes.");
            }*/
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

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            clearFields();
            this.Visible = false;
        }

        private void clearFields()
        {
            txtEventName.Clear();
            cbEnclosure.SelectedIndex = -1;
            tbLocation.Clear();
            cbSport.SelectedIndex = -1;
            dtpEventDate.MinDate = DateTime.Now;
            dtpStartEventTime.MinDate = DateTime.Now;
            dtpEndEventTime.MinDate = DateTime.Now;
            cbPlayersNumber.SelectedIndex = -1;
            cbMinAge.SelectedIndex = -1;
            cbMaxAge.SelectedIndex = -1;
        }

        private void cbMinAge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEnclosure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEnclosure.SelectedIndex != -1)
            {
                using (ModelContext db = new ModelContext())
                {
                    cbSport.Items.Clear();
                    var localizacaoRecinto = db.Parks.Include("Address.County").Where(f => f.Name == cbEnclosure.Text).ToList()[0].Address;

                    tbLocation.Text = localizacaoRecinto.Street + ", " + localizacaoRecinto.PostalCode + ", " + localizacaoRecinto.County.Name;

                    var recintosPark = db.Parks.Include("Grounds").Where(f => f.Name == cbEnclosure.Text).ToList()[0].Grounds.ToList();

                    for (int i = 0; i < recintosPark.Count; i++)
                    {
                        for (int j = 0; j < recintosPark[i].Sports.Count; j++)
                        {
                            cbSport.Items.Add(recintosPark[i].Sports.ToList()[j].Name);
                        }
                    }
                }

            }
          
        }

        private void cbMaxAge_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void UC_CreateEvent_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                InitializeElements();
            }
            
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSport.SelectedIndex != -1)
            {
                using (ModelContext db = new ModelContext())
                {
                    var sport = db.Sports.Where(f => f.Name == cbSport.Text).First();

                    var desportoRecinto = db.Grounds.Where(f => f.Park.Name == cbEnclosure.Text).ToList();

                    for (int i = 0; i < desportoRecinto.Count; i++)
                    {
                        for (int j = 0; j < desportoRecinto[i].Sports.ToList().Count; j++)
                        {
                            if (desportoRecinto[i].Sports.ToList()[j].SportId == sport.SportId)
                            {
                                _reserve.GroundId = desportoRecinto[i].GroundId;
                            }
                        }
                    }

                    _reserve.SportId = sport.SportId;

                }

            }


        }

        private void dtpStartEventTime_ValueChanged(object sender, EventArgs e)
        {
           _evento.StartDate = dtpEndEventTime.Value;
        }

        private void dtpEndEventTime_ValueChanged(object sender, EventArgs e)
        {
            _evento.EndDate = dtpEndEventTime.Value;
        }

        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            //Se nao ocorreu nenhum erro ao verificar os campos da criação de um evento no Home
            if (checkIntegrity())
            {
                using (ModelContext db = new ModelContext())
                {
                    var WhoAmI = db.Users.First(f => f.Username == Session.Instance.LoggedUser);
                    _reserve.Date = DateTime.Now;
                    _reserve.Price = 10;
                    _reserve.UserId = WhoAmI.Username;
                    _reserve.Event = _evento;

                    _evento.Name = txtEventName.Text;
                    _evento.StartDate = dtpEventDate.Value.Date + dtpStartEventTime.Value.TimeOfDay;
                    _evento.EndDate = dtpEventDate.Value.Date + dtpEndEventTime.Value.TimeOfDay;
                    _evento.Name = txtEventName.Text;
                    var users = db.Users.ToList();
                    ICollection<User> listUsers = new Collection<User>();
                    foreach(User a in users)
                    {
                        listUsers.Add(a);
                    }
                    //listUsers.Add(WhoAmI);
                    _evento.Users = listUsers;
                    _evento.MinAge = Convert.ToInt32(cbMinAge.Text);
                    _evento.MaxAge = Convert.ToInt32(cbMaxAge.Text);
                    _evento.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);
                    db.Reserves.Add(_reserve);
                    db.Events.Add(_evento);
                    db.SaveChanges();
                    MessageBox.Show("Evento criado com sucesso!");
                    clearFields();
                    this.Visible = false;
                    
                    
                }
            }
        }
    }
}
