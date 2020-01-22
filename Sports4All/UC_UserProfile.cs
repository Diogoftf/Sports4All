using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_UserProfile : UserControl
    {
        private UserController _userController;
        public UC_UserProfile()
        {
            InitializeComponent();
           
        }

        public void populateUC ()
        {
                _userController = new UserController();
                _userController.UserId = "rubin0"; //APAGAR DEPOIS
                var user = _userController.GetUser(_userController.UserId);
                IDictionary<string, string> classifications = _userController.GetUserClassification(_userController.UserId);
                //cpbUser.Image = _userController.GetUser(_userController.UserId).Picture;
                lblUsername.Text = user.Username;
                lblUserEmail.Text = user.Email;
                lblUserPhone.Text = user.PhoneNumber.ToString();
                lblUserEvents.Text = _userController.GetUserEvents(_userController.UserId);
                lblUserSubscribers.Text = "AINDA POR FAZER";
                lblUserSkill.Text = classifications["Skill"];
                lblUserFairPlay.Text = classifications["FairPlay"];
        }

        private void UC_UserProfile_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                populateUC();
            }
        }
    }
}
