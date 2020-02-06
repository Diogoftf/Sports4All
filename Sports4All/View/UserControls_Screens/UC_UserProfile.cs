using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_UserProfile : UserControl, IUserControl
    {
        private UserController _userController;
        public UC_UserProfile()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_UserProfile_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Populate();
            }
        }

        public void Populate()
        {
            _userController = new UserController();
            var user = _userController.GetUser(Id);
            IDictionary<string, string> classifications = _userController.GetUserClassification(Id);
            lblUsername.Text = user.Username;
            lblUserEmail.Text = user.Email;
            lblUserPhone.Text = user.PhoneNumber.ToString();
            lblUserEvents.Text = _userController.GetUserEvents(Id);
            cpbUser.Image = ImagesController.Instance.GetImageFromID(user.PictureId);
            lblUserSkill.Text = classifications["Skill"];
            lblUserFairPlay.Text = classifications["FairPlay"];
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Name == "rbtnExpert")
            {
                Session.Instance.IsExperientUser = true;
            }
            else
            {
                Session.Instance.IsExperientUser = false;
            }
        }
    }
}
