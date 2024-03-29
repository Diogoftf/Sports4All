﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;
using Sports4All.Decorator;

namespace Sports4All.Patterns.State
{
    public partial class SelectMaterialState : UserControl, IReserveFormState
    {
        private ReserveNoviceForm _reserveNoviceForm;
        private CreateEventController _createEventController;
        private IPriceEntity _priceEntity { get; set; }

        public SelectMaterialState()
        {
            InitializeComponent();
        }

        public SelectMaterialState(ReserveNoviceForm reserveNoviceForm)
        {
            InitializeComponent();
            _reserveNoviceForm = reserveNoviceForm;
            _createEventController = new CreateEventController();
        }

        public string Id { get; set; }

        public void Display()
        {
            Form1.Instance.BringUcToFront<SelectMaterialState>("SelectMaterialState", "", _reserveNoviceForm);
        }

        public void NextScreen()
        {
            EventCreationManager.Instance.DecorateGroundFromMaterialSelected();
            _reserveNoviceForm.SetState(_reserveNoviceForm.DefineUsersState);
        }

        public void PreviousScreen()
        {
            _reserveNoviceForm.SetState(_reserveNoviceForm.AskForMaterialState);
        }

        public void Populate()
        {
            PopulateMaterial();

            nextScreenButton.ReserveNoviceForm = _reserveNoviceForm;
            previousScreenButton.ReserveNoviceForm = _reserveNoviceForm;
        }

        public void PopulateMaterial()
        {
            flpMaterial.Controls.Clear();

            int sportId = EventCreationManager.Instance.SportId;
            int parkId = EventCreationManager.Instance.ParkId;

            var materials = _createEventController.GetMaterialsFromSport(sportId, parkId).ToList();
            
            if (materials.Any())
            {
                foreach (var material in materials)
                {
                    UC_MaterialItem temp = new UC_MaterialItem(_priceEntity);
                    temp.CbQuantity.SelectionChangeCommitted += new EventHandler(this.SaveMaterials);
                    temp.Material = material.Name;
                    temp.PopulateQuantity(material.Available);
                    temp.Price = material.Price.ToString();
                    flpMaterial.Controls.Add(temp);
                }
            }
        }

        public void SaveMaterials(object sender, EventArgs e)
        {
            List<UC_MaterialItem> materialItems = new List<UC_MaterialItem>();

            foreach (var control in flpMaterial.Controls)
            {
                UC_MaterialItem uc_material = (UC_MaterialItem)control;

                if (uc_material.Quantity > 0)
                {
                    materialItems.Add(uc_material);
                }
            }

            EventCreationManager.Instance.SetMaterialsItems(materialItems);
        }

        private void SelectMaterialState_Load(object sender, EventArgs e)
        {
            Populate();
        }

    }
}
