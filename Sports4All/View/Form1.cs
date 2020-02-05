using System;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;
using System.Linq;
using Sports4All.Patterns.State;

namespace Sports4All
{
    public partial class Form1 : Form
    {
        private static Form1 _obj;
        private HomeController _homeController;
        private Form1()
        {

            // =============================================================
            //
            // //APAGAR ISTO DEPOIS E COMEÇAR O PROGRAMA NO LOGIN
            Session.Instance.LoggedUser = "ruben21";
            //
            // =============================================================

            InitializeComponent();
            _homeController = new HomeController();
            (new Core.DropShaddow()).ApplyShadows(this);
        }

        public static Form1 Instance
        {
            get
            {
                if (_obj == null) { _obj = new Form1(); }

                return _obj;
            }
        }

        #region Properties
        public Panel PnlContainer
        {
            get => panelContainer;
            set => panelContainer = value;
        }

        public UserControl FrontControl { get; set; }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            MoveSidePanel(btn_Home);
            lbWelcomeUser.Text = "Bem vindo, " + Session.Instance.LoggedUser;

            pbUserImage.Image = ImagesController.Instance.GetImageFromName(_homeController.GetUserLogged(Session.Instance.LoggedUser).Picture.Path);
            lbSkillValue.Text = _homeController.GetUserLogged(Session.Instance.LoggedUser).UserClassification.SkillAverage.ToString();
            lbFairplayValue.Text = _homeController.GetUserLogged(Session.Instance.LoggedUser).UserClassification.FairplayAverage.ToString();
            lbPontosValue.Text = _homeController.GetUserLogged(Session.Instance.LoggedUser).UserClassification.Points.ToString();

            _obj = this;
            AddUserControlsToForm();
        }


        public void BringUcToFront<T>(string ucName, string id, ReserveNoviceForm reserveNoviceForm = null) where T : UserControl, IUserControl, new()
        {
            if (!Instance.PnlContainer.Controls.ContainsKey(ucName))
            {
                if(reserveNoviceForm == null)
                {
                    AddUserControl<T>(ucName, id);
                }
                else
                {
                    AddUserControl<T>(ucName, id, reserveNoviceForm);
                }
            }
            else
            {
                ShowUserControl<T>(ucName, id);
            }
        }

        private void AddUserControl<T>(string ucName, string id) where T : UserControl, IUserControl, new()
        {
            T uc = new T { Dock = DockStyle.Fill };
            uc.Id = id;
            Instance.PnlContainer.Controls.Add(uc);
            FrontControl = uc;
            Instance.PnlContainer.Controls[ucName].BringToFront();
        }

        private void AddUserControl<T>(string ucName, string id, ReserveNoviceForm reserveNoviceForm) where T : UserControl, IUserControl
        {
            UserControl uc = (T)Activator.CreateInstance(typeof(T), reserveNoviceForm);
            uc.Dock = DockStyle.Fill;
            IUserControl j = (IUserControl)uc;
            j.Id = id;
            Instance.PnlContainer.Controls.Add(uc);
            FrontControl = uc;
            Instance.PnlContainer.Controls[ucName].BringToFront();
        }

        private void ShowUserControl<T>(string ucName, string id) where T : UserControl, IUserControl
        {
            foreach (UserControl c in Instance.PnlContainer.Controls)
            {
                if (c.GetType().Name == ucName)
                {
                    Instance.FrontControl = c;
                    IUserControl j = (IUserControl)c;
                    j.Id = id;
                    j.Populate();
                    Instance.PnlContainer.Controls[ucName].BringToFront();
                    return;
                }
            }
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_Home);
            BringUcToFront<UC_Home>("UC_Home", "");
        }

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button2);
            BringUcToFront<UC_Events>("UC_Events", "");
        }

        private void Btn_SportsGround_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button3);
            BringUcToFront<UC_SportsGround>("UC_SportsGround", "");
        }

        private void Btn_MyEvents_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            BringUcToFront<UC_MyEvents>("UC_MyEvents", "");

        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnRanking);
            BringUcToFront<UC_Rank>("UC_Rank", "");
        }

        private void PbUserImage_Click(object sender, EventArgs e)
        {
            BringUcToFront<UC_UserProfile>("UC_UserProfile", Session.Instance.LoggedUser);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoveSidePanel(Button button)
        {
            SidePanel.Height = button.Height;
            SidePanel.Top = button.Top;
        }

        private void AddUserControlsToForm()
        {
            
            UC_Home ens = new UC_Home();
            ReserveNoviceForm rnf = new ReserveNoviceForm();
            //ens.BringToFront();
            //AddUserControl<EventNameState>("EventNameState", "");
            //AddUserControl<UC_Home>("UC_Home", "");
        }
    }
}
