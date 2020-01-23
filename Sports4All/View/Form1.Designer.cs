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
            this.lbPoints = new System.Windows.Forms.Label();
            this.lbPointsUser = new System.Windows.Forms.Label();
            this.lbSkillUser = new System.Windows.Forms.Label();
            this.lbWelcomeUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.btnAddfriend = new System.Windows.Forms.Button();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.uC_EventsSportsGrounds1 = new Sports4All.UC_EventsSportsGrounds();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.panelContainer.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 784);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.OliveDrab;
            this.SidePanel.Location = new System.Drawing.Point(2, 78);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 68);
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
            this.btnRanking.Location = new System.Drawing.Point(15, 420);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(247, 68);
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
            this.button6.Location = new System.Drawing.Point(15, 352);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(247, 68);
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
            this.button4.Location = new System.Drawing.Point(15, 283);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 68);
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
            this.button3.Location = new System.Drawing.Point(15, 215);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 68);
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
            this.button2.Location = new System.Drawing.Point(15, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 68);
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
            this.btn_Home.Location = new System.Drawing.Point(15, 76);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(247, 68);
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
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(262, 107);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1547, 2);
            this.panel5.TabIndex = 70;
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbPoints.Location = new System.Drawing.Point(454, 56);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(25, 20);
            this.lbPoints.TabIndex = 69;
            this.lbPoints.Text = "22";
            // 
            // lbPointsUser
            // 
            this.lbPointsUser.AutoSize = true;
            this.lbPointsUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointsUser.Location = new System.Drawing.Point(386, 56);
            this.lbPointsUser.Name = "lbPointsUser";
            this.lbPointsUser.Size = new System.Drawing.Size(62, 20);
            this.lbPointsUser.TabIndex = 61;
            this.lbPointsUser.Text = "Pontos:";
            // 
            // lbSkillUser
            // 
            this.lbSkillUser.AutoSize = true;
            this.lbSkillUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkillUser.Location = new System.Drawing.Point(386, 77);
            this.lbSkillUser.Name = "lbSkillUser";
            this.lbSkillUser.Size = new System.Drawing.Size(98, 20);
            this.lbSkillUser.TabIndex = 59;
            this.lbSkillUser.Text = "Habilidades:";
            // 
            // lbWelcomeUser
            // 
            this.lbWelcomeUser.AutoSize = true;
            this.lbWelcomeUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeUser.Location = new System.Drawing.Point(386, 22);
            this.lbWelcomeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcomeUser.Name = "lbWelcomeUser";
            this.lbWelcomeUser.Size = new System.Drawing.Size(220, 21);
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
            this.btnExit.Location = new System.Drawing.Point(1321, 32);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 45);
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
            this.btnNotification.Location = new System.Drawing.Point(1274, 32);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(40, 45);
            this.btnNotification.TabIndex = 68;
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // pbStar5
            // 
            this.pbStar5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbStar5.Image = ((System.Drawing.Image)(resources.GetObject("pbStar5.Image")));
            this.pbStar5.Location = new System.Drawing.Point(567, 77);
            this.pbStar5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(23, 22);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar5.TabIndex = 65;
            this.pbStar5.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbStar4.Image = ((System.Drawing.Image)(resources.GetObject("pbStar4.Image")));
            this.pbStar4.Location = new System.Drawing.Point(547, 77);
            this.pbStar4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(23, 22);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar4.TabIndex = 64;
            this.pbStar4.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbStar3.Image = ((System.Drawing.Image)(resources.GetObject("pbStar3.Image")));
            this.pbStar3.Location = new System.Drawing.Point(525, 77);
            this.pbStar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(23, 22);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar3.TabIndex = 63;
            this.pbStar3.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbStar2.Image = ((System.Drawing.Image)(resources.GetObject("pbStar2.Image")));
            this.pbStar2.Location = new System.Drawing.Point(506, 77);
            this.pbStar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(23, 22);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar2.TabIndex = 62;
            this.pbStar2.TabStop = false;
            // 
            // pbStar1
            // 
            this.pbStar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbStar1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbStar1.ErrorImage")));
            this.pbStar1.Image = ((System.Drawing.Image)(resources.GetObject("pbStar1.Image")));
            this.pbStar1.Location = new System.Drawing.Point(484, 77);
            this.pbStar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(23, 22);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStar1.TabIndex = 60;
            this.pbStar1.TabStop = false;
            // 
            // btnAddfriend
            // 
            this.btnAddfriend.FlatAppearance.BorderSize = 0;
            this.btnAddfriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddfriend.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddfriend.ForeColor = System.Drawing.Color.White;
            this.btnAddfriend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddfriend.Image")));
            this.btnAddfriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddfriend.Location = new System.Drawing.Point(1215, 33);
            this.btnAddfriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddfriend.Name = "btnAddfriend";
            this.btnAddfriend.Size = new System.Drawing.Size(52, 43);
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
            this.pbUserImage.Location = new System.Drawing.Point(283, 20);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(84, 83);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 56;
            this.pbUserImage.TabStop = false;
            this.pbUserImage.Click += new System.EventHandler(this.PbUserImage_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.uC_EventsSportsGrounds1);
            this.panelContainer.Location = new System.Drawing.Point(269, 114);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1093, 658);
            this.panelContainer.TabIndex = 71;
            // 
            // uC_EventsSportsGrounds1
            // 
            this.uC_EventsSportsGrounds1.Location = new System.Drawing.Point(-7, -4);
            this.uC_EventsSportsGrounds1.Name = "uC_EventsSportsGrounds1";
            this.uC_EventsSportsGrounds1.Size = new System.Drawing.Size(1089, 622);
            this.uC_EventsSportsGrounds1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1373, 784);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.pbStar5);
            this.Controls.Add(this.pbStar4);
            this.Controls.Add(this.pbStar3);
            this.Controls.Add(this.pbStar2);
            this.Controls.Add(this.lbPointsUser);
            this.Controls.Add(this.pbStar1);
            this.Controls.Add(this.lbSkillUser);
            this.Controls.Add(this.btnAddfriend);
            this.Controls.Add(this.lbWelcomeUser);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1373, 784);
            this.MinimumSize = new System.Drawing.Size(1373, 784);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.panelContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.Label lbPointsUser;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.Label lbSkillUser;
        private System.Windows.Forms.Button btnAddfriend;
        private System.Windows.Forms.Label lbWelcomeUser;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Panel panelContainer;
        private UC_EventsSportsGrounds uC_EventsSportsGrounds1;
    }
}

