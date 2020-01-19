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
            this.pbSubscribe = new System.Windows.Forms.PictureBox();
            this.plSportsgroundProfile = new System.Windows.Forms.Panel();
            this.lblAvailableSports = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pbPark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscribe)).BeginInit();
            this.plSportsgroundProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPark)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSportsgndName
            // 
            this.lbSportsgndName.AutoSize = true;
            this.lbSportsgndName.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbSportsgndName.Location = new System.Drawing.Point(70, 38);
            this.lbSportsgndName.Name = "lbSportsgndName";
            this.lbSportsgndName.Size = new System.Drawing.Size(103, 37);
            this.lbSportsgndName.TabIndex = 0;
            this.lbSportsgndName.Text = "Matur";
            // 
            // btnSeeEvents
            // 
            this.btnSeeEvents.AutoSize = true;
            this.btnSeeEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeEvents.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSeeEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeEvents.Image")));
            this.btnSeeEvents.Location = new System.Drawing.Point(817, 42);
            this.btnSeeEvents.Name = "btnSeeEvents";
            this.btnSeeEvents.Size = new System.Drawing.Size(182, 33);
            this.btnSeeEvents.TabIndex = 1;
            this.btnSeeEvents.Text = "Ver Eventos";
            this.btnSeeEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeeEvents.UseVisualStyleBackColor = true;
            // 
            // pbSubscribe
            // 
            this.pbSubscribe.Image = ((System.Drawing.Image)(resources.GetObject("pbSubscribe.Image")));
            this.pbSubscribe.Location = new System.Drawing.Point(179, 38);
            this.pbSubscribe.Name = "pbSubscribe";
            this.pbSubscribe.Size = new System.Drawing.Size(35, 37);
            this.pbSubscribe.TabIndex = 2;
            this.pbSubscribe.TabStop = false;
            // 
            // plSportsgroundProfile
            // 
            this.plSportsgroundProfile.Controls.Add(this.pbPark);
            this.plSportsgroundProfile.Controls.Add(this.lblAvailableSports);
            this.plSportsgroundProfile.Controls.Add(this.tbDescription);
            this.plSportsgroundProfile.Location = new System.Drawing.Point(77, 138);
            this.plSportsgroundProfile.Name = "plSportsgroundProfile";
            this.plSportsgroundProfile.Size = new System.Drawing.Size(932, 372);
            this.plSportsgroundProfile.TabIndex = 4;
            // 
            // lblAvailableSports
            // 
            this.lblAvailableSports.AutoSize = true;
            this.lblAvailableSports.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblAvailableSports.Location = new System.Drawing.Point(14, 197);
            this.lblAvailableSports.Name = "lblAvailableSports";
            this.lblAvailableSports.Size = new System.Drawing.Size(150, 21);
            this.lblAvailableSports.TabIndex = 4;
            this.lblAvailableSports.Text = "Available Sports:";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(3, 54);
            this.tbDescription.MinimumSize = new System.Drawing.Size(300, 50);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(541, 140);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus mattis convallis" +
    " ex, a imperdiet nibh suscipit at. Seria que não mas num lugar distante aqui per" +
    "to, ele anda e tresanda a lixo.";
            // 
            // pbPark
            // 
            this.pbPark.Location = new System.Drawing.Point(564, 26);
            this.pbPark.Name = "pbPark";
            this.pbPark.Size = new System.Drawing.Size(358, 192);
            this.pbPark.TabIndex = 0;
            this.pbPark.TabStop = false;
            // 
            // UC_SportsgroundDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plSportsgroundProfile);
            this.Controls.Add(this.pbSubscribe);
            this.Controls.Add(this.btnSeeEvents);
            this.Controls.Add(this.lbSportsgndName);
            this.Name = "UC_SportsgroundDesc";
            this.Size = new System.Drawing.Size(1089, 622);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscribe)).EndInit();
            this.plSportsgroundProfile.ResumeLayout(false);
            this.plSportsgroundProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSportsgndName;
        private System.Windows.Forms.Button btnSeeEvents;
        private System.Windows.Forms.PictureBox pbSubscribe;
        private System.Windows.Forms.Panel plSportsgroundProfile;
        private System.Windows.Forms.Label lblAvailableSports;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.PictureBox pbPark;
    }
}

