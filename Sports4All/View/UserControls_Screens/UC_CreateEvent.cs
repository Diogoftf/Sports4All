using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;
using Sports4All.Decorator;

namespace Sports4All
{
    public partial class UC_CreateEvent : UserControl, IUserControl
    {
        private IPriceEntity _priceEntity { get;set; }
       private ICollection<UserEvaluation> _userEvaluations { get; set; }
        private CreateEventController _createEventController { get; set; }
        private RankController _rankController { get; set; }
        private Reserve _reserve { get; set; }
        private Event Event { get; set; }
        private string _username { get; set; }

        private int _parkId { get; set; }
        public UC_CreateEvent()
        {
            InitializeComponent();
            _reserve = new Reserve();
            _createEventController = new CreateEventController();
            _rankController = new RankController();
            _reserve.Price = 0;
            Event = new Event();
            _username = Session.Instance.LoggedUser;

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
            ICollection<Park> groundsList = _createEventController.GetAllParks();
            cbPark.Items.Clear();

            foreach (var ground in groundsList)
            {
                cbPark.Items.Add(ground.Name);
            }

            dtpEventDate.MinDate = DateTime.Today;

            dtpStartEventTime.CustomFormat = "HH:mm";
            dtpStartEventTime.Format = DateTimePickerFormat.Custom;
            dtpStartEventTime.ShowUpDown = true;

            dtpEndEventTime.CustomFormat = "HH:mm";
            dtpEndEventTime.Format = DateTimePickerFormat.Custom;
            dtpEndEventTime.ShowUpDown = true;
            dtpEndEventTime.MinDate = DateTime.Now.AddHours(1.0);

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
            bool isOk = false;

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
                isOk = true;
            }

            return isOk;
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            ReturnHome();
        }

        private void ReturnHome()
        {
            clearFields();
            Parent.Controls.Remove(this);
            Form1.Instance.BringUcToFront<UC_Home>("UC_Home", Id);
        }

        private void clearFields()
        {
            cbPark.SelectedIndex = -1;
            cbSport.SelectedIndex = -1;
            cbPlayersNumber.SelectedIndex = -1;
            cbMinAge.SelectedIndex = -1;
            cbMaxAge.SelectedIndex = -1;
            txtEventName.Clear();
            tbLocation.Clear();
            cbSport.Items.Clear();
            dtpEventDate.MinDate = DateTime.Now;
            dtpStartEventTime.MinDate = DateTime.Now;
            dtpEndEventTime.MinDate = DateTime.Now.AddHours(1.0);
            _priceEntity = null;
            flpMaterial.Controls.Clear();
        }

        private void cbPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPark.SelectedIndex != -1)
            {
                Park parkChoosed = _createEventController.GetPark(cbPark.Text);

                tbLocation.Text = parkChoosed.Address.Street + ", " + parkChoosed.Address.PostalCode + ", " + parkChoosed.Address.County.Name;

                cbSport.Items.Clear(); cbSport.SelectedIndex = -1;
                foreach (var ground in parkChoosed.Grounds)
                {
                    foreach (var s in ground.Sports)
                    {
                        cbSport.Items.Add(s.Name);
                    }
                }

            }
        }

        private void cbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSport.SelectedIndex != -1)
            {
                var sport = _createEventController.GetSport(cbSport.Text);
                _parkId = _createEventController.GetPark(cbPark.Text).ParkId;
                var parkGrounds = _createEventController.GetGrounds(cbPark.Text).ToList();

               
                foreach (var ground in parkGrounds)
                {
                    foreach (var s in ground.Sports)
                    {
                        if (s.SportId == sport.SportId)
                        {
                            _reserve.GroundId = ground.GroundId;
                            _reserve.SportId = sport.SportId;
                            _priceEntity = ground;
                        }
                    }
                }

                var materialList = _createEventController.GetMaterialsFromSport(_reserve.SportId, _parkId).ToList();

                flpMaterial.Controls.Clear();

                if (materialList.Count > 0)
                {
                    foreach (var material in materialList)
                    {
                        UC_MaterialItem temp = new UC_MaterialItem(_priceEntity);
                        temp.Material = material.Name;
                        temp.PopulateQuantity(material.Available);
                        temp.Price = material.Price.ToString();
                        flpMaterial.Controls.Add(temp);
                    }
                }

            }
        }

        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            if(checkIntegrity())
            {
                decorateGroundSelected();

                DialogResult result = MessageBox.Show("Montante: " + _priceEntity.getCost() + "€" + " \nDeseja criar a reserva? ", "Confirme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ICollection<Use> materialUsage = new HashSet<Use>();

                    _createEventController.RetrieveMaterial(flpMaterial, materialUsage, _reserve);
                    _createEventController.InsertDataReserve(_reserve, Event, materialUsage);
                    _reserve.Price = _priceEntity.getCost();

                    Event.Name = txtEventName.Text;
                    Event.StartDate = dtpEventDate.Value.Date + dtpStartEventTime.Value.TimeOfDay;
                    Event.EndDate = dtpEventDate.Value.Date + dtpEndEventTime.Value.TimeOfDay;

                    Event.MinAge = Convert.ToInt32(cbMinAge.Text);
                    Event.MaxAge = Convert.ToInt32(cbMaxAge.Text);
                    Event.MaxPlayers = Convert.ToInt32(cbPlayersNumber.Text);

                    _createEventController.CreateReserve(materialUsage, _reserve, Event);
                    _createEventController.InsertUserNewEvent(Event);
                    _rankController.UpdateUserClassification(_username);
                    _rankController.UpdateParkClassification(_parkId);
                    Form1.Instance.UpdateUserPoints(_rankController.GetUserPoints(_username));
                    ReturnHome();
                }
                else
                {
                    clearFields();
                }

            }
        }

        private void decorateGroundSelected()
        {
            foreach (var control in flpMaterial.Controls)
            {
                UC_MaterialItem uc_material = (UC_MaterialItem)control;
                if (uc_material.Quantity > 0 )
                {
                    switch (uc_material.Material)
                    {
                        case "Raquete":
                            _priceEntity = new RacketDecorator(_priceEntity, uc_material.Quantity, Convert.ToDouble(uc_material.Price));
                            break;
                        case "Bola":
                            _priceEntity = new BallDecorator(_priceEntity, uc_material.Quantity, Convert.ToDouble(uc_material.Price));
                            break;
                    }
                }
            }

            int NumberOfHoursPlaying = Convert.ToInt32(dtpEndEventTime.Value.Subtract(dtpStartEventTime.Value).TotalHours);

            if (NumberOfHoursPlaying > 1)
            {
                NumberOfHoursPlaying-=1;
                _priceEntity = new TimeDecorator(_priceEntity,NumberOfHoursPlaying, _createEventController.GetGround(_reserve.GroundId).Price);
            }

        }
    }
}
