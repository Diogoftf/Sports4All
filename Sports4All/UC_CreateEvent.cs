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

                 cbPark.Items.Clear();
                 for (int i = 0; i < recintos.Count; i++)
                 {
                    cbPark.Items.Add(recintos[i].Name);
                 }
                  
            }

            dtpEventDate.MinDate = DateTime.Today;

            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.ShowUpDown = true;

            for (int i = 2; i < 22; i+=2)
            {
                cbPlayersNumber.Items.Add(i);
            }
            
            for (int i = 5; i < 100; i+=5)
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
            else if (cbPark.SelectedIndex < 0)
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
            cbPark.Items.Clear();
            tbLocation.Clear();
            cbSport.Items.Clear();
            dtpEventDate.MinDate = DateTime.Now;
            dtpStartEventTime.MinDate = DateTime.Now;
            dtpEndEventTime.MinDate = DateTime.Now;
            cbPlayersNumber.Items.Clear();
            cbMinAge.Items.Clear();
            cbMaxAge.Items.Clear();
            cbPlayersNumber.Items.Clear();
        }

        private void cbPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPark.SelectedIndex != -1)
            {
                using (ModelContext db = new ModelContext())
                {
                    cbSport.Items.Clear();
                    var Park = db.Parks
                        .Include("Address.County")
                        .Include("Grounds")
                        .Include("Materials")
                        .Where(f => f.Name.Equals(cbPark.Text)).FirstOrDefault();

                    tbLocation.Text = Park.Address.Street + ", " + Park.Address.PostalCode + ", " + Park.Address.County.Name;

                    for (int i = 0; i < Park.Grounds.Count; i++)
                    {
                        for (int j = 0; j < Park.Grounds.ToList()[i].Sports.Count; j++)
                        {
                            cbSport.Items.Add(Park.Grounds.ToList()[i].Sports.ToList()[j].Name);
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
                    var sport = db.Sports
                        .Where(f => f.Name.Equals(cbSport.Text)).First();

                    var parkId = db.Parks.First(f => f.Name == cbPark.Text).ParkId;

                    var groundsRecinto = db.Grounds.Where(f => f.Park.Name.Equals(cbPark.Text)).ToList();

                    for (int i = 0; i < groundsRecinto.Count; i++)
                    {
                        for (int j = 0; j < groundsRecinto[i].Sports.ToList().Count; j++)
                        {
                            if (groundsRecinto[i].Sports.ToList()[j].SportId == sport.SportId)//
                            {
                                _reserve.GroundId = groundsRecinto[i].GroundId;
                                _reserve.SportId = sport.SportId;
                            }
                        }
                    }

                    //listMaterials.Add(new Material() { MaterialId = 1, Available = 4, Price = 6, Name = "Bola", SportId = listSports.ToList()[0].SportId, ParkId = listParks.ToList()[0].ParkId});
                    var materiais = db.Materials
                        .Where(f => f.Sport.SportId == _reserve.SportId && f.ParkId == parkId).ToList();

                    flpMaterial.Controls.Clear();
                    if (materiais.Count > 0)
                    {
                        for (int k = 0; k < materiais.Count; k++)
                        {
                            UC_MaterialItem temp = new UC_MaterialItem();
                            temp.Material = materiais[k].Name;
                            temp.PopulateQuantity(materiais[k].Available);
                            temp.Preço = materiais[k].Price + " €";
                            flpMaterial.Controls.Add(temp);

                        }
                    }
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
            ICollection<Use> materialUsage = new HashSet<Use>();

            //Se nao ocorreu nenhum erro ao verificar os campos da criação de um evento no Home
          //  if (checkIntegrity())
            {
                using (ModelContext db = new ModelContext())
                {
                    var WhoAmI = db.Users.First(f => f.Username.Equals(Session.Instance.LoggedUser));
                    
                    for(int i = 0; i < flpMaterial.Controls.Count; i++)
                    {
                        UC_MaterialItem item = flpMaterial.Controls[i] as UC_MaterialItem;
                        if (item.Quantidade > 0)
                        {
                            var use = new Use();
                            var query = db.Materials.Where(f => f.Name == item.Material).First();
                            use.MaterialId = query.MaterialId;
                            use.Quantity = item.Quantidade;
                            use.Reserve = _reserve;
                            materialUsage.Add(use);
                        }
                    }
                                       
                    _reserve.Date = DateTime.Now;
                    _reserve.Price = 10;
                    _reserve.UserId = WhoAmI.Username;
                    _reserve.Event = _event;
                    if (materialUsage.Count > 0) _reserve.Uses = materialUsage;

                    _event.Name = txtEventName.Text;
                    _event.StartDate = dtpEventDate.Value.Date + dtpStartEventTime.Value.TimeOfDay;
                    _event.EndDate = dtpEventDate.Value.Date + dtpEndEventTime.Value.TimeOfDay;
                    _event.Name = txtEventName.Text;
                    
                    /* TEMPORARIO SOMENTE PARA FACILITAR OS TESTES */
                    var users = db.Users.ToList();
                    ICollection<User> listUsers = new Collection<User>();
                    foreach(User ba in users)
                    {
                        listUsers.Add(ba);
                    }
                    /* TEMPORARIO SOMENTE PARA FACILITAR OS TESTES */

                    _event.Users = listUsers;
                    _event.MinAge = Convert.ToInt32(cbMinAge.Text);
                    _event.MaxAge = Convert.ToInt32(cbMaxAge.Text);
                    _event.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);

                    for (int i = 0; i < materialUsage.Count; i++)
                    {
                        var query = db.Materials.Find(materialUsage.ToList()[i].MaterialId);


                        if (query.Available - materialUsage.ToList()[i].Quantity < 0)
                            query.Available = 0;
                        else
                            query.Available -= materialUsage.ToList()[i].Quantity;

                        db.Uses.Add(materialUsage.ToList()[i]);
                    }

                    db.Reserves.Add(_reserve);
                    db.Events.Add(_event);
                    db.SaveChanges();
                    MessageBox.Show("Reserva criada com sucesso!");

                    ReturnHome();
                }
            }
        }
    }
}
