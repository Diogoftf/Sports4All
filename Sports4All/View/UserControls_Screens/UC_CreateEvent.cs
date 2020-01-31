using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Sports4All
{
    public partial class UC_CreateEvent : UserControl, IUserControl
    {
        private Reserve _reserve { get; set; }
        private Event _event { get; set; }

        public UC_CreateEvent()
        {
            InitializeComponent();
            _reserve = new Reserve();
            _event = new Event();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_CreateEvent_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
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
            ReturnHome();
        }

        private void ReturnHome()
        {
            clearFields();
            Form1.Instance.BringUcToFront<UC_Home>("UC_Home", Id);
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

        private void cbEnclosure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEnclosure.SelectedIndex != -1)
            {
                using (ModelContext db = new ModelContext())
                {
                    cbSport.Items.Clear();
                    var localizacaoRecinto = db.Parks.Include("Address.County").Where(f => f.Name.Equals(cbEnclosure.Text)).ToList()[0].Address;

                    tbLocation.Text = localizacaoRecinto.Street + ", " + localizacaoRecinto.PostalCode + ", " + localizacaoRecinto.County.Name;

                    var recintosPark = db.Parks.Include("Grounds").Where(f => f.Name.Equals(cbEnclosure.Text)).ToList()[0].Grounds.ToList();

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

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSport.SelectedIndex != -1)
            {
                using (ModelContext db = new ModelContext())
                {
                    var sport = db.Sports.Where(f => f.Name.Equals(cbSport.Text)).First();

                    var desportoRecinto = db.Grounds.Where(f => f.Park.Name.Equals(cbEnclosure.Text)).ToList();

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
           _event.StartDate = dtpEndEventTime.Value;
        }

        private void dtpEndEventTime_ValueChanged(object sender, EventArgs e)
        {
            _event.EndDate = dtpEndEventTime.Value;
        }

        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            //Se nao ocorreu nenhum erro ao verificar os campos da criação de um evento no Home
            if (checkIntegrity())
            {
                using (ModelContext db = new ModelContext())
                {
                    var WhoAmI = db.Users.First(f => f.Username.Equals(Session.Instance.LoggedUser));
                    _reserve.Date = DateTime.Now;
                    _reserve.Price = 10;
                    _reserve.UserId = WhoAmI.Username;
                    _reserve.Event = _event;

                    _event.Name = txtEventName.Text;
                    _event.StartDate = dtpEventDate.Value.Date + dtpStartEventTime.Value.TimeOfDay;
                    _event.EndDate = dtpEventDate.Value.Date + dtpEndEventTime.Value.TimeOfDay;
                    _event.Name = txtEventName.Text;
                    var users = db.Users.ToList();
                    ICollection<User> listUsers = new Collection<User>();
                    foreach(User a in users)
                    {
                        listUsers.Add(a);
                    }
                    //listUsers.Add(WhoAmI);
                    _event.Users = listUsers;
                    _event.MinAge = Convert.ToInt32(cbMinAge.Text);
                    _event.MaxAge = Convert.ToInt32(cbMaxAge.Text);
                    _event.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);
                    db.Reserves.Add(_reserve);
                    db.Events.Add(_event);
                    db.SaveChanges();
                    MessageBox.Show("Evento criado com sucesso!");

                    ReturnHome();
                }
            }
        }
    }
}
