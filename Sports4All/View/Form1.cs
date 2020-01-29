using Sports4All.UserControls_Screens;
using System;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class Form1 : Form
    {
        private static Form1 _obj;

        private Form1()
        {
            InitializeComponent();

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
            
            using (var db = new ModelContext())
            {
                var user = db.Users.Include("Picture").Where(f => f.Username == Session.Instance.LoggedUser).Single();
                pbUserImage.Image = ImagesController.GetImageFromName(user.Picture.Path);
            }
            _obj = this;
            AddUserControlsToForm();
        }


        public void BringUcToFront<T>(string ucName, string id) where T : UserControl, IUserControl, new()
        {
            //Instance.PnlContainer.Controls.Clear();
            if (!Instance.PnlContainer.Controls.ContainsKey(ucName))
            {
                AddUserControl<T>(ucName, id);
            }
            else
            {
                CreateAndAddUserControl<T>(ucName, id);
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

        private void CreateAndAddUserControl<T>(string ucName, string id) where T : UserControl, IUserControl, new()
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

        private void Btn_Subscriptions_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button4);
            BringUcToFront<UC_Subscriptions>("UC_Subscriptions", "");
        }

        private void Btn_MyEvents_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            BringUcToFront<UC_MyEvents>("UC_MyEvents", "");

        }

        private void Btn_Addfriend_Click(object sender, EventArgs e)
        {
            BringUcToFront<UC_AddFriend>("UC_AddFriend", "");
        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnRanking);
            BringUcToFront<UC_Rank>("UC_Rank", "");
        }

        private void PbUserImage_Click(object sender, EventArgs e)
        {
            BringUcToFront<UC_UserProfile>("UC_UserProfile", "");
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
            AddUserControl<UC_Home>("UC_Home", "");
        }

    }
}
