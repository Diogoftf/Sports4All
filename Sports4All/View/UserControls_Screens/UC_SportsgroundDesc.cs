using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_SportsgroundDesc : UserControl, IUserControl
    {
        private ParkDescriptionController _parkDescriptionController;
        private bool _controlSub = false;
        private Image _image;

        public UC_SportsgroundDesc()
        {
            InitializeComponent();
            _parkDescriptionController = new ParkDescriptionController(); 
        }

        #region Properties
        public string Id { get; set; }
        public Image Image
        {
            get => _image;
            set { _image = value; pbImage.Image = value; }
        }
        #endregion

        private void UC_SportsgroundDesc_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();
        }

        public void Populate()
        {
            int id = Convert.ToInt32(Id);
            lbSportsgndName.Text = _parkDescriptionController.GetPark(id).Name;
            tbDescription.Text = _parkDescriptionController.GetPark(id).Description;
            pbImage.Image = ImagesController.Instance.GetImageFromID(_parkDescriptionController.GetPark(id).Picture.PictureId);
            lblSportsList.Text = GetFormatedSportsList();
        }

        public string GetFormatedSportsList()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var sport in _parkDescriptionController.GetParkAvailableSports(Convert.ToInt32(Id)))
            {
                builder.Append(sport).Append("|");
            }

            string result = builder.ToString();
            string trimmed = result.TrimEnd('|');

            return trimmed;
        }

        private void btnSeeEvents_Click(object sender, EventArgs e)
        {
            Form1.Instance.BringUcToFront<UC_EventsSportsGrounds>("UC_EventsSportsGrounds", Id);
        }

        private void pbSubscribe_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                pbSubscribe.Image = Image.FromFile(@"..\..\Images\" + "sub_Button.png");
                _controlSub = true;
            }
            else
            {
                pbSubscribe.Image = Image.FromFile(@"..\..\Images\" + "unsub_Button.png");
                _controlSub = false;
            }
        }
    }
}