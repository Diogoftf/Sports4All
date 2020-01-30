namespace Sports4All
{
    partial class UC_SportsgroundDesc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SportsgroundDesc));
            this.lbSportsgndName = new System.Windows.Forms.Label();
            this.btnSeeEvents = new System.Windows.Forms.Button();
            this.plSportsgroundProfile = new System.Windows.Forms.Panel();
            this.lblSportsList = new System.Windows.Forms.Label();
            this.lblAvailableSports = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pbSubscribe = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.plSportsgroundProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSportsgndName
            // 
            this.lbSportsgndName.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbSportsgndName.Location = new System.Drawing.Point(88, 34);
            this.lbSportsgndName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSportsgndName.MaximumSize = new System.Drawing.Size(512, 31);
            this.lbSportsgndName.MinimumSize = new System.Drawing.Size(512, 31);
            this.lbSportsgndName.Name = "lbSportsgndName";
            this.lbSportsgndName.Size = new System.Drawing.Size(512, 31);
            this.lbSportsgndName.TabIndex = 0;
            this.lbSportsgndName.Text = "Matur";
            // 
            // btnSeeEvents
            // 
            this.btnSeeEvents.AutoSize = true;
            this.btnSeeEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeEvents.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSeeEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeEvents.Image")));
            this.btnSeeEvents.Location = new System.Drawing.Point(613, 34);
            this.btnSeeEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeeEvents.Name = "btnSeeEvents";
            this.btnSeeEvents.Size = new System.Drawing.Size(136, 32);
            this.btnSeeEvents.TabIndex = 1;
            this.btnSeeEvents.Text = "Ver Eventos";
            this.btnSeeEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeeEvents.UseVisualStyleBackColor = true;
            this.btnSeeEvents.Click += new System.EventHandler(this.btnSeeEvents_Click);
            // 
            // plSportsgroundProfile
            // 
            this.plSportsgroundProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSportsgroundProfile.Controls.Add(this.pbImage);
            this.plSportsgroundProfile.Controls.Add(this.lblSportsList);
            this.plSportsgroundProfile.Controls.Add(this.lblAvailableSports);
            this.plSportsgroundProfile.Controls.Add(this.tbDescription);
            this.plSportsgroundProfile.Location = new System.Drawing.Point(58, 112);
            this.plSportsgroundProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plSportsgroundProfile.Name = "plSportsgroundProfile";
            this.plSportsgroundProfile.Size = new System.Drawing.Size(700, 303);
            this.plSportsgroundProfile.TabIndex = 4;
            // 
            // lblSportsList
            // 
            this.lblSportsList.AutoSize = true;
            this.lblSportsList.Location = new System.Drawing.Point(11, 183);
            this.lblSportsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSportsList.Name = "lblSportsList";
            this.lblSportsList.Size = new System.Drawing.Size(41, 15);
            this.lblSportsList.TabIndex = 8;
            this.lblSportsList.Text = "label1";
            // 
            // lblAvailableSports
            // 
            this.lblAvailableSports.AutoSize = true;
            this.lblAvailableSports.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblAvailableSports.Location = new System.Drawing.Point(10, 160);
            this.lblAvailableSports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableSports.Name = "lblAvailableSports";
            this.lblAvailableSports.Size = new System.Drawing.Size(150, 21);
            this.lblAvailableSports.TabIndex = 4;
            this.lblAvailableSports.Text = "Available Sports:";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(14, 34);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescription.MinimumSize = new System.Drawing.Size(225, 41);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(394, 114);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus mattis convallis" +
    " ex, a imperdiet nibh suscipit at. Seria que não mas num lugar distante aqui per" +
    "to, ele anda e tresanda a lixo.";
            // 
            // pbSubscribe
            // 
            this.pbSubscribe.Image = ((System.Drawing.Image)(resources.GetObject("pbSubscribe.Image")));
            this.pbSubscribe.Location = new System.Drawing.Point(58, 34);
            this.pbSubscribe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSubscribe.Name = "pbSubscribe";
            this.pbSubscribe.Size = new System.Drawing.Size(26, 30);
            this.pbSubscribe.TabIndex = 2;
            this.pbSubscribe.TabStop = false;
            this.pbSubscribe.Click += new System.EventHandler(this.pbSubscribe_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(425, 14);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(254, 254);
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // UC_SportsgroundDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plSportsgroundProfile);
            this.Controls.Add(this.pbSubscribe);
            this.Controls.Add(this.btnSeeEvents);
            this.Controls.Add(this.lbSportsgndName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_SportsgroundDesc";
            this.Size = new System.Drawing.Size(817, 505);
            this.Load += new System.EventHandler(this.UC_SportsgroundDesc_Load);
            this.plSportsgroundProfile.ResumeLayout(false);
            this.plSportsgroundProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSportsgndName;
        private System.Windows.Forms.Button btnSeeEvents;
        private System.Windows.Forms.Panel plSportsgroundProfile;
        private System.Windows.Forms.Label lblAvailableSports;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblSportsList;
        private System.Windows.Forms.PictureBox pbSubscribe;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

