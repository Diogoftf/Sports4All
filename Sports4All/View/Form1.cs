using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.UserControls_Screens;

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

        public Panel PnlContainer
        {
            get => panelContainer;
            set => panelContainer = value;
        }

        public UserControl FrontControl { get; set; }


        private void BringUcToFront<T>(string ucName) where T : UserControl, new()
        {
            if (!Instance.PnlContainer.Controls.ContainsKey(ucName))
            {
                AddUserControl<T>();
            }

            Instance.PnlContainer.Controls[ucName].BringToFront();
        }

        private void AddUserControl<T>() where T : UserControl, new()
        {
            T uc = new T { Dock = DockStyle.Fill };
            Instance.PnlContainer.Controls.Add(uc);
            FrontControl = uc;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_Home);
            BringUcToFront<UC_Home>("UC_Home");
        }

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button2);
            BringUcToFront<UC_Events>("UC_Events");
        }

        private void Btn_SportsGround_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button3);
            BringUcToFront<UC_SportsGround>("UC_SportsGround");
        }

        private void Btn_Subscriptions_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button4);
            BringUcToFront<UC_Subscriptions>("UC_Subscriptions");
        }

        private void Btn_MyEvents_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            //button6.BackColor = Color.DarkGray;
            BringUcToFront<UC_MyEvents>("UC_MyEvents");

        }

        private void Btn_Addfriend_Click(object sender, EventArgs e)
        {
            BringUcToFront<UC_AddFriend>("UC_AddFriend");
        }

        private void MoveSidePanel(Button button)
        {
            SidePanel.Height = button.Height;
            SidePanel.Top = button.Top;
        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnRanking);
            BringUcToFront<UC_Rank>("UC_Rank");
        }

        private void PbUserImage_Click(object sender, EventArgs e)
        {
            BringUcToFront<UC_UserProfile>("UC_UserProfile");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoveSidePanel(btn_Home);
            lbWelcomeUser.Text = "Bem vindo, " + Session.Instance.LoggedUser;

            _obj = this;
            AddUserControlsToForm();
            
            using (var db = new ModelContext())
            {
               pbUserImage.Image = Image.FromFile(@"..\..\Images\" + "user1.png");
                
            }

        }

        private void AddUserControlsToForm()
        {
            AddUserControl<UC_Home>();
            AddUserControl<UC_Events>();
            AddUserControl<UC_SportsGround>();
            AddUserControl<UC_Subscriptions>();
            AddUserControl<UC_Rank>();
            AddUserControl<UC_MyEvents>();
            AddUserControl<UC_AddFriend>();
            AddUserControl<UC_UserProfile>();
        }

    }
}
