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
            this.lbParkDescription = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblSportsList = new System.Windows.Forms.Label();
            this.lblAvailableSports = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.plSportsgroundProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSportsgndName
            // 
            this.lbSportsgndName.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbSportsgndName.Location = new System.Drawing.Point(70, 42);
            this.lbSportsgndName.MaximumSize = new System.Drawing.Size(683, 38);
            this.lbSportsgndName.MinimumSize = new System.Drawing.Size(683, 38);
            this.lbSportsgndName.Name = "lbSportsgndName";
            this.lbSportsgndName.Size = new System.Drawing.Size(683, 38);
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
            this.btnSeeEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeEvents.Name = "btnSeeEvents";
            this.btnSeeEvents.Size = new System.Drawing.Size(181, 39);
            this.btnSeeEvents.TabIndex = 1;
            this.btnSeeEvents.Text = "Ver Eventos";
            this.btnSeeEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeeEvents.UseVisualStyleBackColor = true;
            this.btnSeeEvents.Click += new System.EventHandler(this.btnSeeEvents_Click);
            // 
            // plSportsgroundProfile
            // 
            this.plSportsgroundProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSportsgroundProfile.Controls.Add(this.lbParkDescription);
            this.plSportsgroundProfile.Controls.Add(this.pbImage);
            this.plSportsgroundProfile.Controls.Add(this.lblSportsList);
            this.plSportsgroundProfile.Controls.Add(this.lblAvailableSports);
            this.plSportsgroundProfile.Controls.Add(this.tbDescription);
            this.plSportsgroundProfile.Location = new System.Drawing.Point(77, 138);
            this.plSportsgroundProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSportsgroundProfile.Name = "plSportsgroundProfile";
            this.plSportsgroundProfile.Size = new System.Drawing.Size(933, 372);
            this.plSportsgroundProfile.TabIndex = 4;
            // 
            // lbParkDescription
            // 
            this.lbParkDescription.AutoSize = true;
            this.lbParkDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParkDescription.Location = new System.Drawing.Point(15, 17);
            this.lbParkDescription.Name = "lbParkDescription";
            this.lbParkDescription.Size = new System.Drawing.Size(115, 23);
            this.lbParkDescription.TabIndex = 10;
            this.lbParkDescription.Text = "Descrição:";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(549, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(371, 300);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // lblSportsList
            // 
            this.lblSportsList.AutoSize = true;
            this.lblSportsList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblSportsList.Location = new System.Drawing.Point(15, 225);
            this.lblSportsList.Name = "lblSportsList";
            this.lblSportsList.Size = new System.Drawing.Size(72, 23);
            this.lblSportsList.TabIndex = 8;
            this.lblSportsList.Text = "label1";
            // 
            // lblAvailableSports
            // 
            this.lblAvailableSports.AutoSize = true;
            this.lblAvailableSports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableSports.Location = new System.Drawing.Point(13, 197);
            this.lblAvailableSports.Name = "lblAvailableSports";
            this.lblAvailableSports.Size = new System.Drawing.Size(112, 23);
            this.lblAvailableSports.TabIndex = 4;
            this.lblAvailableSports.Text = "Desportos:";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbDescription.Location = new System.Drawing.Point(19, 42);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.MinimumSize = new System.Drawing.Size(300, 50);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(525, 140);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus mattis convallis" +
    " ex, a imperdiet nibh suscipit at. Seria que não mas num lugar distante aqui per" +
    "to, ele anda e tresanda a lixo.";
            // 
            // UC_SportsgroundDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plSportsgroundProfile);
            this.Controls.Add(this.btnSeeEvents);
            this.Controls.Add(this.lbSportsgndName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_SportsgroundDesc";
            this.Size = new System.Drawing.Size(1089, 622);
            this.Load += new System.EventHandler(this.UC_SportsgroundDesc_Load);
            this.plSportsgroundProfile.ResumeLayout(false);
            this.plSportsgroundProfile.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbParkDescription;
    }
}

