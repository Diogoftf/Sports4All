using Sports4All.Controller;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class Authentication : Form
    {
        private readonly AuthController _authController;
        private int _selectedPicture;

        public Authentication()
        {
            InitializeComponent();

            _authController = new AuthController();

            _selectedPicture = 1;
            (new Core.DropShaddow()).ApplyShadows(this);
            HideTabHeaders();
            EnableValidationFromTab(tabRegister, false);
            //EnableTab(tabRegister, false);
        }

        public void HideTabHeaders()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            EnableValidationFromTab(tabRegister, true);
            EnableValidationFromTab(tabLogin, false);
            //EnableTab(tabLogin, false);
            //EnableTab(tabRegister, true);
        }

        private void linkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            EnableValidationFromTab(tabLogin, true);
            EnableValidationFromTab(tabRegister, false);
            //EnableTab(tabRegister, false);
            //EnableTab(tabLogin, true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (checkedValues())
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
        }

        public bool checkedValues()
        {
            var email = tbLogEmail.Text;
            var password = tbLogPassword.Text;

            if (!_authController.RightLoginCredentials(email, password))
            {
                string message = "Insira um par email/password válido.";
                MessageBox.Show(message);
                return false;
            }

            return true;
        }

        private void tbLogPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogPassword.Text))
            {
                e.Cancel = true;
                tbLogPassword.Focus();
                errorProvider1.SetError(tbLogPassword, "Please enter your password.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLogPassword, null);
            }
        }

        private void tbLogEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogEmail.Text))
            {
                e.Cancel = true;
                tbLogEmail.Focus();
                errorProvider1.SetError(tbLogEmail, "Please enter your email.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLogEmail, null);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (AddDataToDb())
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
        }

        private bool AddDataToDb()
        {
            var email = tbRegEmail.Text;
            var password = tbRegPassword.Text;
            var username = tbRegUsername.Text;
            var age = tbRegAge.Text;
            var cellphone = tbRegPhone.Text;

            if (_authController.EmailExists(email))
            {
                string message = "O email que inseriu já se encontra registado.";
                MessageBox.Show(message);
                return false;
            }

            if (_authController.UsernameExists(username))
            {
                string message = "O username que inseriu já existe.";
                MessageBox.Show(message);
                return false;
            }

            _authController.RegisterUser(email, password, username, age, cellphone);
            return true;



            /*
            bool add = true;
            bool combinacaoInvalida = true;

            using (var db = new ModelContext())
            {
                
                //var user = (from u in db.Users
                //    where u.Email == email
                //    select u).FirstOrDefault<User>();

                var query = from u in db.Users
                            select u;

                foreach (var item in query)
                {
                    if (item.Email.Equals(email))
                    {
                        string message = "O email que inseriu já se contra registado.";
                        MessageBox.Show(message);
                        add = false;
                        return add;
                    }

                    if (item.Username.Equals(username))
                    {
                        string message = "O username que inseriu já existe.";
                        MessageBox.Show(message);
                        add = false;
                        return add;
                    }
                }

                var newUser = new User();
                newUser.Email = email;
                newUser.Password = password;
                newUser.Username = username;
                newUser.Age = Convert.ToInt32(age);
                newUser.PhoneNumber = Convert.ToInt32(cellphone);
                //newUser.Picture = _selectedPicture;

                db.Users.Add(newUser);
                db.SaveChanges();

                return add;
                
            }*/
        }

        private void tbRegEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegEmail.Text))
            {
                ShowErrorMessage(e, tbRegEmail, "Por favor, insira o seu email.");
            }
            else if (!IsEmail(tbRegEmail.Text))
            {
                ShowErrorMessage(e, tbRegEmail, "Por favor, insira um email válido.");
            }
            else
            {
                DontShowErrorMessage(e, tbRegEmail);
            }
        }

        private void tbRegPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegPassword.Text))
            {
                ShowErrorMessage(e, tbRegPassword, "Por favor, insira a sua password.");
            }
            else
            {
                DontShowErrorMessage(e, tbRegPassword);
            }
        }

        private void tbRegUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegUsername.Text))
            {
                ShowErrorMessage(e, tbRegUsername, "Por favor, insira o seu username.");
            }
            else
            {
                DontShowErrorMessage(e, tbRegUsername);
            }
        }

        private void tbRegAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegAge.Text))
            {
                ShowErrorMessage(e, tbRegAge, "Por favor, insira a sua idade.");
            }
            else if (!IsNumberWithNDigits(tbRegAge.Text, 2))
            {
                ShowErrorMessage(e, tbRegAge, "Por favor, insira um valor válido.");
            }
            else
            {
                DontShowErrorMessage(e, tbRegAge);
            }
        }

        private void tbRegPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegPhone.Text))
            {
                ShowErrorMessage(e, tbRegPhone, "Please enter your phone number.");
            }
            else if (!IsNumberWithNDigits(tbRegPhone.Text, 9))
            {
                ShowErrorMessage(e, tbRegPhone, "Please enter a valid number (9 digits).");
            }
            else
            {
                DontShowErrorMessage(e, tbRegPhone);
            }
        }

        private void ShowErrorMessage(CancelEventArgs e, TextBox tb, string errorString)
        {
            e.Cancel = true;
            tb.Focus();
            errorProvider1.SetError(tb, errorString);
        }

        private void DontShowErrorMessage(CancelEventArgs e, TextBox tb)
        {
            e.Cancel = false;
            errorProvider1.SetError(tb, null);
        }

        private void EnableValidationFromTab(TabPage tab, bool enable)
        {
            foreach (Control c in tab.Controls)
            {
                if (c is TextBox) 
                { 
                    c.CausesValidation = enable;
                }
            }
        }

        private bool IsEmail(string input)
        {
            var email = new EmailAddressAttribute();

            return email.IsValid(input);
        }

        private bool IsNumberWithNDigits(string input, int size)
        {
            return (input.Length == size && input.All(Char.IsDigit));
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton rb = (RadioButton)sender;

                _selectedPicture = Convert.ToInt32(rb.Text);
            }
        }

        private void cPB_Click(object sender, EventArgs e)
        {
            CircularPictureBox circularPB = ((CircularPictureBox)sender);

            switch (circularPB.Name)
            {
                case "cPB1":
                    rb1.Checked = true;
                    break;

                case "cPB2":
                    rb2.Checked = true;
                    break;

                case "cPB3":
                    rb3.Checked = true;
                    break;

                case "cPB4":
                    rb4.Checked = true;
                    break;
            }
        }

    }
}