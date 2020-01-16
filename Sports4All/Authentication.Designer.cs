namespace Sports4All
{
    partial class Authentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.linkReg = new System.Windows.Forms.LinkLabel();
            this.tbInfoLog = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLogPassword = new System.Windows.Forms.TextBox();
            this.tbLogEmail = new System.Windows.Forms.TextBox();
            this.lblLogPassword = new System.Windows.Forms.Label();
            this.lblLogEmail = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.lblRegPicture = new System.Windows.Forms.Label();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.lblRegCounty = new System.Windows.Forms.Label();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.tbRegPhone = new System.Windows.Forms.TextBox();
            this.lblRegPhone = new System.Windows.Forms.Label();
            this.tbRegAge = new System.Windows.Forms.TextBox();
            this.tbRegUsername = new System.Windows.Forms.TextBox();
            this.lblRegAge = new System.Windows.Forms.Label();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.linkLog = new System.Windows.Forms.LinkLabel();
            this.tbInfoReg = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbRegPassword = new System.Windows.Forms.TextBox();
            this.tbRegEmail = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.cPB4 = new Sports4All.CircularPictureBox();
            this.cPB3 = new Sports4All.CircularPictureBox();
            this.cPB2 = new Sports4All.CircularPictureBox();
            this.cPB1 = new Sports4All.CircularPictureBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Location = new System.Drawing.Point(24, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 557);
            this.tabControl1.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.linkReg);
            this.tabLogin.Controls.Add(this.tbInfoLog);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbLogPassword);
            this.tabLogin.Controls.Add(this.tbLogEmail);
            this.tabLogin.Controls.Add(this.lblLogPassword);
            this.tabLogin.Controls.Add(this.lblLogEmail);
            this.tabLogin.Controls.Add(this.lbLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1057, 524);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "tabPage1";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // linkReg
            // 
            this.linkReg.AutoSize = true;
            this.linkReg.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkReg.LinkColor = System.Drawing.Color.OliveDrab;
            this.linkReg.Location = new System.Drawing.Point(551, 498);
            this.linkReg.Name = "linkReg";
            this.linkReg.Size = new System.Drawing.Size(156, 23);
            this.linkReg.TabIndex = 3;
            this.linkReg.TabStop = true;
            this.linkReg.Text = "Registe-se aqui";
            this.linkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReg_LinkClicked);
            // 
            // tbInfoLog
            // 
            this.tbInfoLog.AutoSize = true;
            this.tbInfoLog.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbInfoLog.Location = new System.Drawing.Point(328, 498);
            this.tbInfoLog.Name = "tbInfoLog";
            this.tbInfoLog.Size = new System.Drawing.Size(217, 23);
            this.tbInfoLog.TabIndex = 7;
            this.tbInfoLog.Text = "Novo na aplicação?";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLogin.Location = new System.Drawing.Point(440, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 55);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLogPassword
            // 
            this.tbLogPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbLogPassword.Location = new System.Drawing.Point(353, 206);
            this.tbLogPassword.Name = "tbLogPassword";
            this.tbLogPassword.PasswordChar = '*';
            this.tbLogPassword.Size = new System.Drawing.Size(434, 34);
            this.tbLogPassword.TabIndex = 1;
            this.tbLogPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbLogPassword_Validating);
            // 
            // tbLogEmail
            // 
            this.tbLogEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbLogEmail.Location = new System.Drawing.Point(353, 166);
            this.tbLogEmail.Name = "tbLogEmail";
            this.tbLogEmail.Size = new System.Drawing.Size(434, 34);
            this.tbLogEmail.TabIndex = 0;
            this.tbLogEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbLogEmail_Validating);
            // 
            // lblLogPassword
            // 
            this.lblLogPassword.AutoSize = true;
            this.lblLogPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblLogPassword.Location = new System.Drawing.Point(201, 206);
            this.lblLogPassword.Name = "lblLogPassword";
            this.lblLogPassword.Size = new System.Drawing.Size(114, 25);
            this.lblLogPassword.TabIndex = 6;
            this.lblLogPassword.Text = "Password";
            // 
            // lblLogEmail
            // 
            this.lblLogEmail.AutoSize = true;
            this.lblLogEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblLogEmail.Location = new System.Drawing.Point(201, 166);
            this.lblLogEmail.Name = "lblLogEmail";
            this.lblLogEmail.Size = new System.Drawing.Size(71, 25);
            this.lblLogEmail.TabIndex = 5;
            this.lblLogEmail.Text = "Email";
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lbLogin.Location = new System.Drawing.Point(3, 3);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(1051, 94);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Bem Vindo!";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.cPB4);
            this.tabRegister.Controls.Add(this.cPB3);
            this.tabRegister.Controls.Add(this.cPB2);
            this.tabRegister.Controls.Add(this.cPB1);
            this.tabRegister.Controls.Add(this.lblRegPicture);
            this.tabRegister.Controls.Add(this.cbCounty);
            this.tabRegister.Controls.Add(this.lblRegCounty);
            this.tabRegister.Controls.Add(this.rb4);
            this.tabRegister.Controls.Add(this.rb3);
            this.tabRegister.Controls.Add(this.rb2);
            this.tabRegister.Controls.Add(this.rb1);
            this.tabRegister.Controls.Add(this.tbRegPhone);
            this.tabRegister.Controls.Add(this.lblRegPhone);
            this.tabRegister.Controls.Add(this.tbRegAge);
            this.tabRegister.Controls.Add(this.tbRegUsername);
            this.tabRegister.Controls.Add(this.lblRegAge);
            this.tabRegister.Controls.Add(this.lblRegUsername);
            this.tabRegister.Controls.Add(this.linkLog);
            this.tabRegister.Controls.Add(this.tbInfoReg);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.tbRegPassword);
            this.tabRegister.Controls.Add(this.tbRegEmail);
            this.tabRegister.Controls.Add(this.lblRegPassword);
            this.tabRegister.Controls.Add(this.lblRegEmail);
            this.tabRegister.Controls.Add(this.lblRegistration);
            this.tabRegister.Location = new System.Drawing.Point(4, 29);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(1057, 524);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "tabPage2";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // lblRegPicture
            // 
            this.lblRegPicture.AutoSize = true;
            this.lblRegPicture.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegPicture.Location = new System.Drawing.Point(49, 232);
            this.lblRegPicture.Name = "lblRegPicture";
            this.lblRegPicture.Size = new System.Drawing.Size(314, 25);
            this.lblRegPicture.TabIndex = 29;
            this.lblRegPicture.Text = "Selecione imagem de perfil:";
            // 
            // cbCounty
            // 
            this.cbCounty.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Location = new System.Drawing.Point(689, 181);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(318, 33);
            this.cbCounty.TabIndex = 28;
            // 
            // lblRegCounty
            // 
            this.lblRegCounty.AutoSize = true;
            this.lblRegCounty.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegCounty.Location = new System.Drawing.Point(552, 182);
            this.lblRegCounty.Name = "lblRegCounty";
            this.lblRegCounty.Size = new System.Drawing.Size(118, 25);
            this.lblRegCounty.TabIndex = 27;
            this.lblRegCounty.Text = "Concelho";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(738, 314);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(43, 24);
            this.rb4.TabIndex = 21;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(561, 314);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(43, 24);
            this.rb3.TabIndex = 20;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(384, 314);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(43, 24);
            this.rb2.TabIndex = 19;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(216, 314);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(43, 24);
            this.rb1.TabIndex = 18;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbRegPhone
            // 
            this.tbRegPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegPhone.Location = new System.Drawing.Point(689, 140);
            this.tbRegPhone.Name = "tbRegPhone";
            this.tbRegPhone.Size = new System.Drawing.Size(318, 34);
            this.tbRegPhone.TabIndex = 4;
            this.tbRegPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegPhone_Validating);
            // 
            // lblRegPhone
            // 
            this.lblRegPhone.AutoSize = true;
            this.lblRegPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegPhone.Location = new System.Drawing.Point(552, 142);
            this.lblRegPhone.Name = "lblRegPhone";
            this.lblRegPhone.Size = new System.Drawing.Size(126, 25);
            this.lblRegPhone.TabIndex = 12;
            this.lblRegPhone.Text = "Telemóvel";
            // 
            // tbRegAge
            // 
            this.tbRegAge.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegAge.Location = new System.Drawing.Point(689, 100);
            this.tbRegAge.Name = "tbRegAge";
            this.tbRegAge.Size = new System.Drawing.Size(318, 34);
            this.tbRegAge.TabIndex = 3;
            this.tbRegAge.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegAge_Validating);
            // 
            // tbRegUsername
            // 
            this.tbRegUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegUsername.Location = new System.Drawing.Point(181, 180);
            this.tbRegUsername.Name = "tbRegUsername";
            this.tbRegUsername.Size = new System.Drawing.Size(318, 34);
            this.tbRegUsername.TabIndex = 2;
            this.tbRegUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegUsername_Validating);
            // 
            // lblRegAge
            // 
            this.lblRegAge.AutoSize = true;
            this.lblRegAge.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegAge.Location = new System.Drawing.Point(555, 102);
            this.lblRegAge.Name = "lblRegAge";
            this.lblRegAge.Size = new System.Drawing.Size(77, 25);
            this.lblRegAge.TabIndex = 11;
            this.lblRegAge.Text = "Idade";
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegUsername.Location = new System.Drawing.Point(47, 182);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(121, 25);
            this.lblRegUsername.TabIndex = 10;
            this.lblRegUsername.Text = "Username";
            // 
            // linkLog
            // 
            this.linkLog.AutoSize = true;
            this.linkLog.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkLog.LinkColor = System.Drawing.Color.OliveDrab;
            this.linkLog.Location = new System.Drawing.Point(572, 498);
            this.linkLog.Name = "linkLog";
            this.linkLog.Size = new System.Drawing.Size(108, 23);
            this.linkLog.TabIndex = 6;
            this.linkLog.TabStop = true;
            this.linkLog.Text = "Entre aqui";
            this.linkLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLog_LinkClicked);
            // 
            // tbInfoReg
            // 
            this.tbInfoReg.AutoSize = true;
            this.tbInfoReg.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbInfoReg.Location = new System.Drawing.Point(395, 498);
            this.tbInfoReg.Name = "tbInfoReg";
            this.tbInfoReg.Size = new System.Drawing.Size(175, 23);
            this.tbInfoReg.TabIndex = 13;
            this.tbInfoReg.Text = "Já possui conta?";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegister.Location = new System.Drawing.Point(441, 408);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 55);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbRegPassword
            // 
            this.tbRegPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegPassword.Location = new System.Drawing.Point(181, 140);
            this.tbRegPassword.Name = "tbRegPassword";
            this.tbRegPassword.PasswordChar = '*';
            this.tbRegPassword.Size = new System.Drawing.Size(318, 34);
            this.tbRegPassword.TabIndex = 1;
            this.tbRegPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegPassword_Validating);
            // 
            // tbRegEmail
            // 
            this.tbRegEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegEmail.Location = new System.Drawing.Point(181, 100);
            this.tbRegEmail.Name = "tbRegEmail";
            this.tbRegEmail.Size = new System.Drawing.Size(318, 34);
            this.tbRegEmail.TabIndex = 0;
            this.tbRegEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegEmail_Validating);
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegPassword.Location = new System.Drawing.Point(47, 142);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(114, 25);
            this.lblRegPassword.TabIndex = 9;
            this.lblRegPassword.Text = "Password";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRegEmail.Location = new System.Drawing.Point(46, 102);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(71, 25);
            this.lblRegEmail.TabIndex = 8;
            this.lblRegEmail.Text = "Email";
            // 
            // lblRegistration
            // 
            this.lblRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistration.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblRegistration.Location = new System.Drawing.Point(3, 3);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(1051, 94);
            this.lblRegistration.TabIndex = 7;
            this.lblRegistration.Text = "Registo";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Sports4All.Properties.Resources.btnExit_Image;
            this.btnExit.Location = new System.Drawing.Point(1059, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 54);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cPB4
            // 
            this.cPB4.Image = global::Sports4All.Properties.Resources.Webp_net_resizeimage__1_;
            this.cPB4.Location = new System.Drawing.Point(762, 284);
            this.cPB4.Name = "cPB4";
            this.cPB4.Size = new System.Drawing.Size(90, 90);
            this.cPB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPB4.TabIndex = 23;
            this.cPB4.TabStop = false;
            this.cPB4.Click += new System.EventHandler(this.cPB_Click);
            // 
            // cPB3
            // 
            this.cPB3.Image = global::Sports4All.Properties.Resources.Webp_net_resizeimage__2_;
            this.cPB3.Location = new System.Drawing.Point(583, 284);
            this.cPB3.Name = "cPB3";
            this.cPB3.Size = new System.Drawing.Size(90, 90);
            this.cPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPB3.TabIndex = 24;
            this.cPB3.TabStop = false;
            this.cPB3.Click += new System.EventHandler(this.cPB_Click);
            // 
            // cPB2
            // 
            this.cPB2.Image = global::Sports4All.Properties.Resources.Webp_net_resizeimage__3_;
            this.cPB2.Location = new System.Drawing.Point(406, 284);
            this.cPB2.Name = "cPB2";
            this.cPB2.Size = new System.Drawing.Size(90, 90);
            this.cPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPB2.TabIndex = 25;
            this.cPB2.TabStop = false;
            this.cPB2.Click += new System.EventHandler(this.cPB_Click);
            // 
            // cPB1
            // 
            this.cPB1.Image = global::Sports4All.Properties.Resources.Webp_net_resizeimage;
            this.cPB1.Location = new System.Drawing.Point(238, 284);
            this.cPB1.Name = "cPB1";
            this.cPB1.Size = new System.Drawing.Size(90, 90);
            this.cPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPB1.TabIndex = 22;
            this.cPB1.TabStop = false;
            this.cPB1.Click += new System.EventHandler(this.cPB_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1120, 601);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkReg;
        private System.Windows.Forms.Label tbInfoLog;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLogPassword;
        private System.Windows.Forms.TextBox tbLogEmail;
        private System.Windows.Forms.Label lblLogPassword;
        private System.Windows.Forms.Label lblLogEmail;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbRegPhone;
        private System.Windows.Forms.Label lblRegPhone;
        private System.Windows.Forms.TextBox tbRegAge;
        private System.Windows.Forms.TextBox tbRegUsername;
        private System.Windows.Forms.Label lblRegAge;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.LinkLabel linkLog;
        private System.Windows.Forms.Label tbInfoReg;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbRegPassword;
        private System.Windows.Forms.TextBox tbRegEmail;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private CircularPictureBox cPB2;
        private CircularPictureBox cPB3;
        private CircularPictureBox cPB4;
        private CircularPictureBox cPB1;
        private System.Windows.Forms.Label lblRegPicture;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.Label lblRegCounty;
    }
}