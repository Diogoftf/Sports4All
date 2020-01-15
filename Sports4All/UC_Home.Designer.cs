namespace Sports4All
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.lvEvaluation = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbNextEvents = new System.Windows.Forms.Label();
            this.lbMyevents = new System.Windows.Forms.Label();
            this.lbHighlights = new System.Windows.Forms.Label();
            this.lbEvaluation = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbMonthEnclosure = new System.Windows.Forms.Label();
            this.lbMonthuser = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.pbMonthuser = new System.Windows.Forms.PictureBox();
            this.cbMySport = new System.Windows.Forms.ComboBox();
            this.lbMySportDate = new System.Windows.Forms.Label();
            this.dtpMySportDate = new System.Windows.Forms.DateTimePicker();
            this.dtpNextEventDate = new System.Windows.Forms.DateTimePicker();
            this.lbNextEventDate = new System.Windows.Forms.Label();
            this.lbNextSport = new System.Windows.Forms.Label();
            this.cbNextSport = new System.Windows.Forms.ComboBox();
            this.lbMySport = new System.Windows.Forms.Label();
            this.pbMonthEnclosure = new System.Windows.Forms.PictureBox();
            this.flpMyEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNextEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.UC_CreateEvent1 = new Sports4All.UC_CreateEvent();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthEnclosure)).BeginInit();
            this.SuspendLayout();
            // 
            // lvEvaluation
            // 
            this.lvEvaluation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15});
            this.lvEvaluation.HideSelection = false;
            this.lvEvaluation.Location = new System.Drawing.Point(974, 528);
            this.lvEvaluation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvEvaluation.Name = "lvEvaluation";
            this.lvEvaluation.Size = new System.Drawing.Size(250, 167);
            this.lvEvaluation.TabIndex = 63;
            this.lvEvaluation.UseCompatibleStateImageBehavior = false;
            this.lvEvaluation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Recinto";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 64;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Data";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 58;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Hora";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 51;
            // 
            // lbNextEvents
            // 
            this.lbNextEvents.AutoSize = true;
            this.lbNextEvents.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextEvents.Location = new System.Drawing.Point(10, 428);
            this.lbNextEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNextEvents.Name = "lbNextEvents";
            this.lbNextEvents.Size = new System.Drawing.Size(197, 26);
            this.lbNextEvents.TabIndex = 61;
            this.lbNextEvents.Text = "Proximos eventos";
            // 
            // lbMyevents
            // 
            this.lbMyevents.AutoSize = true;
            this.lbMyevents.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyevents.Location = new System.Drawing.Point(10, 18);
            this.lbMyevents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMyevents.Name = "lbMyevents";
            this.lbMyevents.Size = new System.Drawing.Size(159, 26);
            this.lbMyevents.TabIndex = 60;
            this.lbMyevents.Text = "Meus eventos";
            // 
            // lbHighlights
            // 
            this.lbHighlights.AutoSize = true;
            this.lbHighlights.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighlights.Location = new System.Drawing.Point(969, 11);
            this.lbHighlights.Name = "lbHighlights";
            this.lbHighlights.Size = new System.Drawing.Size(211, 26);
            this.lbHighlights.TabIndex = 52;
            this.lbHighlights.Text = "Destaques do mês";
            this.lbHighlights.Click += new System.EventHandler(this.lbHighlights_Click);
            // 
            // lbEvaluation
            // 
            this.lbEvaluation.AutoSize = true;
            this.lbEvaluation.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvaluation.Location = new System.Drawing.Point(1024, 495);
            this.lbEvaluation.Name = "lbEvaluation";
            this.lbEvaluation.Size = new System.Drawing.Size(132, 26);
            this.lbEvaluation.TabIndex = 57;
            this.lbEvaluation.Text = "Avaliações";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel7.Location = new System.Drawing.Point(0, 378);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(444, 1);
            this.panel7.TabIndex = 51;
            // 
            // lbMonthEnclosure
            // 
            this.lbMonthEnclosure.AutoSize = true;
            this.lbMonthEnclosure.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbMonthEnclosure.Location = new System.Drawing.Point(1034, 402);
            this.lbMonthEnclosure.Name = "lbMonthEnclosure";
            this.lbMonthEnclosure.Size = new System.Drawing.Size(78, 21);
            this.lbMonthEnclosure.TabIndex = 56;
            this.lbMonthEnclosure.Text = "Recinto";
            // 
            // lbMonthuser
            // 
            this.lbMonthuser.AutoSize = true;
            this.lbMonthuser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthuser.Location = new System.Drawing.Point(1020, 198);
            this.lbMonthuser.Name = "lbMonthuser";
            this.lbMonthuser.Size = new System.Drawing.Size(87, 21);
            this.lbMonthuser.TabIndex = 54;
            this.lbMonthuser.Text = "Utilizador";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel6.Location = new System.Drawing.Point(926, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 1149);
            this.panel6.TabIndex = 50;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateEvent.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnCreateEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateEvent.Image")));
            this.btnCreateEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateEvent.Location = new System.Drawing.Point(362, 337);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(200, 62);
            this.btnCreateEvent.TabIndex = 59;
            this.btnCreateEvent.Text = "Criar Evento";
            this.btnCreateEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // pbMonthuser
            // 
            this.pbMonthuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMonthuser.Location = new System.Drawing.Point(998, 55);
            this.pbMonthuser.Name = "pbMonthuser";
            this.pbMonthuser.Size = new System.Drawing.Size(138, 139);
            this.pbMonthuser.TabIndex = 53;
            this.pbMonthuser.TabStop = false;
            // 
            // cbMySport
            // 
            this.cbMySport.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbMySport.FormattingEnabled = true;
            this.cbMySport.Location = new System.Drawing.Point(357, 11);
            this.cbMySport.Name = "cbMySport";
            this.cbMySport.Size = new System.Drawing.Size(157, 38);
            this.cbMySport.TabIndex = 67;
            this.cbMySport.SelectedIndexChanged += new System.EventHandler(this.cbMySport_SelectedIndexChanged);
            // 
            // lbMySportDate
            // 
            this.lbMySportDate.AutoSize = true;
            this.lbMySportDate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbMySportDate.Location = new System.Drawing.Point(520, 17);
            this.lbMySportDate.Name = "lbMySportDate";
            this.lbMySportDate.Size = new System.Drawing.Size(66, 25);
            this.lbMySportDate.TabIndex = 69;
            this.lbMySportDate.Text = "Data";
            this.lbMySportDate.Click += new System.EventHandler(this.lbMySportDate_Click);
            // 
            // dtpMySportDate
            // 
            this.dtpMySportDate.CustomFormat = "";
            this.dtpMySportDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpMySportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMySportDate.Location = new System.Drawing.Point(594, 11);
            this.dtpMySportDate.Name = "dtpMySportDate";
            this.dtpMySportDate.Size = new System.Drawing.Size(182, 37);
            this.dtpMySportDate.TabIndex = 70;
            this.dtpMySportDate.ValueChanged += new System.EventHandler(this.dtpMySportDate_ValueChanged);
            // 
            // dtpNextEventDate
            // 
            this.dtpNextEventDate.CustomFormat = "";
            this.dtpNextEventDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpNextEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextEventDate.Location = new System.Drawing.Point(594, 415);
            this.dtpNextEventDate.Name = "dtpNextEventDate";
            this.dtpNextEventDate.Size = new System.Drawing.Size(192, 37);
            this.dtpNextEventDate.TabIndex = 76;
            // 
            // lbNextEventDate
            // 
            this.lbNextEventDate.AutoSize = true;
            this.lbNextEventDate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbNextEventDate.Location = new System.Drawing.Point(520, 422);
            this.lbNextEventDate.Name = "lbNextEventDate";
            this.lbNextEventDate.Size = new System.Drawing.Size(66, 25);
            this.lbNextEventDate.TabIndex = 75;
            this.lbNextEventDate.Text = "Data";
            this.lbNextEventDate.Click += new System.EventHandler(this.lbNextEventDate_Click);
            // 
            // lbNextSport
            // 
            this.lbNextSport.AutoSize = true;
            this.lbNextSport.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbNextSport.Location = new System.Drawing.Point(242, 425);
            this.lbNextSport.Name = "lbNextSport";
            this.lbNextSport.Size = new System.Drawing.Size(109, 25);
            this.lbNextSport.TabIndex = 72;
            this.lbNextSport.Text = "Desporto";
            // 
            // cbNextSport
            // 
            this.cbNextSport.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbNextSport.FormattingEnabled = true;
            this.cbNextSport.Location = new System.Drawing.Point(357, 419);
            this.cbNextSport.Name = "cbNextSport";
            this.cbNextSport.Size = new System.Drawing.Size(157, 38);
            this.cbNextSport.TabIndex = 71;
            this.cbNextSport.SelectedIndexChanged += new System.EventHandler(this.cbNextSport_SelectedIndexChanged);
            // 
            // lbMySport
            // 
            this.lbMySport.AutoSize = true;
            this.lbMySport.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbMySport.Location = new System.Drawing.Point(242, 15);
            this.lbMySport.Name = "lbMySport";
            this.lbMySport.Size = new System.Drawing.Size(109, 25);
            this.lbMySport.TabIndex = 77;
            this.lbMySport.Text = "Desporto";
            // 
            // pbMonthEnclosure
            // 
            this.pbMonthEnclosure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMonthEnclosure.Location = new System.Drawing.Point(998, 245);
            this.pbMonthEnclosure.Name = "pbMonthEnclosure";
            this.pbMonthEnclosure.Size = new System.Drawing.Size(138, 139);
            this.pbMonthEnclosure.TabIndex = 78;
            this.pbMonthEnclosure.TabStop = false;
            // 
            // flpMyEvents
            // 
            this.flpMyEvents.AutoScroll = true;
            this.flpMyEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMyEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flpMyEvents.Location = new System.Drawing.Point(15, 55);
            this.flpMyEvents.Name = "flpMyEvents";
            this.flpMyEvents.Size = new System.Drawing.Size(886, 273);
            this.flpMyEvents.TabIndex = 79;
            // 
            // flpNextEvents
            // 
            this.flpNextEvents.AutoScroll = true;
            this.flpNextEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpNextEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flpNextEvents.Location = new System.Drawing.Point(15, 463);
            this.flpNextEvents.Name = "flpNextEvents";
            this.flpNextEvents.Size = new System.Drawing.Size(886, 291);
            this.flpNextEvents.TabIndex = 80;
            // 
            // UC_CreateEvent1
            // 
            this.UC_CreateEvent1.Location = new System.Drawing.Point(6, 337);
            this.UC_CreateEvent1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_CreateEvent1.Name = "UC_CreateEvent1";
            this.UC_CreateEvent1.Size = new System.Drawing.Size(435, 448);
            this.UC_CreateEvent1.TabIndex = 81;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_CreateEvent1);
            this.Controls.Add(this.flpNextEvents);
            this.Controls.Add(this.flpMyEvents);
            this.Controls.Add(this.pbMonthEnclosure);
            this.Controls.Add(this.lbMySport);
            this.Controls.Add(this.dtpNextEventDate);
            this.Controls.Add(this.lbNextEventDate);
            this.Controls.Add(this.lbNextSport);
            this.Controls.Add(this.cbNextSport);
            this.Controls.Add(this.dtpMySportDate);
            this.Controls.Add(this.lbMySportDate);
            this.Controls.Add(this.cbMySport);
            this.Controls.Add(this.lvEvaluation);
            this.Controls.Add(this.lbNextEvents);
            this.Controls.Add(this.lbMyevents);
            this.Controls.Add(this.lbHighlights);
            this.Controls.Add(this.lbEvaluation);
            this.Controls.Add(this.lbMonthEnclosure);
            this.Controls.Add(this.lbMonthuser);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pbMonthuser);
            this.Controls.Add(this.btnCreateEvent);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1226, 778);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonthEnclosure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEvaluation;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label lbNextEvents;
        private System.Windows.Forms.Label lbMyevents;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label lbHighlights;
        private System.Windows.Forms.Label lbEvaluation;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbMonthEnclosure;
        private System.Windows.Forms.PictureBox pbMonthuser;
        private System.Windows.Forms.Panel panel6;
        //private UC_CreateEvent criarEvento1;
        private System.Windows.Forms.ComboBox cbMySport;
        private System.Windows.Forms.Label lbMySportDate;
        private System.Windows.Forms.DateTimePicker dtpMySportDate;
        private System.Windows.Forms.DateTimePicker dtpNextEventDate;
        private System.Windows.Forms.Label lbNextEventDate;
        private System.Windows.Forms.Label lbNextSport;
        private System.Windows.Forms.ComboBox cbNextSport;
        private System.Windows.Forms.Label lbMySport;
        private System.Windows.Forms.PictureBox pbMonthEnclosure;
        private System.Windows.Forms.Label lbMonthuser;
        private System.Windows.Forms.FlowLayoutPanel flpMyEvents;
        private System.Windows.Forms.FlowLayoutPanel flpNextEvents;
        private UC_CreateEvent UC_CreateEvent1;
        //private UC_CreateEvent UC_CreateEvent1;
    }
}
