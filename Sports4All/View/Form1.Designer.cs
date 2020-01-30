namespace Sports4All
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnRanking = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbPointsUser = new System.Windows.Forms.Label();
            this.lbSkillUser = new System.Windows.Forms.Label();
            this.lbWelcomeUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnAddfriend = new System.Windows.Forms.Button();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lbSkillValue = new System.Windows.Forms.Label();
            this.lbFairplayValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnRanking);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 941);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.OliveDrab;
            this.SidePanel.Location = new System.Drawing.Point(2, 94);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 82);
            this.SidePanel.TabIndex = 4;
            // 
            // btnRanking
            // 
            this.btnRanking.FlatAppearance.BorderSize = 0;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.White;
            this.btnRanking.Image = global::Sports4All.Properties.Resources.goal;
            this.btnRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRanking.Location = new System.Drawing.Point(18, 504);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(296, 82);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.Text = "       Classificações";
            this.btnRanking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.BtnRanking_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Sports4All.Properties.Resources._event;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(18, 422);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(296, 82);
            this.button6.TabIndex = 4;
            this.button6.Text = "       Minhas Partidas";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_MyEvents_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Sports4All.Properties.Resources.ui;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(18, 340);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 82);
            this.button4.TabIndex = 4;
            this.button4.Text = "       Subscrições";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_Subscriptions_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Sports4All.Properties.Resources.stadium;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(18, 258);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 82);
            this.button3.TabIndex = 4;
            this.button3.Text = "       Parques                Desportivos";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_SportsGround_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Sports4All.Properties.Resources.soccer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "       Eventos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Events_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = global::Sports4All.Properties.Resources.empire_state_building__2_;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(18, 91);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(296, 82);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "       Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 14);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(314, 128);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1856, 2);
            this.panel5.TabIndex = 70;
            // 
            // lbPointsUser
            // 
            this.lbPointsUser.AutoSize = true;
            this.lbPointsUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointsUser.Location = new System.Drawing.Point(463, 67);
            this.lbPointsUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPointsUser.Name = "lbPointsUser";
            this.lbPointsUser.Size = new System.Drawing.Size(46, 22);
            this.lbPointsUser.TabIndex = 61;
            this.lbPointsUser.Text = "Skill:";
            // 
            // lbSkillUser
            // 
            this.lbSkillUser.AutoSize = true;
            this.lbSkillUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkillUser.Location = new System.Drawing.Point(463, 91);
            this.lbSkillUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSkillUser.Name = "lbSkillUser";
            this.lbSkillUser.Size = new System.Drawing.Size(84, 22);
            this.lbSkillUser.TabIndex = 59;
            this.lbSkillUser.Text = "Fairplay:";
            // 
            // lbWelcomeUser
            // 
            this.lbWelcomeUser.AutoSize = true;
            this.lbWelcomeUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeUser.Location = new System.Drawing.Point(463, 24);
            this.lbWelcomeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcomeUser.Name = "lbWelcomeUser";
            this.lbWelcomeUser.Size = new System.Drawing.Size(254, 23);
            this.lbWelcomeUser.TabIndex = 57;
            this.lbWelcomeUser.Text = "Bem-vindo, <USERNAME>";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1585, 38);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 54);
            this.btnExit.TabIndex = 66;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNotification.Image")));
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(1529, 38);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(48, 54);
            this.btnNotification.TabIndex = 68;
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnAddfriend
            // 
            this.btnAddfriend.FlatAppearance.BorderSize = 0;
            this.btnAddfriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddfriend.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddfriend.ForeColor = System.Drawing.Color.White;
            this.btnAddfriend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddfriend.Image")));
            this.btnAddfriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddfriend.Location = new System.Drawing.Point(1458, 40);
            this.btnAddfriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddfriend.Name = "btnAddfriend";
            this.btnAddfriend.Size = new System.Drawing.Size(62, 52);
            this.btnAddfriend.TabIndex = 58;
            this.btnAddfriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddfriend.UseVisualStyleBackColor = true;
            this.btnAddfriend.Click += new System.EventHandler(this.Btn_Addfriend_Click);
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pbUserImage.Image")));
            this.pbUserImage.Location = new System.Drawing.Point(340, 24);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(100, 99);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 56;
            this.pbUserImage.TabStop = false;
            this.pbUserImage.Click += new System.EventHandler(this.PbUserImage_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(323, 137);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1312, 790);
            this.panelContainer.TabIndex = 71;
            // 
            // lbSkillValue
            // 
            this.lbSkillValue.AutoSize = true;
            this.lbSkillValue.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbSkillValue.Location = new System.Drawing.Point(512, 67);
            this.lbSkillValue.Name = "lbSkillValue";
            this.lbSkillValue.Size = new System.Drawing.Size(0, 21);
            this.lbSkillValue.TabIndex = 72;
            // 
            // lbFairplayValue
            // 
            this.lbFairplayValue.AutoSize = true;
            this.lbFairplayValue.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbFairplayValue.Location = new System.Drawing.Point(553, 91);
            this.lbFairplayValue.Name = "lbFairplayValue";
            this.lbFairplayValue.Size = new System.Drawing.Size(0, 21);
            this.lbFairplayValue.TabIndex = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1648, 941);
            this.Controls.Add(this.lbFairplayValue);
            this.Controls.Add(this.lbSkillValue);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.lbPointsUser);
            this.Controls.Add(this.lbSkillUser);
            this.Controls.Add(this.btnAddfriend);
            this.Controls.Add(this.lbWelcomeUser);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1648, 941);
            this.MinimumSize = new System.Drawing.Size(1648, 941);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private UC_SportsGround recintosControl1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Label lbPointsUser;
        private System.Windows.Forms.Label lbSkillUser;
        private System.Windows.Forms.Button btnAddfriend;
        private System.Windows.Forms.Label lbWelcomeUser;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbSkillValue;
        private System.Windows.Forms.Label lbFairplayValue;
    }
}

