using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Sports4All.Controller;
using Sports4All.CreateEvent;

namespace Sports4All
{
    public partial class UC_CreateEvent : UserControl, IUserControl
    {
        private IPriceEntity _priceEntity { get;set; }
        private CreateEventController _createEventController { get; set; }
        private Reserve _reserve { get; set; }
        private Event _event { get; set; }
        public UC_CreateEvent()
        {
            InitializeComponent();
            _reserve = new Reserve();
            _createEventController = new CreateEventController();
            _reserve.Price = 0;
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
            ICollection<Park> recintos = _createEventController.GetAllParks();

            cbPark.Items.Clear();
            for (int i = 0; i < recintos.Count; i++)
            {
                cbPark.Items.Add(recintos.ToList()[i].Name);
            }

            dtpEventDate.MinDate = DateTime.Today;

            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.ShowUpDown = true;

            for (int i = 2; i < 22; i += 2)
            {
                cbPlayersNumber.Items.Add(i);
            }

            for (int i = 5; i < 100; i += 5)
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
            this.Parent.Controls.Remove(this);
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
            if (cbPark.SelectedIndex != -1)
            {
                Park parkChoosed = _createEventController.GetPark(cbPark.Text);

                tbLocation.Text = parkChoosed.Address.Street + ", " + parkChoosed.Address.PostalCode + ", " + parkChoosed.Address.County.Name;

                cbSport.Items.Clear(); cbSport.SelectedIndex = -1;
                for (int i = 0; i < parkChoosed.Grounds.Count; i++)
                {
                    for (int j = 0; j < parkChoosed.Grounds.ToList()[i].Sports.Count; j++)
                    {
                        cbSport.Items.Add(parkChoosed.Grounds.ToList()[i].Sports.ToList()[j].Name);
                    }
                }

            }
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSport.SelectedIndex != -1)
            {

           
                var sport = _createEventController.GetSport(cbSport.Text);

                var parkId = _createEventController.GetPark(cbPark.Text).ParkId;

                var groundsRecinto = _createEventController.GetGrounds(cbPark.Text).ToList();

                for (int i = 0; i < groundsRecinto.Count; i++)
                {
                    for (int j = 0; j < groundsRecinto[i].Sports.ToList().Count; j++)
                    {
                        if (groundsRecinto[i].Sports.ToList()[j].SportId == sport.SportId)//
                        {
                            _reserve.GroundId = groundsRecinto[i].GroundId;
                            _reserve.SportId = sport.SportId;
                            _reserve.Price = groundsRecinto[i].Price;
                            lbMoney.Text = _reserve.Price.ToString();
                            _priceEntity = groundsRecinto[i];

                        }

                    }
                }

                var materiais = _createEventController.GetMaterialsFromSport(_reserve.SportId, parkId).ToList();

                flpMaterial.Controls.Clear();

                if (materiais.Count > 0)
                {
                    for (int k = 0; k < materiais.Count; k++)
                    {
                        UC_MaterialItem temp = new UC_MaterialItem(_priceEntity);
                        temp.Material = materiais[k].Name;
                        temp.PopulateQuantity(materiais[k].Available);
                        temp.Preço = materiais[k].Price.ToString();
                        flpMaterial.Controls.Add(temp);
                        temp.TotalPrice = lbMoney;
                        temp.CBQuantidade.SelectedIndexChanged += new EventHandler(CB_MaterialQuantity_Handler);
                    }
                }

            }

        }

        private void CB_MaterialQuantity_Handler(object sender, EventArgs e)
        {
            ComboBox eventOriginator = (ComboBox)sender;

            switch ("Raquete")
            {
                case "Raquete":
                    _priceEntity = new RaqueteDecorator(_priceEntity, eventOriginator.SelectedIndex);
                    break;
                case "Bola":
                    _priceEntity = new BolaDecorator(_priceEntity, eventOriginator.SelectedIndex);
                    break;
            }

            lbMoney.Text = Convert.ToString(_priceEntity.getCost());

        }

        private void cbQuantity(object sender, EventArgs e)
    {

   
    }
        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            //if(checkIntegrity())
            {
                ICollection<Use> materialUsage = new HashSet<Use>();
                ICollection<User> listUsers = new Collection<User>();
                CreateEventController _createEventController = new CreateEventController();

                _createEventController.RetrieveMaterial(flpMaterial, materialUsage, _reserve);
                _createEventController.InsertDataReserve(_reserve, _event, materialUsage);
                _reserve.ReserveId = _createEventController.getIdReserve();
                _reserve.Price = _priceEntity.getCost();

                _event.EventId = _createEventController.getIdEvent();
                _event.Name = txtEventName.Text;
                _event.StartDate = dtpEventDate.Value.Date + dtpStartEventTime.Value.TimeOfDay;
                _event.EndDate = dtpEventDate.Value.Date + dtpEndEventTime.Value.TimeOfDay;
                _event.Name = txtEventName.Text;

                _event.MinAge = Convert.ToInt32(cbMinAge.Text);
                _event.MaxAge = Convert.ToInt32(cbMaxAge.Text);
                _event.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);


                _createEventController.createReserve(materialUsage, _reserve, _event);
                _createEventController.InsertUserNewEvent(_event);
                MessageBox.Show("Reserva criada com sucesso!");
                ReturnHome();
            }

        }
    }
}
